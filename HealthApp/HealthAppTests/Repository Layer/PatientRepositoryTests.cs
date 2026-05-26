using HealthApp.Database;
using HealthApp.Model;
using HealthApp.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAppTests.Repository_Layer
{
    public class PatientRepositoryTests
    {
        private readonly PatientDb _db;
        private readonly PatientRepository _repo;

        public PatientRepositoryTests()
        {
            _db = new PatientDb();
            _db.Patients.Clear();
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
        public void GetAll_ShouldReturnPatients()
        {
            _db.Patients.Add(new Patient());
            _db.Patients.Add(new Patient());

            var result = _repo.GetAll();

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void GetAll_ShouldReturnEmpty_WhenNoData()
        {
            var result = _repo.GetAll();

            Assert.Empty(result);
        }

        [Fact]
        public void GetById_ShouldReturnPatient()
        {
            var patient = new Patient { PatientId = 1 };
            _db.Patients.Add(patient);

            var result = _repo.GetById(1);

            Assert.NotNull(result);
            Assert.Equal(1, result.PatientId);
        }

        [Fact]
        public void GetById_ShouldReturnNull_WhenNotFound()
        {
            var result = _repo.GetById(99);

            Assert.Null(result);
        }

        [Fact]
        public void UpdatePatient_ShouldUpdatePatient()
        {
            var existing = new Patient
            {
                PatientId = 1,
                FullName = "Old Name"
            };

            _db.Patients.Add(existing);

            var updated = new Patient
            {
                FullName = "New Name",
                Email = "new@email.com"
            };

            var result = _repo.UpdatePatient(1, updated);

            Assert.NotNull(result);
            Assert.Equal("New Name", result.FullName);
            Assert.Equal("new@email.com", result.Email);
        }

        [Fact]
        public void UpdatePatient_ShouldReturnNull_WhenNotFound()
        {
            var result = _repo.UpdatePatient(99, new Patient());

            Assert.Null(result);
        }
    }
}