using HealthApp.Constant;

using HealthApp.Exceptions;
using HealthApp.Model;

using HealthApp.Repository.Interface;
using HealthApp.Service.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HealthApp.Service.Impl
{
    public class AppointmentService
        : IAppointmentService
    {
        private readonly IAppointmentRepository _repo;

        public AppointmentService(
            IAppointmentRepository repo)
        {
            _repo = repo;
        }

        public Appointment BookAppointment(
            Patient patient,
            Doctor doctor,
            DateTime date,
            string slot)
        {
            if (date.Date < DateTime.Today)
            {
                throw new PastDateException(
                    "Cannot book past date.");
            }

            if (!doctor.IsActive)
            {
                throw new DoctorUnavailableException(
                    "Doctor unavailable.");
            }

            if (!TimeSlots.Slots.Contains(slot))
            {
                throw new InvalidSlotException(
                    "Invalid slot.");
            }




            if (date.Date == DateTime.Today)
            {
                DateTime slotTime = DateTime.ParseExact(
                    slot,
                    "hh:mm tt",
                    CultureInfo.InvariantCulture);

                DateTime finalTime =
                    date.Date + slotTime.TimeOfDay;

                if (finalTime < DateTime.Now)
                {
                    throw new SlotAlreadyOverException(
                        "Slot already over.");
                }
            }

            // Same patient booking same doctor again on same date
            bool sameDoctorBooked =
            _repo.GetAll().Any(a =>
                a.Patient.PatientId == patient.PatientId
                &&
                a.Doctor.DoctorId == doctor.DoctorId
                &&
                a.ScheduledDate.Date == date.Date
                &&
                a.Status != AppointmentStatus.Cancelled);

            if (sameDoctorBooked)
            {
                throw new AppointmentConflictException(
                    "You already booked an appointment with this doctor today.");
            }


            // Same patient booking another appointment in same slot
            bool sameSlotBooked =
            _repo.GetAll().Any(a =>
                a.Patient.PatientId == patient.PatientId
                &&
                a.ScheduledDate.Date == date.Date
                &&
                a.TimeSlot == slot
                &&
                a.Status != AppointmentStatus.Cancelled);

            if (sameSlotBooked)
            {
                throw new AppointmentConflictException(
                    "You already have another appointment in this time slot.");
            }

            bool alreadyBooked =
                _repo.GetAll().Any(a =>
                    a.Doctor.DoctorId ==
                    doctor.DoctorId
                    &&
                    a.ScheduledDate.Date ==
                    date.Date
                    &&
                    a.TimeSlot == slot
                    &&
                    a.Status !=
                    AppointmentStatus.Cancelled);

            if (alreadyBooked)
            {
                throw new AppointmentConflictException(
                    "Slot already booked.");
            }

            Appointment appointment = new()
            {
                AppointmentId =
                    _repo.GetAll().Count + 1,

                Patient = patient,

                Doctor = doctor,

                ScheduledDate = date,

                TimeSlot = slot
            };



            _repo.Add(appointment);

            return appointment;
        }

        public void CancelAppointment(
            int appointmentId,
            string reason)
        {
            var appointment =
                _repo.GetById(appointmentId);

            if (appointment == null)
            {
                throw new AppointmentNotFoundException($"The appointment with id {appointmentId} not found");
            }

            if (appointment.Status == AppointmentStatus.Cancelled)
            {

                throw new AppointmentAlreadyCancelledException("This appointment was already cancelled.");
            }

            if (appointment.Status == AppointmentStatus.Completed)
            {
                throw new AppointmentAlreadyCompletedException("Completed appointments cannot be cancelled.");
            }

            if (appointment != null)
            {
                appointment.Cancel(reason);
            }
        }

        public Appointment GetAppointmentById(int id)
        {
            var appointment = _repo.GetById(id);

            if (appointment == null)
            {
                throw new AppointmentNotFoundException(
                    $"Appointment with id {id} not found");
            }

            return appointment;
        }

        public List<Appointment> GetAllAppointments()
        {
            var list = _repo.GetAll();

            if (list == null || list.Count == 0)
            {
                throw new NoAppointmentsFoundException("No appointments found");
            }

            return list;
        }

        public List<Appointment>
  GetAppointmentsByPatient(
      int patientId)
        {
            var result = _repo.GetAll()
                .Where(a =>
                    a.Patient.PatientId == patientId
                    &&
                    (a.Status == AppointmentStatus.Confirmed || a.Status == AppointmentStatus.Pending || a.Status == AppointmentStatus.Cancelled)
                    &&
                    a.ScheduledDate.Date >= DateTime.Today
                )
                .OrderBy(a => a.ScheduledDate)
                .ThenBy(a => a.TimeSlot)
                .ToList();
            if (result.Count == 0)
            {
                throw new AppointmentNotFoundException($"No Appointments found for patient with id {patientId}");
            }

            return result;
        }
        public List<Appointment> GetUpcomingAppointmentsByDoctor(
    int doctorId,
    DateTime fromDate,
    DateTime toDate)
        {
            if (fromDate.Date < DateTime.Today)
            {
                throw new InvalidDateRangeException("From date cannot be in the past");
            }

            if (fromDate > toDate)
            {
                throw new InvalidDateRangeException("Invalid date range");
            }

            var result = _repo.GetAll()
                .Where(a =>
                    a.Doctor.DoctorId == doctorId
                    && a.Status == AppointmentStatus.Confirmed
                    && a.ScheduledDate.Date >= fromDate.Date
                    && a.ScheduledDate.Date <= toDate.Date
                    && a.ScheduledDate.Date >= DateTime.Today)
                .OrderBy(a => a.ScheduledDate)
                .ThenBy(a => a.TimeSlot)
                .ToList();

            if (result.Count == 0)
            {
                throw new AppointmentNotFoundException(
                    $"No upcoming appointments found for doctor id {doctorId}");
            }

            return result;
        }

        public List<string> CheckDoctorAvailability(
    int doctorId,
    DateTime date)
        {
            // 1. Past date validation
            if (date.Date < DateTime.Today)
            {
                throw new PastDateException(
                    "The selected date is already over.");
            }

            // 2. Maximum 30 days validation
            if (date.Date > DateTime.Today.AddDays(30))
            {
                throw new InvalidDateRangeException(
                    "Appointments can only be checked within 30 days from today.");
            }

            // Get all booked slots for the doctor
            var bookedSlots =
                _repo.GetAll()
                .Where(a =>
                    a.Doctor.DoctorId == doctorId
                    &&
                    a.ScheduledDate.Date == date.Date
                    &&
                    a.Status != AppointmentStatus.Cancelled)
                .Select(a => a.TimeSlot)
                .ToList();


            var availableSlots =
                TimeSlots.Slots
                .Except(bookedSlots)
                .ToList();


            if (availableSlots.Count == 0)
            {
                throw new SlotAlreadyOverException(
                    "No available slots on this day.");
            }

            return availableSlots;
        }

        public List<Appointment>
    GetPendingAppointmentsByDoctor(int doctorId)
        {
            var result = _repo.GetAll()
                .Where(a =>
                    a.Doctor.DoctorId == doctorId
                    &&
                    a.Status == AppointmentStatus.Pending)
                .OrderBy(a => a.ScheduledDate)
                .ThenBy(a => a.TimeSlot)
                .ToList();
            if (result.Count == 0)
            {
                throw new AppointmentNotFoundException($"No existing appointments for doctor with id {doctorId}");
            }
            return result;
        }

        public void ConfirmAppointment(int appointmentId)
        {
            var appointment =
                _repo.GetById(appointmentId);

            if (appointment == null)
            {
                throw new AppointmentNotFoundException(
                    $"Appointment with id {appointmentId} not found");
            }

            if (appointment.Status ==
                AppointmentStatus.Cancelled)
            {
                throw new AppointmentAlreadyCancelledException(
                    "Cancelled appointment cannot be confirmed.");
            }
            if (appointment.Status == AppointmentStatus.Completed)
            {
                throw new AppointmentAlreadyCompletedException(
                    "The appointment is already completed");
            }
            if (appointment.Status == AppointmentStatus.Confirmed)
            {
                throw new AppointmentAlreadyConfirmedException("You have already confirmed this appointment");
            }

            appointment.Confirm();
        }
    }
}