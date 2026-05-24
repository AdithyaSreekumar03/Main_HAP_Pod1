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
        public void GetById_ShouldReturnNull_WhenNotFound()
        {
            var repo = new PatientRepository(new PatientDb());

            var result = repo.GetById(999);

            Assert.Null(result);   // ✅ instead of Assert.Throws
        }

        [Fact]
        public void Delete_ShouldReturnNull_WhenNotFound()
        {
            var repo = new PatientRepository(new PatientDb());

            var result = repo.DeletePatient(999);

            Assert.Null(result);
        }

        [Fact]
        public void Update_ShouldReturnNull_WhenNotFound()
        {
            var repo = new PatientRepository(new PatientDb());

            var result = repo.UpdatePatient(999, new Patient());

            Assert.Null(result);
        }
    }
}
