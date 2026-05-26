using HealthApp.Database;
using HealthApp.Model;
using HealthApp.Repository.Impl;
using System.Collections.Generic;
using Xunit;

namespace HealthApp.Tests
{
    public class PatientRepositoryTests
    {
        private readonly PatientDb _db;
        private readonly PatientRepository _repo;

        public PatientRepositoryTests()
        {
            _db = new PatientDb();

            // ✅ Ensure list is initialized properly
            _db.Patients = new List<Patient>();

            // ✅ Pass the SAME db instance to repo
            _repo = new PatientRepository(_db);
        }

        // ✅ 1. ADD
        [Fact]
        public void Add_ShouldAddPatient()
        {
            var patient = new Patient { PatientId = 1 };

            _repo.Add(patient);

            Assert.Single(_db.Patients);
        }

        // ✅ 2. GET ALL (WITH DATA)
        [Fact]
        public void GetAll_ShouldReturnPatients()
        {
            _db.Patients.Add(new Patient());
            _db.Patients.Add(new Patient());

            var result = _repo.GetAll();

            Assert.Equal(2, result.Count);
        }

        // ✅ 3. GET ALL (EMPTY)
        [Fact]
        public void GetAll_ShouldReturnEmpty_WhenNoData()
        {
            var result = _repo.GetAll();

            Assert.Empty(result);
        }

        // ✅ 4. GET BY ID (FOUND)
        [Fact]
        public void GetById_ShouldReturnPatient()
        {
            var patient = new Patient { PatientId = 1 };
            _db.Patients.Add(patient);

            var result = _repo.GetById(1);

            Assert.NotNull(result);
            Assert.Equal(1, result!.PatientId);
        }

        // ✅ 5. GET BY ID (NOT FOUND)
        [Fact]
        public void GetById_ShouldReturnNull_WhenNotFound()
        {
            var result = _repo.GetById(99);

            Assert.Null(result);
        }

        // ✅ 6. UPDATE (SUCCESS)
        [Fact]
        public void UpdatePatient_ShouldUpdatePatient()
        {
            var existing = new Patient
            {
                PatientId = 1,
                FullName = "Old Name",
                Email = "old@email.com"
            };

            _db.Patients.Add(existing);

            var updated = new Patient
            {
                FullName = "New Name",
                Email = "new@email.com"
            };

            var result = _repo.UpdatePatientById(1, updated);

            Assert.NotNull(result);
            Assert.Equal("New Name", result!.FullName);
            Assert.Equal("new@email.com", result.Email);
        }

        // ✅ 7. UPDATE (NOT FOUND)
        [Fact]
        public void UpdatePatient_ShouldReturnNull_WhenNotFound()
        {
            var result = _repo.UpdatePatientById(99, new Patient());

            Assert.Null(result);
        }
    }
}
