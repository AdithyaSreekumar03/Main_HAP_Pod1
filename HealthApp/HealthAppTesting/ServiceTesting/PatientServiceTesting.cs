using HealthApp.Exceptions;
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

        // ✅ 1. REGISTER EMPTY → ID = 1
        [Fact]
        public void Register_ShouldAssignId_WhenEmpty()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Patient>());

            var patient = new Patient();

            _service.RegisterPatient(patient);

            Assert.Equal(1, patient.PatientId);
            _mockRepo.Verify(r => r.Add(patient), Times.Once);
        }

        // ✅ 2. REGISTER WITH DATA → NEXT ID
        [Fact]
        public void Register_ShouldAssignNextId()
        {
            var list = new List<Patient>
            {
                new Patient { PatientId = 1 },
                new Patient { PatientId = 5 }
            };

            _mockRepo.Setup(r => r.GetAll()).Returns(list);

            var patient = new Patient();

            _service.RegisterPatient(patient);

            Assert.Equal(6, patient.PatientId);
            _mockRepo.Verify(r => r.Add(patient), Times.Once);
        }

        // ✅ 3. GET BY ID SUCCESS
        [Fact]
        public void GetById_ShouldReturnPatient()
        {
            var patient = new Patient { PatientId = 1 };

            _mockRepo.Setup(r => r.GetById(1))
                     .Returns(patient);

            var result = _service.GetPatientById(1);

            Assert.NotNull(result);
            Assert.Equal(1, result!.PatientId);
        }

        // ✅ 4. GET BY ID FAIL
        [Fact]
        public void GetById_ShouldThrow_WhenNotFound()
        {
            _mockRepo.Setup(r => r.GetById(1))
                     .Returns((Patient?)null);

            Assert.Throws<PatientNotFoundException>(
                () => _service.GetPatientById(1)
            );
        }

        // ✅ 5. GET ALL SUCCESS
        [Fact]
        public void GetAll_ShouldReturnPatients()
        {
            var patients = new List<Patient> { new Patient() };

            _mockRepo.Setup(r => r.GetAll())
                     .Returns(patients);

            var result = _service.GetAllPatients();

            Assert.Single(result);
        }

        // ✅ 6. GET ALL FAIL
        [Fact]
        public void GetAll_ShouldThrow_WhenEmpty()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Patient>());

            Assert.Throws<PatientNotFoundException>(
                () => _service.GetAllPatients()
            );
        }

        // ✅ 7. UPDATE FAIL
        [Fact]
        public void Update_ShouldThrow_WhenNotFound()
        {
            _mockRepo.Setup(r => r.UpdatePatientById(1, It.IsAny<Patient>()))
                     .Returns((Patient?)null);

            Assert.Throws<PatientNotFoundException>(
                () => _service.UpdatePatientById(1, new Patient())
            );
        }

        // ✅ 8. UPDATE SUCCESS
        [Fact]
        public void Update_ShouldReturnMessage()
        {
            _mockRepo.Setup(r => r.UpdatePatientById(1, It.IsAny<Patient>()))
                     .Returns(new Patient());

            var result = _service.UpdatePatientById(1, new Patient());

            Assert.Contains("updated", result.ToLower());
        }

        // ✅ 9. DELETE FAIL
        [Fact]
        public void Delete_ShouldThrow_WhenNotFound()
        {
            _mockRepo.Setup(r => r.DeletePatientById(1))
                     .Returns((Patient?)null);

            Assert.Throws<PatientNotFoundException>(
                () => _service.DeletePatientById(1)
            );
        }

        // ✅ 10. DELETE SUCCESS
        [Fact]
        public void Delete_ShouldReturnMessage()
        {
            _mockRepo.Setup(r => r.DeletePatientById(1))
                     .Returns(new Patient());

            var result = _service.DeletePatientById(1);

            Assert.Contains("deleted", result.ToLower());
        }
    }
}
