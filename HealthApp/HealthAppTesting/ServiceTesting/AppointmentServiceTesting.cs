using System;
using System.Collections.Generic;
using HealthApp.Constant;
using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using Moq;
using Xunit;

namespace HealthApp.Tests
{
    public class AppointmentServiceTests
    {
        private readonly Mock<IAppointmentRepository> _repoMock;
        private readonly AppointmentService _service;

        public AppointmentServiceTests()
        {
            _repoMock = new Mock<IAppointmentRepository>();
            _service = new AppointmentService(_repoMock.Object);
        }

        private Patient GetPatient() =>
            new Patient { PatientId = 1, FullName = "Test Patient" };

        private Doctor GetDoctor(bool active = true) =>
            new Doctor { DoctorId = 1, FullName = "Dr Test", IsActive = active };





        // ✅ 1. SUCCESS CASE
        [Fact]
        public void BookAppointment_Should_Succeed_When_Valid()
        {
            _repoMock.Setup(r => r.GetAll()).Returns(new List<Appointment>());

            var result = _service.BookAppointment(
                GetPatient(),
                GetDoctor(),
                DateTime.Today.AddDays(1),
                TimeSlots.Slots[0]
            );

            Assert.NotNull(result);
            Assert.Equal(AppointmentStatus.Confirmed, result.Status);
        }





        // ✅ 2. Past Date
        [Fact]
        public void BookAppointment_Should_Throw_PastDateException()
        {
            Assert.Throws<PastDateException>(() =>
                _service.BookAppointment(
                    GetPatient(),
                    GetDoctor(),
                    DateTime.Today.AddDays(-1),
                    TimeSlots.Slots[0]
                ));
        }





        // ✅ 3. Doctor Inactive
        [Fact]
        public void BookAppointment_Should_Throw_DoctorUnavailableException()
        {
            Assert.Throws<DoctorUnavailableException>(() =>
                _service.BookAppointment(
                    GetPatient(),
                    GetDoctor(false),
                    DateTime.Today.AddDays(1),
                    TimeSlots.Slots[0]
                ));
        }





        // ✅ 4. Invalid Slot
        [Fact]
        public void BookAppointment_Should_Throw_InvalidSlotException()
        {
            Assert.Throws<Exception>(() =>
                _service.BookAppointment(
                    GetPatient(),
                    GetDoctor(),
                    DateTime.Today.AddDays(1),
                    "08:00 AM" // ✅ NOT in TimeSlots
                ));
        }


        // ✅ 6. Slot already booked
        [Fact]
        public void BookAppointment_Should_Throw_Conflict_When_Slot_Already_Booked()
        {
            var existing = new List<Appointment>
            {
                new Appointment
                {
                    AppointmentId = 1,
                    Patient = GetPatient(),
                    Doctor = GetDoctor(),
                    ScheduledDate = DateTime.Today.AddDays(1),
                    TimeSlot = TimeSlots.Slots[0]
                }
            };

            _repoMock.Setup(r => r.GetAll()).Returns(existing);

            Assert.Throws<AppointmentConflictException>(() =>
                _service.BookAppointment(
                    GetPatient(),
                    GetDoctor(),
                    DateTime.Today.AddDays(1),
                    TimeSlots.Slots[0]
                ));
        }








        // ✅ 7. Same patient same doctor same day
        [Fact]
        public void BookAppointment_Should_Throw_Conflict_For_Same_Doctor_Same_Day()
        {
            var existing = new List<Appointment>
            {
                new Appointment
                {
                    AppointmentId = 1,
                    Patient = GetPatient(),
                    Doctor = GetDoctor(),
                    ScheduledDate = DateTime.Today.AddDays(1),
                    TimeSlot = TimeSlots.Slots[1]
                }
            };

            _repoMock.Setup(r => r.GetAll()).Returns(existing);

            Assert.Throws<AppointmentConflictException>(() =>
                _service.BookAppointment(
                    GetPatient(),
                    GetDoctor(),
                    DateTime.Today.AddDays(1),
                    TimeSlots.Slots[2]
                ));
        }





        // ✅ 8. Cancel Success
        [Fact]
        public void CancelAppointment_Should_Succeed()
        {
            var appointment = new Appointment
            {
                AppointmentId = 1,
                Patient = GetPatient(),
                Doctor = GetDoctor()
            };

            _repoMock.Setup(r => r.GetById(1)).Returns(appointment);

            _service.CancelAppointment(1, "Reason");

            Assert.Equal(AppointmentStatus.Cancelled, appointment.Status);
        }





        // ✅ 9. Cancel Already Cancelled
        [Fact]
        public void CancelAppointment_Should_Throw_AlreadyCancelled()
        {
            var appointment = new Appointment
            {
                AppointmentId = 1,
                Patient = GetPatient(),
                Doctor = GetDoctor()
            };

            appointment.Cancel("Test");

            _repoMock.Setup(r => r.GetById(1)).Returns(appointment);

            Assert.Throws<AppointmentAlreadyCancelledException>(() =>
                _service.CancelAppointment(1, "Again"));
        }





        // ✅ 10. Cancel Completed
        [Fact]
        public void CancelAppointment_Should_Throw_AlreadyCompleted()
        {
            var appointment = new Appointment
            {
                AppointmentId = 1,
                Patient = GetPatient(),
                Doctor = GetDoctor()
            };

            appointment.Complete();

            _repoMock.Setup(r => r.GetById(1)).Returns(appointment);

            Assert.Throws<AppointmentAlreadyCompletedException>(() =>
                _service.CancelAppointment(1, "Cancel"));
        }





        // ✅ 11. Cancel Not Found
        [Fact]
        public void CancelAppointment_Should_Throw_NotFound()
        {
            _repoMock.Setup(r => r.GetById(1))
                     .Returns((Appointment)null);

            Assert.Throws<AppointmentNotFoundException>(() =>
                _service.CancelAppointment(1, "Cancel"));
        }
    }
}
