using HealthApp.Constant;
using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace HealthApp.Service.Impl
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _repo;

        public AppointmentService(IAppointmentRepository repo)
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
                throw new PastDateException("Cannot book past date.");
            }

            if (!doctor.IsActive)
            {
                throw new DoctorUnavailableException("Doctor unavailable.");
            }

            if (!TimeSlots.Slots.Contains(slot))
            {
                throw new InvalidSlotException("Invalid slot.");
            }

            // ✅ FIXED: culture-safe parsing
            if (date.Date == DateTime.Today)
            {
                DateTime slotTime = DateTime.ParseExact(
                    slot,
                    "hh:mm tt",
                    CultureInfo.InvariantCulture
                );

                DateTime finalTime = date.Date + slotTime.TimeOfDay;

                if (finalTime < DateTime.Now)
                {
                    throw new SlotAlreadyOverException("Slot already over.");
                }
            }

            var allAppointments = _repo.GetAll();

            string normalizedSlot = slot.Trim().ToUpper();

            bool patientAlreadyBooked = allAppointments.Any(a =>
                a.Patient.PatientId == patient.PatientId &&
                a.Doctor.DoctorId == doctor.DoctorId &&
                a.ScheduledDate.Date == date.Date &&
                a.Status != AppointmentStatus.Cancelled);

            if (patientAlreadyBooked)
            {
                throw new AppointmentConflictException(
                    "You already booked an appointment with this doctor on this day.");
            }

            bool slotAlreadyBooked = allAppointments.Any(a =>
                a.Doctor.DoctorId == doctor.DoctorId &&
                a.ScheduledDate.Date == date.Date &&

            string.Equals(
                 a.TimeSlot.Trim(),
                 normalizedSlot,
                    StringComparison.OrdinalIgnoreCase) &&
                a.Status != AppointmentStatus.Cancelled
            );

            if (slotAlreadyBooked)
            {
                throw new AppointmentConflictException("Slot already booked.");
            }

            Appointment appointment = new()
            {
                AppointmentId = allAppointments.Count + 1,
                Patient = patient,
                Doctor = doctor,
                ScheduledDate = date,
                TimeSlot = slot
            };

            _repo.Add(appointment);

            return appointment;
        }

        public void CancelAppointment(int appointmentId, string reason)
        {
            var appointment = _repo.GetById(appointmentId);

            if (appointment == null)
            {
                throw new AppointmentNotFoundException(
                    $"Appointment with id {appointmentId} not found");
            }

            if (appointment.Status == AppointmentStatus.Cancelled)
            {
                throw new AppointmentAlreadyCancelledException(
                    "Appointment already cancelled.");
            }

            if (appointment.Status == AppointmentStatus.Completed)
            {
                throw new AppointmentAlreadyCompletedException(
                    "Completed appointment cannot be cancelled.");
            }

            appointment.Cancel(reason);
        }

        public Appointment? GetAppointmentById(int id)
        {
            return _repo.GetById(id);
        }

        public List<Appointment> GetAllAppointments()
        {
            return _repo.GetAll();
        }

        public List<Appointment> GetAppointmentsByPatient(int patientId)
        {
            return _repo.GetAll()
                .Where(a =>
                    a.Patient.PatientId == patientId &&
                    (a.Status == AppointmentStatus.Pending ||
                     a.Status == AppointmentStatus.Confirmed) &&
                    a.ScheduledDate.Date >= DateTime.Today)
                .OrderBy(a => a.ScheduledDate)
                .ThenBy(a => a.TimeSlot)
                .ToList();
        }

        public List<Appointment> GetUpcomingAppointmentsByDoctor(
            int doctorId,
            DateTime fromDate,
            DateTime toDate)
        {

            if (fromDate.Date < DateTime.Today || toDate.Date < DateTime.Today)
            {
                throw new InvalidDateRangeException("Date cannot be past.");
            }

            if (fromDate.Date > toDate.Date)
            {
                throw new InvalidDateRangeException("From date cannot be greater than To date.");
            }


            return _repo.GetAll()
                .Where(a =>
                    a.Doctor.DoctorId == doctorId &&
                    a.Status == AppointmentStatus.Confirmed &&
                    a.ScheduledDate.Date >= fromDate.Date &&
                    a.ScheduledDate.Date <= toDate.Date)
                .OrderBy(a => a.ScheduledDate)
                .ThenBy(a => a.TimeSlot)
                .ToList();
        }

        public List<Appointment> GetPendingAppointmentsByDoctor(int doctorId)
        {
            return _repo.GetAll()
                .Where(a =>
                    a.Doctor.DoctorId == doctorId &&
                    a.Status == AppointmentStatus.Pending)
                .OrderBy(a => a.ScheduledDate)
                .ThenBy(a => a.TimeSlot)
                .ToList();
        }

        public List<string> CheckDoctorAvailability(int doctorId, DateTime date)
        {
            if (date.Date < DateTime.Today)
            {
                throw new PastDateException("Past date not allowed.");
            }

            if (date.Date > DateTime.Today.AddDays(30))
            {
                throw new InvalidDateRangeException("Check only within 30 days.");
            }

            var bookedSlots = _repo.GetAll()
                .Where(a =>
                    a.Doctor.DoctorId == doctorId &&
                    a.ScheduledDate.Date == date.Date &&
                    a.Status != AppointmentStatus.Cancelled)
                .Select(a => a.TimeSlot.ToUpper().Trim())
                .ToList();

            var availableSlots = TimeSlots.Slots
                .Where(s => !bookedSlots.Contains(s.ToUpper().Trim()))
                .ToList();


            if (availableSlots.Count == 0)
            {
                throw new SlotAlreadyOverException("No slots available.");
            }


            return availableSlots;
        }

        public void ConfirmAppointment(int appointmentId)
        {
            var appointment = _repo.GetById(appointmentId);

            if (appointment == null)
            {
                throw new AppointmentNotFoundException(
                    $"Appointment with id {appointmentId} not found");
            }

            if (appointment.Status == AppointmentStatus.Cancelled)
            {
                throw new AppointmentAlreadyCancelledException("Cancelled appointment cannot be confirmed.");
            }

            appointment.Confirm();
        }
    }
}
