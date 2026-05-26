using HealthApp.Constant;
using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Impl;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAppTests.Service_Layer
{
    public class AppointmentServiceTests
    {
        private readonly Mock<IAppointmentRepository> _repo;
        private readonly AppointmentService _service;

        public AppointmentServiceTests()
        {
            _repo = new Mock<IAppointmentRepository>();
            _service = new AppointmentService(_repo.Object);
        }

        private static Patient GetPatient() => new() { PatientId = 1 };

        private static Doctor GetDoctor(bool active = true) =>
            new() { DoctorId = 1, IsActive = active };

        private static Appointment GetAppointment()
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

        [Fact]
        public void BookAppointment_ShouldWork()
        {
            _repo.Setup(r => r.GetAll()).Returns(new List<Appointment>());

            var result = _service.BookAppointment(
                GetPatient(),
                GetDoctor(),
                DateTime.Today.AddDays(1),
                TimeSlots.Slots[0]
            );

            Assert.NotNull(result);
        }

        [Fact]
        public void BookAppointment_ShouldThrowPastDate()
        {
            Assert.Throws<PastDateException>(() =>
                _service.BookAppointment(
                    GetPatient(),
                    GetDoctor(),
                    DateTime.Today.AddDays(-1),
                    TimeSlots.Slots[0]));
        }

        [Fact]
        public void BookAppointment_ShouldThrowDoctorUnavailable()
        {
            Assert.Throws<DoctorUnavailableException>(() =>
                _service.BookAppointment(
                    GetPatient(),
                    GetDoctor(false),
                    DateTime.Today.AddDays(1),
                    TimeSlots.Slots[0]));
        }

        [Fact]
        public void BookAppointment_ShouldThrowInvalidSlot()
        {
            Assert.Throws<InvalidSlotException>(() =>
                _service.BookAppointment(
                    GetPatient(),
                    GetDoctor(),
                    DateTime.Today.AddDays(1),
                    "INVALID"));
        }

        [Fact]
        public void BookAppointment_ShouldThrowPatientConflict()
        {
            var appt = GetAppointment();

            _repo.Setup(r => r.GetAll()).Returns(new List<Appointment> { appt });

            Assert.Throws<AppointmentConflictException>(() =>
                _service.BookAppointment(
                    GetPatient(),
                    GetDoctor(),
                    appt.ScheduledDate,
                    appt.TimeSlot));
        }


        [Fact]
        public void BookAppointment_ShouldThrow_WhenSameSlotBookedByPatient()
        {
            var patient = GetPatient();
            var doctor = GetDoctor();

            var existingAppointment = new Appointment
            {
                AppointmentId = 1,
                Patient = patient,
                Doctor = doctor,
                ScheduledDate = DateTime.Today.AddDays(1),
                TimeSlot = TimeSlots.Slots[0],
            };

            _repo.Setup(r => r.GetAll())
                 .Returns(new List<Appointment> { existingAppointment });

            Assert.Throws<AppointmentConflictException>(() =>
                _service.BookAppointment(
                    patient,
                    doctor,
                    existingAppointment.ScheduledDate,
                    existingAppointment.TimeSlot));
        }


        [Fact]
        public void BookAppointment_ShouldThrowSlotConflict()
        {
            var appt = GetAppointment();

            _repo.Setup(r => r.GetAll()).Returns(new List<Appointment> { appt });

            Assert.Throws<AppointmentConflictException>(() =>
                _service.BookAppointment(
                    new Patient { PatientId = 2 }, // different patient
                    GetDoctor(),
                    appt.ScheduledDate,
                    appt.TimeSlot));
        }

        [Fact]
        public void Cancel_ShouldWork()
        {
            var appt = GetAppointment();

            _repo.Setup(r => r.GetById(1)).Returns(appt);

            _service.CancelAppointment(1, "test");

            Assert.Equal(AppointmentStatus.Cancelled, appt.Status);
        }

        [Fact]
        public void Cancel_ShouldThrowNotFound()
        {
            _repo.Setup(r => r.GetById(1)).Returns((Appointment?)null);

            Assert.Throws<AppointmentNotFoundException>(() =>
                _service.CancelAppointment(1, "x"));
        }

        [Fact]
        public void Cancel_ShouldThrowAlreadyCancelled()
        {
            var appt = GetAppointment();
            appt.Cancel("x");

            _repo.Setup(r => r.GetById(1)).Returns(appt);

            Assert.Throws<AppointmentAlreadyCancelledException>(() =>
                _service.CancelAppointment(1, "x"));
        }

        [Fact]
        public void Cancel_ShouldThrowCompleted()
        {
            var appt = GetAppointment();
            appt.Complete();

            _repo.Setup(r => r.GetById(1)).Returns(appt);

            Assert.Throws<AppointmentAlreadyCompletedException>(() =>
                _service.CancelAppointment(1, "x"));
        }

        [Fact]
        public void GetAppointmentsByPatient_ShouldReturn()
        {
            var appt = GetAppointment();

            _repo.Setup(r => r.GetAll()).Returns(new List<Appointment> { appt });

            var result = _service.GetAppointmentsByPatient(1);

            Assert.Single(result);
        }


        [Fact]
        public void GetUpcomingAppointments_ShouldThrowPastDate()
        {
            Assert.Throws<InvalidDateRangeException>(() =>
                _service.GetUpcomingAppointmentsByDoctor(
                    1,
                    DateTime.Today.AddDays(-1),
                    DateTime.Today));
        }

        [Fact]
        public void GetUpcomingAppointments_ShouldThrowInvalidRange()
        {
            Assert.Throws<InvalidDateRangeException>(() =>
                _service.GetUpcomingAppointmentsByDoctor(
                    1,
                    DateTime.Today.AddDays(5),
                    DateTime.Today));
        }


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

        [Fact]
        public void GetPendingAppointments_ShouldReturn()
        {
            var appt = GetAppointment();

            _repo.Setup(r => r.GetAll()).Returns(new List<Appointment> { appt });

            var result = _service.GetPendingAppointmentsByDoctor(1);

            Assert.Single(result);
        }

        [Fact]
        public void CheckAvailability_ShouldReturnSlots()
        {
            _repo.Setup(r => r.GetAll()).Returns(new List<Appointment>());

            var result = _service.CheckDoctorAvailability(
                1,
                DateTime.Today.AddDays(1));

            Assert.NotEmpty(result);
        }

        [Fact]
        public void CheckAvailability_ShouldThrowPastDate()
        {
            Assert.Throws<PastDateException>(() =>
                _service.CheckDoctorAvailability(1, DateTime.Today.AddDays(-1)));
        }


        [Fact]
        public void CheckAvailability_ShouldThrowRange()
        {
            Assert.Throws<InvalidDateRangeException>(() =>
                _service.CheckDoctorAvailability(1, DateTime.Today.AddDays(40)));
        }

        [Fact]
        public void Confirm_ShouldWork()
        {
            var appt = GetAppointment();

            _repo.Setup(r => r.GetById(1)).Returns(appt);

            _service.ConfirmAppointment(1);

            Assert.Equal(AppointmentStatus.Confirmed, appt.Status);
        }


        [Fact]
        public void GetAppointmentById_ShouldReturnAppointment_WhenFound()
        {
            var appointment = new Appointment { AppointmentId = 1 };

            _repo.Setup(r => r.GetById(1))
                     .Returns(appointment);

            var result = _service.GetAppointmentById(1);

            Assert.NotNull(result);
            Assert.Equal(1, result.AppointmentId);
        }

        [Fact]
        public void GetAppointmentById_ShouldThrowException_WhenNotFound()
        {
            _repo.Setup(r => r.GetById(1))
                     .Returns((Appointment?)null);

            Assert.Throws<AppointmentNotFoundException>(() =>
                _service.GetAppointmentById(1));
        }

        [Fact]
        public void GetAllAppointments_ShouldReturnAppointments()
        {
            var list = new List<Appointment>
        {
            new Appointment { AppointmentId = 1 },
            new Appointment { AppointmentId = 2 }
        };

            _repo.Setup(r => r.GetAll())
                     .Returns(list);

            var result = _service.GetAllAppointments();

            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void GetAllAppointments_ShouldThrowException_WhenNull()
        {
            _repo.Setup(r => r.GetAll())
                    .Returns((List<Appointment>)null!);


            Assert.Throws<NoAppointmentsFoundException>(() =>
                _service.GetAllAppointments());
        }

        [Fact]
        public void GetAllAppointments_ShouldThrowException_WhenEmpty()
        {
            // Arrange
            _repo.Setup(r => r.GetAll())
                     .Returns(new List<Appointment>());
            Assert.Throws<NoAppointmentsFoundException>(() =>
                _service.GetAllAppointments());
        }
        [Fact]
        public void CheckDoctorAvailability_ShouldThrowSlotAlreadyOverException()
        {
            var doctorId = 1;
            var date = DateTime.Today.AddDays(1);
            var appointments = TimeSlots.Slots.Select(slot => new Appointment
            {
                Doctor = new Doctor { DoctorId = doctorId },
                ScheduledDate = date,
                TimeSlot = slot,
            }).ToList();
            foreach (Appointment appointment in appointments)
                appointment.Confirm();

            _repo.Setup(r => r.GetAll()).Returns(appointments);

            Assert.Throws<SlotAlreadyOverException>(() =>
                _service.CheckDoctorAvailability(doctorId, date));
        }
        [Fact]
        public void GetPendingAppointments_ShouldThrow_WhenNoAppointments()
        {
            _repo.Setup(r => r.GetAll())
                 .Returns(new List<Appointment>());

            Assert.Throws<AppointmentNotFoundException>(() =>
                _service.GetPendingAppointmentsByDoctor(1));
        }
        [Fact]
        public void ConfirmAppointment_ShouldThrowAlreadyCancelled()
        {
            var appt = new Appointment
            {
                AppointmentId = 1
            };
            appt.Cancel("test");

            _repo.Setup(r => r.GetById(1)).Returns(appt);

            Assert.Throws<AppointmentAlreadyCancelledException>(() =>
                _service.ConfirmAppointment(1));
        }
        [Fact]
        public void ConfirmAppointment_ShouldThrowAlreadyCompleted()
        {
            var appt = new Appointment
            {
                AppointmentId = 1
            };
            appt.Complete();

            _repo.Setup(r => r.GetById(1)).Returns(appt);

            Assert.Throws<AppointmentAlreadyCompletedException>(() =>
                _service.ConfirmAppointment(1));
        }
    }
}