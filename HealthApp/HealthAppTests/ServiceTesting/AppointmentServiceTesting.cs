using HealthApp.Constant;
using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace HealthAppTests.ServiceTesting
{
    public class AppointmentServiceTesting
    {
        private readonly Mock<IAppointmentRepository> _mockRepo;
        private readonly AppointmentService _service;

        public AppointmentServiceTesting()
        {
            _mockRepo = new Mock<IAppointmentRepository>();
            _service = new AppointmentService(_mockRepo.Object);
        }

        //   Helpers
        private Patient GetPatient() => new Patient { PatientId = 1 };

        private Doctor GetDoctor(bool isActive = true) =>
            new Doctor { DoctorId = 1, IsActive = isActive };

        //   1. Past Date
        [Fact]
        public void Book_ShouldThrowPastDateException()
        {
            Assert.Throws<PastDateException>(() =>
                _service.BookAppointment(
                    GetPatient(),
                    GetDoctor(),
                    DateTime.Now.AddDays(-1),
                    "10:00 AM"));
        }

        //   2. Doctor unavailable
        [Fact]
        public void Book_ShouldThrowDoctorUnavailableException()
        {
            Assert.Throws<DoctorUnavailableException>(() =>
                _service.BookAppointment(
                    GetPatient(),
                    GetDoctor(false),
                    DateTime.Today.AddDays(1),
                    "10:00 AM"));
        }

        //   3. Invalid slot
        [Fact]
        public void Book_ShouldThrowInvalidSlotException()
        {
            Assert.Throws<SlotAlreadyOverException>(() =>
                _service.BookAppointment(
                    GetPatient(),
                    GetDoctor(),
                    DateTime.Today.AddDays(1),
                    "INVALID"));
        }

        //   4. Patient already booked same doctor
        [Fact]
        public void Book_ShouldThrowPatientConflictException()
        {
            var patient = GetPatient();
            var doctor = GetDoctor();

            var existing = new Appointment
            {
                Patient = patient,
                Doctor = doctor,
                ScheduledDate = DateTime.Today.AddDays(1)
            };
            existing.Confirm(); //   IMPORTANT

            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Appointment> { existing });

            Assert.Throws<AppointmentConflictException>(() =>
                _service.BookAppointment(
                    patient,
                    doctor,
                    DateTime.Today.AddDays(1),
                    "10:00 AM"));
        }

        //   5. Slot already booked
        [Fact]
        public void Book_ShouldThrowSlotConflictException()
        {
            var doctor = GetDoctor();

            var existing = new Appointment
            {
                Patient = new Patient { PatientId = 2 },
                Doctor = doctor,
                ScheduledDate = DateTime.Today.AddDays(1),
                TimeSlot = "10:00 AM"
            };
            existing.Confirm(); //   FIX

            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Appointment> { existing });

            Assert.Throws<AppointmentConflictException>(() =>
                _service.BookAppointment(
                    GetPatient(),
                    doctor,
                    DateTime.Today.AddDays(1),
                    "10:00 AM"));
        }

        //   6. SUCCESS CASE
        [Fact]
        public void Book_ShouldSucceed()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Appointment>());

            var result = _service.BookAppointment(
                GetPatient(),
                GetDoctor(),
                DateTime.Today.AddDays(1),
                TimeSlot.Slots[0]);

            Assert.NotNull(result);
        }

        //   CANCEL

        // 7. Not found
        [Fact]
        public void Cancel_ShouldThrowNotFoundException()
        {
            _mockRepo.Setup(r => r.GetById(It.IsAny<int>()))
                     .Returns((Appointment?)null);

            Assert.Throws<AppointmentNotFoundException>(() =>
                _service.CancelAppointment(1, "Reason"));
        }

        // 8. Already cancelled
        [Fact]
        public void Cancel_ShouldThrowAlreadyCancelledException()
        {
            var app = new Appointment();
            app.Cancel("test"); //   FIX

            _mockRepo.Setup(r => r.GetById(It.IsAny<int>()))
                     .Returns(app);

            Assert.Throws<AppointmentAlreadyCancelledException>(() =>
                _service.CancelAppointment(1, "Reason"));
        }

        // 9. Completed
        [Fact]
        public void Cancel_ShouldThrowCompletedException()
        {
            var app = new Appointment();
            app.Complete(); //   FIX

            _mockRepo.Setup(r => r.GetById(It.IsAny<int>()))
                     .Returns(app);

            Assert.Throws<AppointmentAlreadyCompletedException>(() =>
                _service.CancelAppointment(1, "Reason"));
        }

        //   CONFIRM

        // 10. Not found
        [Fact]
        public void Confirm_ShouldThrowNotFoundException()
        {
            _mockRepo.Setup(r => r.GetById(It.IsAny<int>()))
                     .Returns((Appointment?)null);

            Assert.Throws<AppointmentNotFoundException>(() =>
                _service.ConfirmAppointment(1));
        }

        // 11. Already cancelled
        [Fact]
        public void Confirm_ShouldThrowException_WhenCancelled()
        {
            var app = new Appointment();
            app.Cancel("test"); //   FIX

            _mockRepo.Setup(r => r.GetById(It.IsAny<int>()))
                     .Returns(app);

            Assert.Throws<AppointmentAlreadyCancelledException>(() =>
                _service.ConfirmAppointment(1));
        }

        //   CHECK AVAILABILITY

        // 12. Past date
        [Fact]
        public void Availability_ShouldThrowForPastDate()
        {
            Assert.Throws<PastDateException>(() =>
                _service.CheckDoctorAvailability(1, DateTime.Today.AddDays(-1)));
        }

        // 13. Beyond 30 days
        [Fact]
        public void Availability_ShouldThrowForFutureLimit()
        {
            Assert.Throws<InvalidDateRangeException>(() =>
                _service.CheckDoctorAvailability(1, DateTime.Today.AddDays(31)));
        }
    }
}