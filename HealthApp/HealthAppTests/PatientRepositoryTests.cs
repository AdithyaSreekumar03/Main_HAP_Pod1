using System.Linq;
using Xunit;
using POD1_NET_ConsoleApp.Database;
using POD1_NET_ConsoleApp.Models;
using POD1_NET_ConsoleApp.Repositories.Impl;
using POD1_NET_ConsoleApp.Exceptions;

namespace POD1_NET_ConsoleAppTests
{
    public class PatientRepositoryTests
    {
        //  1. Get All Patients
        [Fact]
        public void GetAll_ShouldReturnAllPatients()
        {
            var db = new PatientDb();
            var repo = new PatientRepository(db);

            var result = repo.GetAll();

            Assert.NotNull(result);
            Assert.Equal(2, result.Count); // based on your DB
        }

        //  2. Get By Id (Valid)
        [Fact]
        public void GetById_ShouldReturnPatient_WhenExists()
        {
            var db = new PatientDb();
            var repo = new PatientRepository(db);

            var patient = repo.GetById(100);

            Assert.NotNull(patient);
            Assert.Equal("Mark", patient.FullName);
        }

        // 3. Get By Id (Invalid → Exception)
        [Fact]
        public void GetById_ShouldThrowException_WhenNotFound()
        {
            var db = new PatientDb();
            var repo = new PatientRepository(db);

            Assert.Throws<PatientNotFoundException>(
                () => repo.GetById(999)
            );
        }

        // 4. Add Patient
        [Fact]
        public void AddPatient_ShouldIncreaseCount()
        {
            var db = new PatientDb();
            var repo = new PatientRepository(db);

            var newPatient = new Patient
            {
                FullName = "TestUser",
                DateOfBirth = new System.DateTime(2000, 1, 1),
                Gender = "Male",

            };

            var result = repo.AddPatient(newPatient);

            Assert.Equal("Patient added successfully", result);
            Assert.Equal(3, repo.GetAll().Count);
        }

        //  5. Update Patient (Valid)
        [Fact]
        public void UpdatePatient_ShouldModifyData()
        {
            var db = new PatientDb();
            var repo = new PatientRepository(db);

            var updated = new Patient
            {
                FullName = "Updated Name"
            };

            var result = repo.UpdatePatient(100, updated);

            Assert.Equal("Patient updated successfully", result);
            Assert.Equal("Updated Name", repo.GetById(100).FullName);
        }

        //  6. Update Patient (Invalid → Exception)
        [Fact]
        public void UpdatePatient_ShouldThrowException_WhenNotFound()
        {
            var db = new PatientDb();
            var repo = new PatientRepository(db);

            var patient = new Patient();

            Assert.Throws<PatientNotFoundException>(
                () => repo.UpdatePatient(999, patient)
            );
        }

        //  7. Delete Patient (Valid)
        [Fact]
        public void DeletePatient_ShouldRemovePatient()
        {
            var db = new PatientDb();
            var repo = new PatientRepository(db);

            var result = repo.DeletePatient(100);

            Assert.Equal("Deleted successfully", result);
            Assert.Equal(1, repo.GetAll().Count);
        }

        //  8. Delete Patient (Invalid → Exception)
        [Fact]
        public void DeletePatient_ShouldThrowException_WhenNotFound()
        {
            var db = new PatientDb();
            var repo = new PatientRepository(db);

            Assert.Throws<PatientNotFoundException>(
                () => repo.DeletePatient(999)
            );
        }
    }
}