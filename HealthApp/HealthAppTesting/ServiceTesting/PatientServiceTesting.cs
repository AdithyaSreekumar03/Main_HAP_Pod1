using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace HealthApp.Tests
{
    public class PatientServiceTests
    {
        private readonly Mock<IPatientRepository> _mockRepo;
        private readonly PatientService _service;

        public PatientServiceTests()
        {
            _mockRepo = new Mock<IPatientRepository>();
            _service = new PatientService(_mockRepo.Object);
        }

        private Patient GetPatient() => new Patient
        {
            FullName = "John",
            DateOfBirth = DateOnly.FromDateTime(DateTime.Today.AddYears(-20))
        };

        // ✅ 1. REGISTER SUCCESS
        [Fact]
        public void Register_ShouldAssignId_WhenListEmpty()
        {
            _mockRepo.Setup(r => r.GetAll()).Returns(new List<Patient>());

            var patient = GetPatient();

            _service.RegisterPatient(patient);

            Assert.Equal(1, patient.PatientId);
        }

        // ✅ 2. REGISTER WITH EXISTING
        [Fact]
        public void Register_ShouldAssignNextId()
        {
            _mockRepo.Setup(r => r.GetAll())
                .Returns(new List<Patient>
                {
                    new Patient { PatientId = 5 }
                });

            var patient = GetPatient();

            _service.RegisterPatient(patient);

            Assert.Equal(6, patient.PatientId);
        }

        // ✅ 3. REGISTER INVALID NAME
        [Fact]
        public void Register_ShouldThrow_WhenNameInvalid()
        {
            var patient = new Patient
            {
                FullName = "",
                DateOfBirth = DateOnly.FromDateTime(DateTime.Today.AddYears(-20))
            };

            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Patient>());

            Assert.Throws<Exception>(() =>
                _service.RegisterPatient(patient));
        }

        // ✅ 4. REGISTER INVALID DOB
        [Fact]
        public void Register_ShouldThrow_WhenDobInvalid()
        {
            var patient = new Patient
            {
                FullName = "John",
                DateOfBirth = default
            };

            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Patient>());

            Assert.Throws<Exception>(() =>
                _service.RegisterPatient(patient));
        }

        // ✅ 5. GET ALL SUCCESS
        [Fact]
        public void GetAll_ShouldReturnPatients()
        {
            _mockRepo.Setup(r => r.GetAll())
                .Returns(new List<Patient> { new Patient() });

            var result = _service.GetAllPatients();

            Assert.Single(result);
        }

        // ✅ 6. GET ALL EMPTY
        [Fact]
        public void GetAll_ShouldThrow_WhenEmpty()
        {
            _mockRepo.Setup(r => r.GetAll())
                .Returns(new List<Patient>());

            Assert.Throws<NoPatientRegisteredException>(() =>
                _service.GetAllPatients());
        }

        // ✅ 7. GET BY ID SUCCESS
        [Fact]
        public void GetById_ShouldReturnPatient()
        {
            var patient = GetPatient();

            _mockRepo.Setup(r => r.GetById(1))
                     .Returns(patient);

            var result = _service.GetPatientById(1);

            Assert.NotNull(result);
        }

        // ✅ 8. GET BY ID NOT FOUND
        [Fact]
        public void GetById_ShouldThrow_WhenNotFound()
        {
            _mockRepo.Setup(r => r.GetById(1))
                     .Returns((Patient?)null);

            Assert.Throws<PatientNotFoundException>(() =>
                _service.GetPatientById(1));
        }

        // ✅ 9. DELETE SUCCESS
        [Fact]
        public void Delete_ShouldReturnMessage()
        {
            _mockRepo.Setup(r => r.DeletePatient(1))
                     .Returns(new Patient());

            var result = _service.DeletePatientById(1);

            Assert.Contains("deleted", result);
        }

        // ✅ 10. DELETE NOT FOUND
        [Fact]
        public void Delete_ShouldThrow_WhenNotFound()
        {
            _mockRepo.Setup(r => r.DeletePatient(1))
                     .Returns((Patient?)null);

            Assert.Throws<PatientNotFoundException>(() =>
                _service.DeletePatientById(1));
        }

        // ✅ 11. UPDATE SUCCESS
        [Fact]
        public void Update_ShouldReturnMessage()
        {
            var patient = GetPatient();

            _mockRepo.Setup(r => r.UpdatePatient(1, patient))
                     .Returns(patient);

            var result = _service.UpdatePatientById(1, patient);

            Assert.Contains("updated", result);
        }

        // ✅ 12. UPDATE INVALID NAME
        [Fact]
        public void Update_ShouldThrow_WhenNameInvalid()
        {
            var patient = new Patient { FullName = "" };

            Assert.Throws<Exception>(() =>
                _service.UpdatePatientById(1, patient));
        }

        // ✅ 13. UPDATE NOT FOUND
        [Fact]
        public void Update_ShouldThrow_WhenNotFound()
        {
            var patient = GetPatient();

            _mockRepo.Setup(r => r.UpdatePatient(1, patient))
                     .Returns((Patient?)null);

            Assert.Throws<PatientNotFoundException>(() =>
                _service.UpdatePatientById(1, patient));
        }
    }
}
