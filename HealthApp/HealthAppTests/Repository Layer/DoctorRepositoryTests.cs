using HealthApp.Databases;
using HealthApp.Models;
using HealthApp.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAppTests.Repository_Layer
{
    public class DoctorRepositoryTests
    {
        private readonly DoctorDb _db;
        private readonly DoctorRepository _repo;

        public DoctorRepositoryTests()
        {
            _db = new DoctorDb();
            _db.Doctors.Clear();
            _repo = new DoctorRepository(_db);
        }

        [Fact]
        public void Add_ShouldAddDoctor()
        {
            var doctor = new Doctor { DoctorId = 1 };

            _repo.Add(doctor);

            Assert.Single(_db.Doctors);
        }

        [Fact]
        public void GetAll_ShouldReturnDoctors()
        {
            _db.Doctors.Add(new Doctor());

            var result = _repo.GetAll();

            Assert.Single(result);
        }

        [Fact]
        public void GetAll_ShouldReturnEmpty_WhenNoDoctors()
        {
            var result = _repo.GetAll();

            Assert.Empty(result);
        }

        [Fact]
        public void GetById_ShouldReturnDoctor()
        {
            var doctor = new Doctor { DoctorId = 1 };
            _db.Doctors.Add(doctor);

            var result = _repo.GetById(1);

            Assert.NotNull(result);
            Assert.Equal(1, result.DoctorId);
        }

        [Fact]
        public void GetById_ShouldReturnNull_WhenNotFound()
        {
            var result = _repo.GetById(999);

            Assert.Null(result);
        }

        [Fact]
        public void ChangeDoctorStatus_ShouldUpdateStatus()
        {
            var doctor = new Doctor
            {
                DoctorId = 1,
                IsActive = true
            };

            _db.Doctors.Add(doctor);

            var result = _repo.ChangeDoctorStatus(1, false);

            Assert.NotNull(result);
            Assert.False(result.IsActive);

            Assert.False(_db.Doctors[0].IsActive);
        }
        [Fact]
        public void ChangeDoctorStatus_ShouldReturnNull_WhenNotFound()
        {
            var result = _repo.ChangeDoctorStatus(999, true);

            Assert.Null(result);
        }
    }
}
