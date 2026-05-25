using Moq;
using Xunit;
using HealthApp.Service.Impl;
using HealthApp.Model;
using HealthApp.Exceptions;
using HealthApp.Repository.Interface;

namespace HealthApp.Test
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

        [Fact]
        public void RegisterPatient_ShouldAssignId_WhenRepositoryEmpty()
        {
            // Arrange
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Patient>());

            var patient = new Patient
            {
                FullName = "Test User",
                DateOfBirth = new DateOnly(2000, 1, 1)
            };

            // Act
            _service.RegisterPatient(patient);

            // Assert
            Assert.Equal(1, patient.PatientId);

            _mockRepo.Verify(r => r.Add(patient), Times.Once);
        }

        [Fact]
        public void RegisterPatient_ShouldAssignNextId_WhenPatientsExist()
        {
            // Arrange
            var patients = new List<Patient>
            {
                new Patient { PatientId = 1 },
                new Patient { PatientId = 2 }
            };

            _mockRepo.Setup(r => r.GetAll())
                     .Returns(patients);

            var patient = new Patient
            {
                FullName = "New Patient",
                DateOfBirth = new DateOnly(2001, 1, 1)
            };

            // Act
            _service.RegisterPatient(patient);

            // Assert
            Assert.Equal(3, patient.PatientId);

            _mockRepo.Verify(r => r.Add(patient), Times.Once);
        }

        [Fact]
        public void GetAllPatients_ShouldReturnPatients_WhenPatientsExist()
        {
            // Arrange
            var patients = new List<Patient>
            {
                new Patient
                {
                    PatientId = 1,
                    FullName = "John"
                }
            };

            _mockRepo.Setup(r => r.GetAll())
                     .Returns(patients);

            // Act
            var result = _service.GetAllPatients();

            // Assert
            Assert.Single(result);
            Assert.Equal("John", result[0].FullName);
        }

        [Fact]
        public void GetAllPatients_ShouldThrowException_WhenNoPatientsExist()
        {
            // Arrange
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Patient>());

            // Act & Assert
            Assert.Throws<NoPatientRegisteredException>(() =>
                _service.GetAllPatients());
        }

        [Fact]
        public void GetPatientById_ShouldReturnPatient_WhenPatientExists()
        {
            // Arrange
            var patient = new Patient
            {
                PatientId = 1,
                FullName = "John"
            };

            _mockRepo.Setup(r => r.GetById(1))
                     .Returns(patient);

            // Act
            var result = _service.GetPatientById(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.PatientId);
        }

        [Fact]
        public void GetPatientById_ShouldThrowException_WhenPatientNotFound()
        {
            // Arrange
            _mockRepo.Setup(r => r.GetById(1))
                     .Returns((Patient?)null);

            // Act & Assert
            Assert.Throws<PatientNotFoundException>(() =>
                _service.GetPatientById(1));
        }

        [Fact]
        public void DeletePatientById_ShouldReturnSuccessMessage_WhenDeleted()
        {
            // Arrange
            var patient = new Patient
            {
                PatientId = 1,
                FullName = "John"
            };

            _mockRepo.Setup(r => r.DeletePatient(1))
                     .Returns(patient);

            // Act
            var result = _service.DeletePatientById(1);

            // Assert
            Assert.Equal(
                "Patient with id 1 deleted successfully",
                result);
        }

        [Fact]
        public void DeletePatientById_ShouldThrowException_WhenPatientNotFound()
        {
            // Arrange
            _mockRepo.Setup(r => r.DeletePatient(1))
                     .Returns((Patient?)null);

            // Act & Assert
            Assert.Throws<PatientNotFoundException>(() =>
                _service.DeletePatientById(1));
        }

        [Fact]
        public void UpdatePatientById_ShouldReturnSuccessMessage_WhenUpdated()
        {
            // Arrange
            var patient = new Patient
            {
                PatientId = 1,
                FullName = "Updated Name",
                DateOfBirth = new DateOnly(2000, 1, 1)
            };

            _mockRepo.Setup(r => r.UpdatePatient(1, patient))
                     .Returns(patient);

            // Act
            var result = _service.UpdatePatientById(1, patient);

            // Assert
            Assert.Equal(
                "Patient with id 1 updated successfully",
                result);
        }

        [Fact]
        public void UpdatePatientById_ShouldThrowException_WhenPatientNotFound()
        {
            // Arrange
            var patient = new Patient
            {
                FullName = "Test",
                DateOfBirth = new DateOnly(2000, 1, 1)
            };

            _mockRepo.Setup(r => r.UpdatePatient(1, patient))
                     .Returns((Patient?)null);

            // Act & Assert
            Assert.Throws<PatientNotFoundException>(() =>
                _service.UpdatePatientById(1, patient));
        }
    }
}