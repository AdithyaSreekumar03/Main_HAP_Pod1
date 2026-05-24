using HealthApp.Constant;
using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Interface;
using System;
using System.Collections.Generic;
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

        //  BOOK APPOINTMENT 
        public Appointment BookAppointment(
            Patient patient,
            Doctor doctor,
            DateTime date,
            string slot)
        {
            // ✅ 1. Past date check
            if (date.Date < DateTime.Today)
            {
                throw new PastDateException("Cannot book past date.");
            }

            // ✅ 2. Doctor active check
            if (!doctor.IsActive)
            {
                throw new DoctorUnavailableException("Doctor unavailable.");
            }

            // ✅ 3. Slot validation
            if (!TimeSlots.Slots.Contains(slot))
            {
                throw new Exception("Invalid slot.");
            }

            // ✅ 4. Slot already over (today)
            if (date.Date == DateTime.Today)
            {
                DateTime slotTime = DateTime.Parse(slot);
                DateTime finalTime = date.Date + slotTime.TimeOfDay;

                if (finalTime < DateTime.Now)
                {
                    throw new SlotAlreadyOverException("Slot already over.");
                }
            }

            // ✅ IMPORTANT: Fetch once
            var allAppointments = _repo.GetAll();

            string normalizedSlot = slot.Trim().ToUpper();

            // ✅ 5. Same patient + same doctor on same day
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

            // ✅ ✅ ✅ 6. FIXED SLOT CONFLICT (MAIN LOGIC)
            bool slotAlreadyBooked = allAppointments.Any(a =>
                a.Doctor.DoctorId == doctor.DoctorId &&
                a.ScheduledDate.Date == date.Date &&
                a.TimeSlot.Trim().ToUpper() == normalizedSlot &&
                a.Status != AppointmentStatus.Cancelled
            );

            if (slotAlreadyBooked)
            {
                throw new AppointmentConflictException("Slot already booked.");
            }

            // ✅ 7. Create appointment
            Appointment appointment = new()
            {
                AppointmentId = allAppointments.Count + 1,
                Patient = patient,
                Doctor = doctor,
                ScheduledDate = date,
                TimeSlot = slot
            };

            // ✅ default = Pending
            _repo.Add(appointment);

            return appointment;
        }

        // ✅ CANCEL APPOINTMENT
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

        // ✅ GET BY ID
        public Appointment? GetAppointmentById(int id)
        {
            return _repo.GetById(id);
        }

        // ✅ GET ALL
        public List<Appointment> GetAllAppointments()
        {
            return _repo.GetAll();
        }

        // ✅ GET PATIENT APPOINTMENTS
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

        // ✅ UPCOMING APPOINTMENTS (CONFIRMED ONLY)
        public List<Appointment> GetUpcomingAppointmentsByDoctor(
            int doctorId,
            DateTime fromDate,
            DateTime toDate)
        {
            if (fromDate.Date < DateTime.Today || toDate.Date < DateTime.Today)
            {
                throw new Exception("Date cannot be past.");
            }

            if (fromDate.Date > toDate.Date)
            {
                throw new Exception("From date cannot be greater than To date.");
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

        // ✅ PENDING APPOINTMENTS
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

        // ✅ DOCTOR AVAILABILITY
        public List<string> CheckDoctorAvailability(int doctorId, DateTime date)
        {
            if (date.Date < DateTime.Today)
            {
                throw new Exception("Past date not allowed.");
            }

            if (date.Date > DateTime.Today.AddDays(30))
            {
                throw new Exception("Check only within 30 days.");
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

            if (!availableSlots.Any())
            {
                throw new Exception("No slots available.");
            }

            return availableSlots;
        }

        // ✅ CONFIRM APPOINTMENT
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
                throw new Exception("Cancelled appointment cannot be confirmed.");
            }

            appointment.Confirm();
        }
    }
}