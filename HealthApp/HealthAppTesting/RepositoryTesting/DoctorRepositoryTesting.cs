using HealthApp.Database;
using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Impl;
using System;
using Xunit;

namespace HealthApp.Tests
{
    public class DoctorRepositoryTesting
    {
        private readonly DoctorDb _db;
        private readonly DoctorRepository _repo;

        public DoctorRepositoryTesting()
        {
            _db = new DoctorDb();
            _db.Doctors.Clear(); // ✅ FIX
            _repo = new DoctorRepository(_db);
        }

        [Fact]
        public void Add_ShouldAddDoctor()
        {
            int before = _db.Doctors.Count;

            _repo.Add(new Doctor());

            Assert.Equal(before + 1, _db.Doctors.Count);
        }

        [Fact]
        public void GetAll_ShouldReturnDoctors()
        {
            _db.Doctors.Add(new Doctor());
            _db.Doctors.Add(new Doctor());

            var result = _repo.GetAll();

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void GetById_ShouldReturnDoctor()
        {
            var doctor = new Doctor { DoctorId = 1 };
            _db.Doctors.Add(doctor);

            var result = _repo.GetById(1);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetById_ShouldThrowException()
        {
            Assert.Throws<DoctorNotFoundException>(() =>
                _repo.GetById(999));
        }

        [Fact]
        public void DeleteDoctorById_ShouldRemoveDoctor()
        {
            var doctor = new Doctor { DoctorId = 1 };
            _db.Doctors.Add(doctor);

            int before = _db.Doctors.Count;

            _repo.DeleteDoctorById(1);

            Assert.Equal(before - 1, _db.Doctors.Count);
        }

        [Fact]
        public void DeleteDoctorById_ShouldThrow()
        {
            Assert.Throws<DoctorNotFoundException>(() =>
                _repo.DeleteDoctorById(999));
        }

        [Fact]
        public void UpdateDoctorById_ShouldUpdateDoctor()
        {
            var doctor = new Doctor
            {
                DoctorId = 1,
                FullName = "Old"
            };

            _db.Doctors.Add(doctor);

            var updated = new Doctor
            {
                FullName = "New"
            };

            _repo.UpdateDoctorById(1, updated);

            var result = _repo.GetById(1); // ✅ FIX

            Assert.Equal("New", result.FullName);
        }

        [Fact]
        public void UpdateDoctorById_ShouldThrow()
        {
            Assert.Throws<DoctorNotFoundException>(() =>
                _repo.UpdateDoctorById(999, new Doctor()));
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

            _repo.ChangeDoctorStatus(1, false);

            Assert.False(doctor.IsActive);
        }

        [Fact]
        public void ChangeDoctorStatus_ShouldThrow()
        {
            Assert.Throws<DoctorNotFoundException>(() =>
                _repo.ChangeDoctorStatus(999, true));
        }
    }
}