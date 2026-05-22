using System;
using System.Linq;
using HealthApp.Database;
using HealthApp.Model;
using HealthApp.Repository.Impl;
using HealthApp.Exceptions;
using Xunit;

namespace HealthAppTesting.RepositoryTesting
{
    public class PatientRepositoryTests
    {
        private readonly PatientDb _db;
        private readonly PatientRepository _repo;

        public PatientRepositoryTests()
        {
            _db = new PatientDb();
            _repo = new PatientRepository(_db);
        }

        [Fact]
        public void Add_Should_Add_Patient()
        {
            var patient = new Patient
            {
                PatientId = 1,
                FullName = "Rishab"
            };

            _repo.Add(patient);

            Assert.Single(_db.Patients);
            Assert.Equal("Rishab", _db.Patients[0].FullName);
        }

        [Fact]
        public void GetAll_Should_Return_All_Patients()
        {
            _repo.Add(new Patient { PatientId = 1, FullName = "A" });
            _repo.Add(new Patient { PatientId = 2, FullName = "B" });

            var result = _repo.GetAll();

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void GetById_Should_Return_Patient_When_Exists()
        {
            var patient = new Patient { PatientId = 1, FullName = "Test" };
            _repo.Add(patient);

            var result = _repo.GetById(1);

            Assert.NotNull(result);
            Assert.Equal("Test", result.FullName);
        }

        [Fact]
        public void GetById_Should_Throw_Exception_When_NotFound()
        {
            Assert.Throws<PatientNotFoundException>(() =>
                _repo.GetById(100));
        }

        [Fact]
        public void Delete_Should_Remove_Patient()
        {
            var patient = new Patient { PatientId = 1, FullName = "Test" };
            _repo.Add(patient);

            var result = _repo.DeletePatient(1);

            Assert.Empty(_db.Patients);
            Assert.Contains("deleted", result.ToLower());
        }

        [Fact]
        public void Delete_Should_Throw_Exception_When_NotFound()
        {
            Assert.Throws<PatientNotFoundException>(() =>
                _repo.DeletePatient(10));
        }

        [Fact]
        public void Update_Should_Modify_Patient()
        {
            var patient = new Patient
            {
                PatientId = 1,
                FullName = "Old"
            };

            _repo.Add(patient);

            var updated = new Patient
            {
                FullName = "New",
                DateOfBirth = DateTime.Now,
                Gender = GenderType.Male,
                PhoneNumber = "9876543210",
                Email = "test@mail.com",
                InsuranceId = "INS123"
            };

            var result = _repo.UpdatePatient(1, updated);

            Assert.Equal("New", _db.Patients[0].FullName);
        }

        [Fact]
        public void Update_Should_Throw_Exception_When_NotFound()
        {
            var updated = new Patient
            {
                FullName = "Test"
            };

            Assert.Throws<PatientNotFoundException>(() =>
                _repo.UpdatePatient(99, updated));
        }
    }
}