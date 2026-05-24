using HealthApp.Constant;
using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Service.Impl
{
    public class AppointmentService : IAppointmentService
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
                throw new Exception(
                    "Invalid slot.");
            }

            if (date.Date == DateTime.Today)
            {
                DateTime slotTime =
                    DateTime.Parse(slot);

                DateTime finalTime =
                    date.Date + slotTime.TimeOfDay;

                if (finalTime < DateTime.Now)
                {
                    throw new SlotAlreadyOverException(
                        "Slot already over.");
                }
            }

            bool patientAlreadyBooked =
                _repo.GetAll().Any(a =>
                   a.Patient.PatientId == patient.PatientId
                   &&
                   a.Doctor.DoctorId == doctor.DoctorId
                   &&
                   a.ScheduledDate.Date == date.Date
                   &&
                   a.Status != AppointmentStatus.Cancelled);

            if (patientAlreadyBooked)
            {
                throw new AppointmentConflictException(
                    "You already booked an appointment with this doctor today. Cancel the existing appointment to book another slot.");
            }

            bool alreadyBooked =
                _repo.GetAll().Any(a =>
                    a.Doctor.DoctorId == doctor.DoctorId
                    &&
                    a.ScheduledDate.Date == date.Date
                    &&
                    a.TimeSlot == slot
                    &&
                    a.Status != AppointmentStatus.Cancelled);

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

                throw new AppointmentAlreadyCancelledException("Completed appointments cannot be cancelled.");
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

        public Appointment? GetAppointmentById(
            int id)
        {
            return _repo.GetById(id);
        }

        public List<Appointment>
            GetAllAppointments()
        {
            return _repo.GetAll();
        }


        public List<Appointment>
  GetAppointmentsByPatient(
      int patientId)
        {
            return _repo.GetAll()
                .Where(a =>
                    a.Patient.PatientId == patientId
                    &&
                    (a.Status == AppointmentStatus.Confirmed || a.Status == AppointmentStatus.Pending)
                    &&
                    a.ScheduledDate.Date >= DateTime.Today
                )
                .OrderBy(a => a.ScheduledDate)
                .ThenBy(a => a.TimeSlot)
                .ToList();
        }
        public List<Appointment> GetUpcomingAppointmentsByDoctor(int doctorId, DateTime fromDate, DateTime toDate)
        {
            if (fromDate.Date < DateTime.Today || toDate.Date < DateTime.Today)
            {
                throw new Exception(
                    "The Date you have entered is a Past Date");
            }

            // Validation
            if (fromDate.Date > toDate.Date)
            {
                throw new Exception(
                    "From Date cannot be greater than To Date.");
            }

            return _repo.GetAll()
                .Where(a =>
                    a.Doctor.DoctorId == doctorId
                    &&
                    a.Status == AppointmentStatus.Confirmed
                    &&
                    a.ScheduledDate.Date >= fromDate.Date
                    &&
                    a.ScheduledDate.Date <= toDate.Date
                    &&
                    a.ScheduledDate.Date >= DateTime.Today
                )
                .OrderBy(a => a.ScheduledDate)
                .ThenBy(a => a.TimeSlot)
                .ToList();
        }

        public List<string> CheckDoctorAvailability(int doctorId, DateTime date)
        {
            // 1. Past date validation
            if (date.Date < DateTime.Today)
            {
                throw new Exception(
                    "The selected date is already over.");
            }

            // 2. Maximum 30 days validation
            if (date.Date > DateTime.Today.AddDays(30))
            {
                throw new Exception(
                    "Appointments can only be checked within 30 days from today.");
            }

            // Get all booked slots for the doctor
            var bookedSlots =
                _repo.GetAll()
                .Where(a => a.Doctor.DoctorId == doctorId && a.ScheduledDate.Date == date.Date && a.Status != AppointmentStatus.Cancelled)
                .Select(a => a.TimeSlot)
                .ToList();

            // Get remaining available slots
            var availableSlots = TimeSlots.Slots
                                    .Except(bookedSlots)
                                    .ToList();

            // 3. All slots booked
            if (!availableSlots.Any())
            {
                throw new Exception("No available slots on this day.");
            }

            return availableSlots;
        }

        public List<Appointment> GetPendingAppointmentsByDoctor(int doctorId)
        {
            return _repo.GetAll()
                        .Where(a => a.Doctor.DoctorId == doctorId && a.Status == AppointmentStatus.Pending)
                        .OrderBy(a => a.ScheduledDate)
                        .ThenBy(a => a.TimeSlot)
                        .ToList();
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
                throw new Exception(
                    "Cancelled appointment cannot be confirmed.");
            }
            appointment.Confirm();
        }
    }
}