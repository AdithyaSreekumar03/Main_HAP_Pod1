using HealthApp.Database;
using HealthApp.Model;
using HealthApp.Repository.Impl;
using System;
using Xunit;

namespace HealthApp.Tests
{
    public class AppointmentRepositoryTesting
    {
        private readonly AppointmentDb _db;
        private readonly AppointmentRepository _repo;

        public AppointmentRepositoryTesting()
        {
            _db = new AppointmentDb();
            _db.Appointments.Clear();   // important
            _repo = new AppointmentRepository(_db);
        }

        [Fact]
        public void Add_ShouldAddAppointment()
        {
            int before = _db.Appointments.Count;

            _repo.Add(new Appointment());

            Assert.Equal(before + 1, _db.Appointments.Count);
        }

        [Fact]
        public void Add_ShouldHandleMultipleAppointments()
        {
            _repo.Add(new Appointment());
            _repo.Add(new Appointment());

            Assert.Equal(2, _db.Appointments.Count);
        }

        [Fact]
        public void GetAll_ShouldReturnAllAppointments()
        {
            _db.Appointments.Add(new Appointment());
            _db.Appointments.Add(new Appointment());

            var result = _repo.GetAll();

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void GetAll_ShouldReturnEmptyList()
        {
            var result = _repo.GetAll();

            Assert.Empty(result);
        }

        [Fact]
        public void GetById_ShouldReturnAppointment()
        {
            var appointment = new Appointment { AppointmentId = 1 };
            _db.Appointments.Add(appointment);

            var result = _repo.GetById(1);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetById_ShouldReturnNull_WhenNotFound()
        {
            var result = _repo.GetById(999);

            Assert.Null(result);
        }
    }
}