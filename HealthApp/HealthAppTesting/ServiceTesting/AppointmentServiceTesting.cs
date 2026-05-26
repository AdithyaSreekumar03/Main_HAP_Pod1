using HealthApp.Constant;
using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace HealthApp.Tests
{
    public class AppointmentServiceTesting
    {
        private readonly Mock<IAppointmentRepository> _repo;
        private readonly AppointmentService _service;

        public AppointmentServiceTesting()
        {
            _repo = new Mock<IAppointmentRepository>();
            _service = new AppointmentService(_repo.Object);
        }

        // ✅ Helpers
        private Patient GetPatient() => new() { PatientId = 1 };

        private Doctor GetDoctor(bool active = true) =>
            new() { DoctorId = 1, IsActive = active };

        private Appointment GetAppointment()
        {
            return new Appointment
            {
                AppointmentId = 1,
                Patient = GetPatient(),
                Doctor = GetDoctor(),
                ScheduledDate = DateTime.Today.AddDays(1),
                TimeSlot = TimeSlots.Slots[0]
            };
        }

        // ✅ 1. SUCCESS BOOK
        [Fact]
        public void BookAppointment_ShouldWork()
        {
            _repo.Setup(r => r.GetAll()).Returns(new List<Appointment>());

            var result = _service.BookAppointment(
                GetPatient(),
                GetDoctor(),
                DateTime.Today.AddDays(1),
                TimeSlots.Slots[0]);

            Assert.NotNull(result);
        }

        // ✅ 2. PAST DATE
        [Fact]
        public void BookAppointment_ShouldThrowPastDate()
        {
            Assert.Throws<PastDateException>(() =>
                _service.BookAppointment(GetPatient(), GetDoctor(),
                    DateTime.Today.AddDays(-1),
                    TimeSlots.Slots[0]));
        }

        // ✅ 3. DOCTOR INACTIVE
        [Fact]
        public void BookAppointment_ShouldThrowDoctorUnavailable()
        {
            Assert.Throws<DoctorUnavailableException>(() =>
                _service.BookAppointment(GetPatient(), GetDoctor(false),
                    DateTime.Today.AddDays(1),
                    TimeSlots.Slots[0]));
        }

        // ✅ 4. INVALID SLOT
        [Fact]
        public void BookAppointment_ShouldThrowInvalidSlot()
        {
            Assert.Throws<InvalidSlotException>(() =>
                _service.BookAppointment(GetPatient(), GetDoctor(),
                    DateTime.Today.AddDays(1),
                    "INVALID"));
        }

        // ✅ 5. PATIENT DOUBLE BOOK
        [Fact]
        public void BookAppointment_ShouldThrowPatientConflict()
        {
            var appt = GetAppointment();

            _repo.Setup(r => r.GetAll()).Returns(new List<Appointment> { appt });

            Assert.Throws<AppointmentConflictException>(() =>
                _service.BookAppointment(GetPatient(), GetDoctor(),
                    appt.ScheduledDate,
                    appt.TimeSlot));
        }

        // ✅ 6. SLOT ALREADY BOOKED
        [Fact]
        public void BookAppointment_ShouldThrowSlotConflict()
        {
            var appt = GetAppointment();

            _repo.Setup(r => r.GetAll()).Returns(new List<Appointment> { appt });

            Assert.Throws<AppointmentConflictException>(() =>
                _service.BookAppointment(
                    new Patient { PatientId = 2 },
                    GetDoctor(),
                    appt.ScheduledDate,
                    appt.TimeSlot));
        }

        // ✅ 7. CANCEL SUCCESS
        [Fact]
        public void Cancel_ShouldWork()
        {
            var appt = GetAppointment();

            _repo.Setup(r => r.GetById(1)).Returns(appt);

            _service.CancelAppointment(1, "test");

            Assert.Equal(AppointmentStatus.Cancelled, appt.Status);
        }

        // ✅ 8. CANCEL NOT FOUND
        [Fact]
        public void Cancel_ShouldThrowNotFound()
        {
            _repo.Setup(r => r.GetById(1)).Returns((Appointment?)null);

            Assert.Throws<AppointmentNotFoundException>(() =>
                _service.CancelAppointment(1, "x"));
        }

        // ✅ 9. CANCEL ALREADY CANCELLED
        [Fact]
        public void Cancel_ShouldThrowAlreadyCancelled()
        {
            var appt = GetAppointment();
            appt.Cancel("x");

            _repo.Setup(r => r.GetById(1)).Returns(appt);

            Assert.Throws<AppointmentAlreadyCancelledException>(() =>
                _service.CancelAppointment(1, "x"));
        }

        // ✅ 10. CANCEL COMPLETED
        [Fact]
        public void Cancel_ShouldThrowCompleted()
        {
            var appt = GetAppointment();
            appt.Confirm();
            appt.Complete(); // ✅ adjust if method name differs

            _repo.Setup(r => r.GetById(1)).Returns(appt);

            Assert.Throws<AppointmentAlreadyCompletedException>(() =>
                _service.CancelAppointment(1, "x"));
        }

        // ✅ 11. GET BY PATIENT
        [Fact]
        public void GetAppointmentsByPatient_ShouldReturn()
        {
            var appt = GetAppointment();

            _repo.Setup(r => r.GetAll()).Returns(new List<Appointment> { appt });

            var result = _service.GetAppointmentsByPatient(1);

            Assert.Single(result);
        }

        // ✅ 12. UPCOMING SUCCESS
        [Fact]
        public void GetUpcomingAppointments_ShouldReturn()
        {
            var appt = GetAppointment();
            appt.Confirm();

            _repo.Setup(r => r.GetAll()).Returns(new List<Appointment> { appt });

            var result = _service.GetUpcomingAppointmentsByDoctor(
                1,
                DateTime.Today,
                DateTime.Today.AddDays(5));

            Assert.Single(result);
        }

        // ✅ 13. AVAILABILITY SUCCESS
        [Fact]
        public void CheckAvailability_ShouldReturnSlots()
        {
            _repo.Setup(r => r.GetAll()).Returns(new List<Appointment>());

            var result = _service.CheckDoctorAvailability(
                1,
                DateTime.Today.AddDays(1));

            Assert.NotEmpty(result);
        }

        // ✅ 14. CONFIRM SUCCESS
        [Fact]
        public void Confirm_ShouldWork()
        {
            var appt = GetAppointment();

            _repo.Setup(r => r.GetById(1)).Returns(appt);

            _service.ConfirmAppointment(1);

            Assert.Equal(AppointmentStatus.Confirmed, appt.Status);
        }
    }
}