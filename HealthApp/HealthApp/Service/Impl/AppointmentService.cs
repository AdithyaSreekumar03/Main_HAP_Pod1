using HealthApp.Models;
using HealthApp.Repository.Interface;
using HealthApp.Service.Interface;
using System;
using System.Collections.Generic;
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
                throw new Exception(
                    "Invalid slot.");
            }

            // prevent expired slot booking

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

            appointment.Confirm();

            _repo.Add(appointment);

            return appointment;
        }

        public void CancelAppointment(
            int appointmentId,
            string reason)
        {
            var appointment =
                _repo.GetById(appointmentId);

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
                    a.Patient.PatientId ==
                    patientId)
                .ToList();
        }
        public List<Appointment> GetAppointmentsByDoctor(int doctorId)
        {
            return _repo.GetAll().Where(a => a.Doctor.DoctorId == doctorId).ToList();
        }
    }
}
