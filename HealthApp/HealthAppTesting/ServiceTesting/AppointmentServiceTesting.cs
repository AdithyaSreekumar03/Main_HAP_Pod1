using HealthApp.Constant;
using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace HealthApp.Tests
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

        private Patient GetPatient() => new Patient { PatientId = 1 };

        private static Doctor GetDoctor(bool isActive = true) =>
            new Doctor { DoctorId = 1, IsActive = isActive };

        // ✅ 1. Past Date
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

        // ✅ 2. Doctor unavailable
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

        // ✅ 3. Invalid slot
        [Fact]
        public void Book_ShouldThrowInvalidSlotException()
        {
            Assert.Throws<Exception>(() =>
                _service.BookAppointment(
                    GetPatient(),
                    GetDoctor(),
                    DateTime.Today.AddDays(1),
                    "INVALID"));
        }

        // ✅ 4. Patient conflict
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
            existing.Confirm();

            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Appointment> { existing });

            Assert.Throws<AppointmentConflictException>(() =>
                _service.BookAppointment(
                    patient,
                    doctor,
                    DateTime.Today.AddDays(1),
                    "10:00 AM"));
        }

        // ✅ 5. Slot conflict
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
            existing.Confirm();

            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Appointment> { existing });

            Assert.Throws<AppointmentConflictException>(() =>
                _service.BookAppointment(
                    GetPatient(),
                    doctor,
                    DateTime.Today.AddDays(1),
                    "10:00 AM"));
        }

        // ✅ 6. SUCCESS BOOKING
        [Fact]
        public void Book_ShouldCreateValidAppointment()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Appointment>());

            var patient = GetPatient();
            var doctor = GetDoctor();

            var result = _service.BookAppointment(
                patient,
                doctor,
                DateTime.Today.AddDays(1),
                TimeSlots.Slots.First());

            Assert.NotNull(result);
            Assert.Equal(patient, result.Patient);
            Assert.Equal(doctor, result.Doctor);
            Assert.Equal(AppointmentStatus.Pending, result.Status);
        }

        // ✅ 7. CANCEL - Not found
        [Fact]
        public void Cancel_ShouldThrowNotFoundException()
        {
            _mockRepo.Setup(r => r.GetById(It.IsAny<int>()))
                     .Returns((Appointment?)null);

            Assert.Throws<AppointmentNotFoundException>(() =>
                _service.CancelAppointment(1, "Reason"));
        }

        // ✅ 8. CANCEL - Already cancelled
        [Fact]
        public void Cancel_ShouldThrowAlreadyCancelledException()
        {
            var app = new Appointment();
            app.Cancel("test");

            _mockRepo.Setup(r => r.GetById(It.IsAny<int>()))
                     .Returns(app);

            Assert.Throws<AppointmentAlreadyCancelledException>(() =>
                _service.CancelAppointment(1, "Reason"));
        }

        // ✅ 9. CANCEL - Completed
        [Fact]
        public void Cancel_ShouldThrowCompletedException()
        {
            var app = new Appointment();
            app.Complete();

            _mockRepo.Setup(r => r.GetById(It.IsAny<int>()))
                     .Returns(app);

            Assert.Throws<AppointmentAlreadyCompletedException>(() =>
                _service.CancelAppointment(1, "Reason"));
        }

        // ✅ 10. CANCEL SUCCESS
        [Fact]
        public void Cancel_ShouldSucceed()
        {
            var app = new Appointment();

            _mockRepo.Setup(r => r.GetById(It.IsAny<int>()))
                     .Returns(app);

            _service.CancelAppointment(1, "Test");

            Assert.Equal(AppointmentStatus.Cancelled, app.Status);
        }

        // ✅ 11. CONFIRM - Not found
        [Fact]
        public void Confirm_ShouldThrowNotFoundException()
        {
            _mockRepo.Setup(r => r.GetById(It.IsAny<int>()))
                     .Returns((Appointment?)null);

            Assert.Throws<AppointmentNotFoundException>(() =>
                _service.ConfirmAppointment(1));
        }

        // ✅ 12. CONFIRM - already cancelled
        [Fact]
        public void Confirm_ShouldThrowException_WhenCancelled()
        {
            var app = new Appointment();
            app.Cancel("test");

            _mockRepo.Setup(r => r.GetById(It.IsAny<int>()))
                     .Returns(app);

            Assert.Throws<Exception>(() =>
                _service.ConfirmAppointment(1));
        }

        // ✅ 13. CONFIRM SUCCESS
        [Fact]
        public void Confirm_ShouldSucceed()
        {
            var app = new Appointment();

            _mockRepo.Setup(r => r.GetById(It.IsAny<int>()))
                     .Returns(app);

            _service.ConfirmAppointment(1);

            Assert.Equal(AppointmentStatus.Confirmed, app.Status);
        }

        // ✅ 14. GetAll
        [Fact]
        public void GetAllAppointments_ShouldReturnList()
        {
            var list = new List<Appointment> { new Appointment() };

            _mockRepo.Setup(r => r.GetAll()).Returns(list);

            var result = _service.GetAllAppointments();

            Assert.Single(result);
        }

        // ✅ 15. GetById
        [Fact]
        public void GetById_ShouldReturnAppointment()
        {
            var app = new Appointment();

            _mockRepo.Setup(r => r.GetById(1)).Returns(app);

            var result = _service.GetAppointmentById(1);

            Assert.NotNull(result);
        }

        // ✅ 16. GetAppointmentsByPatient
        [Fact]
        public void GetAppointmentsByPatient_ShouldFilterCorrectly()
        {
            var patient = GetPatient();

            var list = new List<Appointment>
            {
                new Appointment
                {
                    Patient = patient,
                    ScheduledDate = DateTime.Today.AddDays(1)
                }
            };

            _mockRepo.Setup(r => r.GetAll()).Returns(list);

            var result = _service.GetAppointmentsByPatient(1);

            Assert.Single(result);
        }

        // ✅ 17. Upcoming appointments success
        [Fact]
        public void GetUpcoming_ShouldReturnConfirmedAppointments()
        {
            var doctor = GetDoctor();

            var list = new List<Appointment>
            {
                new Appointment
                {
                    Doctor = doctor,
                    ScheduledDate = DateTime.Today.AddDays(1)
                }
            };
            list[0].Confirm();

            _mockRepo.Setup(r => r.GetAll()).Returns(list);

            var result = _service.GetUpcomingAppointmentsByDoctor(
                1, DateTime.Today, DateTime.Today.AddDays(10));

            Assert.Single(result);
        }

        // ✅ 18. invalid date range
        [Fact]
        public void GetUpcoming_ShouldThrowForInvalidRange()
        {
            Assert.Throws<Exception>(() =>
                _service.GetUpcomingAppointmentsByDoctor(
                    1,
                    DateTime.Today.AddDays(5),
                    DateTime.Today));
        }

        // ✅ 19. pending appointments
        [Fact]
        public void GetPending_ShouldReturnPendingOnly()
        {
            var doctor = GetDoctor();

            var list = new List<Appointment>
            {
                new Appointment
                {
                    Doctor = doctor
                }
            };

            _mockRepo.Setup(r => r.GetAll()).Returns(list);

            var result = _service.GetPendingAppointmentsByDoctor(1);

            Assert.Single(result);
        }

        // ✅ 20. availability success
        [Fact]
        public void Availability_ShouldReturnSlots()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Appointment>());

            var result = _service.CheckDoctorAvailability(
                1,
                DateTime.Today.AddDays(1));

            Assert.NotEmpty(result);
        }

        // ✅ 21. availability no slots
        [Fact]
        public void Availability_ShouldThrow_WhenNoSlots()
        {
            var doctor = GetDoctor();

            var full = TimeSlots.Slots.Select(s => new Appointment
            {
                Doctor = doctor,
                ScheduledDate = DateTime.Today.AddDays(1),
                TimeSlot = s
            }).ToList();

            _mockRepo.Setup(r => r.GetAll()).Returns(full);

            Assert.Throws<Exception>(() =>
                _service.CheckDoctorAvailability(
                    1,
                    DateTime.Today.AddDays(1)));
        }
    }
}
