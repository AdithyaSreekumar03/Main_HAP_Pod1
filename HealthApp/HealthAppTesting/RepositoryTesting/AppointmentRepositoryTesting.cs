using System;
using System.Linq;
using HealthApp.Database;
using HealthApp.Model;
using HealthApp.Repository.Impl;
using Xunit;

namespace HealthAppTesting.RepositoryTesting
{
    public class AppointmentRepositoryTests
    {
        private readonly AppointmentDb _db;
        private readonly AppointmentRepository _repo;

        public AppointmentRepositoryTests()
        {
            // ✅ Arrange (setup)
            _db = new AppointmentDb();
            _repo = new AppointmentRepository(_db);
        }

        // ✅ TEST 1: Add Appointment
        [Fact]
        public void Add_Should_Add_Appointment()
        {
            // Arrange
            var appointment = new Appointment
            {
                AppointmentId = 1,
                Patient = new Patient { PatientId = 1, FullName = "Rishab" },
                Doctor = new Doctor { DoctorId = 1, FullName = "Dr. Smith" },
                ScheduledDate = DateTime.Today,
                TimeSlot = "09:00 AM"
            };

            // Act
            _repo.Add(appointment);

            // Assert
            Assert.Single(_db.Appointments);
            Assert.Equal(1, _db.Appointments[0].AppointmentId);
        }

        // ✅ TEST 2: GetAll Appointments
        [Fact]
        public void GetAll_Should_Return_All_Appointments()
        {
            // Arrange
            _repo.Add(new Appointment
            {
                AppointmentId = 1,
                Patient = new Patient { PatientId = 1 },
                Doctor = new Doctor { DoctorId = 1 },
                ScheduledDate = DateTime.Today,
                TimeSlot = "09:00 AM"
            });

            _repo.Add(new Appointment
            {
                AppointmentId = 2,
                Patient = new Patient { PatientId = 2 },
                Doctor = new Doctor { DoctorId = 2 },
                ScheduledDate = DateTime.Today,
                TimeSlot = "10:00 AM"
            });

            // Act
            var result = _repo.GetAll();

            // Assert
            Assert.Equal(2, result.Count);
        }

        // ✅ TEST 3: GetById Success
        [Fact]
        public void GetById_Should_Return_Appointment_When_Exists()
        {
            // Arrange
            var appointment = new Appointment
            {
                AppointmentId = 1,
                Patient = new Patient { PatientId = 1 },
                Doctor = new Doctor { DoctorId = 1 },
                ScheduledDate = DateTime.Today,
                TimeSlot = "09:00 AM"
            };

            _repo.Add(appointment);

            // Act
            var result = _repo.GetById(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.AppointmentId);
        }

        // ✅ TEST 4: GetById Not Found
        [Fact]
        public void GetById_Should_Return_Null_When_NotFound()
        {
            // Act
            var result = _repo.GetById(99);

            // Assert
            Assert.Null(result);
        }

        // ✅ TEST 5: Multiple Add Maintains Data
        [Fact]
        public void Add_Multiple_Appointments_Should_Work_Correctly()
        {
            // Arrange
            var appt1 = new Appointment
            {
                AppointmentId = 1,
                Patient = new Patient { PatientId = 1 },
                Doctor = new Doctor { DoctorId = 1 },
                ScheduledDate = DateTime.Today,
                TimeSlot = "09:00 AM"
            };

            var appt2 = new Appointment
            {
                AppointmentId = 2,
                Patient = new Patient { PatientId = 2 },
                Doctor = new Doctor { DoctorId = 2 },
                ScheduledDate = DateTime.Today,
                TimeSlot = "10:00 AM"
            };

            // Act
            _repo.Add(appt1);
            _repo.Add(appt2);

            // Assert
            Assert.Equal(2, _db.Appointments.Count);
            Assert.Equal("09:00 AM", _db.Appointments[0].TimeSlot);
            Assert.Equal("10:00 AM", _db.Appointments[1].TimeSlot);
        }
    }
}