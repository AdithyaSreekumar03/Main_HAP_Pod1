using HealthApp.Database;
using HealthApp.Model;
using HealthApp.Repository.Impl;
using Xunit;

namespace HealthApp.Tests
{
    public class PatientRepositoryTests
    {
        // ✅ Helper to create fresh repo every time
        private static PatientRepository CreateRepo(out PatientDb db)
        {
            db = new PatientDb();
            db.Patients = new System.Collections.Generic.List<Patient>(); // ✅ ensure clean
            return new PatientRepository(db);
        }

        // ✅ 1. ADD
        [Fact]
        public void Add_ShouldAddPatient()
        {
            var repo = CreateRepo(out var db);

            var patient = new Patient { PatientId = 1 };

            repo.Add(patient);

            Assert.Single(db.Patients);
        }

        // ✅ 2. GET ALL
        [Fact]
        public void GetAll_ShouldReturnPatients()
        {
            var repo = CreateRepo(out var db);

            db.Patients.Add(new Patient());

            var result = repo.GetAll();

            Assert.Single(result);
        }

        // ✅ 3. GET BY ID (FOUND)
        [Fact]
        public void GetById_ShouldReturnPatient()
        {
            var repo = CreateRepo(out var db);

            var patient = new Patient { PatientId = 1 };
            db.Patients.Add(patient);

            var result = repo.GetById(1);

            Assert.NotNull(result);
            Assert.Equal(1, result.PatientId);
        }

        // ✅ 4. GET BY ID (NOT FOUND)
        [Fact]
        public void GetById_ShouldReturnNull_WhenNotFound()
        {
            var repo = CreateRepo(out var db);

            var result = repo.GetById(99);

            Assert.Null(result);
        }

        // ✅ 5. DELETE SUCCESS
        [Fact]
        public void DeletePatient_ShouldRemovePatient()
        {
            var repo = CreateRepo(out var db);

            var patient = new Patient { PatientId = 1 };
            db.Patients.Add(patient);

            var result = repo.DeletePatient(1);

            Assert.NotNull(result);
            Assert.Empty(db.Patients);
        }

        // ✅ 6. DELETE NOT FOUND
        [Fact]
        public void DeletePatient_ShouldReturnNull_WhenNotFound()
        {
            var repo = CreateRepo(out var db);

            var result = repo.DeletePatient(1);

            Assert.Null(result);
        }

        // ✅ 7. UPDATE SUCCESS
        [Fact]
        public void UpdatePatient_ShouldModifyPatient()
        {
            var repo = CreateRepo(out var db);

            var patient = new Patient
            {
                PatientId = 1,
                FullName = "Old Name"
            };

            db.Patients.Add(patient);

            var updated = new Patient
            {
                FullName = "New Name",
                Email = "new@email.com"
            };

            var result = repo.UpdatePatient(1, updated);

            Assert.NotNull(result);
            Assert.Equal("New Name", result.FullName);
            Assert.Equal("new@email.com", result.Email);
        }

        // ✅ 8. UPDATE NOT FOUND
        [Fact]
        public void UpdatePatient_ShouldReturnNull_WhenNotFound()
        {
            var repo = CreateRepo(out var db);

            var result = repo.UpdatePatient(1, new Patient());

            Assert.Null(result);
        }
    }
}
