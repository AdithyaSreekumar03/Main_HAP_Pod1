using HealthApp.Database;
using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Impl;
using System;
using Xunit;

namespace HealthApp.Tests
{
    public class PatientRepositoryTesting
    {
        private readonly PatientDb _db;
        private readonly PatientRepository _repo;

        public PatientRepositoryTesting()
        {
            _db = new PatientDb();
            _db.Patients.Clear(); // ✅ IMPORTANT FIX
            _repo = new PatientRepository(_db);
        }

        [Fact]
        public void Add_ShouldAddPatient()
        {
            var patient = new Patient { PatientId = 1 };

            _repo.Add(patient);

            Assert.Single(_db.Patients);
        }

        [Fact]
        public void DeletePatient_ShouldRemovePatient()
        {
            var patient = new Patient { PatientId = 1 };

            _db.Patients.Add(patient);

            int before = _db.Patients.Count;

            _repo.DeletePatient(1);

            Assert.Equal(before - 1, _db.Patients.Count); // ✅ FIX
        }

        [Fact]
        public void DeletePatient_ShouldThrowException()
        {
            Assert.Throws<PatientNotFoundException>(() =>
                _repo.DeletePatient(999));
        }

        [Fact]
        public void GetAll_ShouldReturnPatients()
        {
            _db.Patients.Add(new Patient());

            var result = _repo.GetAll();

            Assert.Single(result);
        }

        [Fact]
        public void GetById_ShouldReturnPatient()
        {
            var patient = new Patient { PatientId = 1 };
            _db.Patients.Add(patient);

            var result = _repo.GetById(1);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetById_ShouldThrowException()
        {
            Assert.Throws<PatientNotFoundException>(() =>
                _repo.GetById(999));
        }

        [Fact]
        public void UpdatePatient_ShouldUpdatePatient()
        {
            var patient = new Patient
            {
                PatientId = 1,
                FullName = "Old Name"
            };

            _db.Patients.Add(patient);

            var updated = new Patient
            {
                FullName = "New Name"
            };

            _repo.UpdatePatient(1, updated);

            var result = _repo.GetById(1); // ✅ VERY IMPORTANT FIX

            Assert.Equal("New Name", result.FullName);
        }

        [Fact]
        public void UpdatePatient_ShouldThrowException()
        {
            Assert.Throws<PatientNotFoundException>(() =>
                _repo.UpdatePatient(999, new Patient()));
        }
    }
}
