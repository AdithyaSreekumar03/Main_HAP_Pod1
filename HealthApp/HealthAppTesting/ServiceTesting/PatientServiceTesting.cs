using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace HealthApp.Tests
{
    public class PatientServiceTesting
    {
        private readonly Mock<IPatientRepository> _mockRepo;
        private readonly PatientService _service;

        public PatientServiceTesting()
        {
            _mockRepo = new Mock<IPatientRepository>();
            _service = new PatientService(_mockRepo.Object);
        }

        // ✅ Helper
        private Patient GetPatient() => new Patient
        {
            PatientId = 1,
            FullName = "Test Patient"
        };

        // ✅ 1. Register Patient (Empty list → ID = 1)
        [Fact]
        public void RegisterPatient_ShouldAssignId_WhenEmpty()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Patient>());

            var patient = GetPatient();

            _service.RegisterPatient(patient);

            Assert.Equal(1, patient.PatientId);
            _mockRepo.Verify(r => r.Add(patient), Times.Once);
        }

        // ✅ 2. Register Patient (Existing patients → next ID)
        [Fact]
        public void RegisterPatient_ShouldAssignNextId()
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

        // ✅ 3. Get All Patients
        [Fact]
        public void GetAllPatients_ShouldReturnPatients()
        {
            var patients = new List<Patient>
            {
                GetPatient()
            };

            _mockRepo.Setup(r => r.GetAll()).Returns(patients);

            var result = _service.GetAllPatients();

            Assert.Single(result);
        }

        // ✅ 4. Get Patient By Id
        [Fact]
        public void GetPatientById_ShouldReturnPatient()
        {
            var patient = GetPatient();

            _mockRepo.Setup(r => r.GetById(1)).Returns(patient);

            var result = _service.GetPatientById(1);

            Assert.NotNull(result);
            Assert.Equal(1, result.PatientId);
        }

        // ✅ 5. Delete Patient
        [Fact]
        public void DeletePatient_ShouldReturnMessage()
        {
            _mockRepo.Setup(r => r.DeletePatient(1))
                     .Returns("deleted");

            var result = _service.DeletePatientById(1);

            Assert.Equal("deleted", result);
        }

        // ✅ 6. Delete Patient Exception
        [Fact]
        public void DeletePatient_ShouldThrowException()
        {
            _mockRepo.Setup(r => r.DeletePatient(1))
                     .Throws(new Exceptions.PatientNotFoundException("error"));

            Assert.Throws<Exceptions.PatientNotFoundException>(() =>
                _service.DeletePatientById(1));
        }

        // ✅ 7. Update Patient
        [Fact]
        public void UpdatePatient_ShouldReturnMessage()
        {
            _mockRepo.Setup(r => r.UpdatePatient(1, It.IsAny<Patient>()))
                     .Returns("updated");

            var result = _service.UpdatePatientById(1, GetPatient());

            Assert.Equal("updated", result);
        }

        // ✅ 8. Update Patient Exception
        [Fact]
        public void UpdatePatient_ShouldThrowException()
        {
            _mockRepo.Setup(r => r.UpdatePatient(1, It.IsAny<Patient>()))
                     .Throws(new Exceptions.PatientNotFoundException("error"));

            Assert.Throws<Exceptions.PatientNotFoundException>(() =>
                _service.UpdatePatientById(1, GetPatient()));
        }
    }
}