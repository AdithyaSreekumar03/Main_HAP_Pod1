using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAppTests
{
    public class PatientServiceTests
    {
        private readonly Mock<IPatientRepository> _mockRepo;
        private readonly PatientService _patientService;

        public PatientServiceTests()
        {
            _mockRepo = new Mock<IPatientRepository>();
            _patientService = new PatientService(_mockRepo.Object);
        }

        [Fact]
        public void GetAllPatients_ReturnsAllPatients()
        {
            // Arrange
            var patients = new List<Patient>
            {
                new Patient
                {
                    PatientId = 1,
                    FullName = "John Doe",
                    Gender = GenderType.Male,
                    PhoneNumber = "9876543210",
                    Email = "john@example.com",
                    InsuranceId = "INS101"
                },
                new Patient
                {
                    PatientId = 2,
                    FullName = "Jane Smith",
                    Gender = GenderType.Female,
                    PhoneNumber = "9123456780",
                    Email = "jane@example.com",
                    InsuranceId = "INS102"
                }
            };

            _mockRepo.Setup(r => r.GetAll()).Returns(patients);

            // Act
            var result = _patientService.GetAllPatients();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);

            _mockRepo.Verify(r => r.GetAll(), Times.Once);
        }

        [Fact]
        public void GetPatientById_ReturnsPatient_WhenIdExists()
        {
            // Arrange
            var patient = new Patient
            {
                PatientId = 1,
                FullName = "John Doe",
                Gender = GenderType.Male,
                PhoneNumber = "9876543210",
                Email = "john@example.com",
                InsuranceId = "INS101"
            };

            _mockRepo.Setup(r => r.GetById(1)).Returns(patient);

            // Act
            var result = _patientService.GetPatientById(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.PatientId);

            _mockRepo.Verify(r => r.GetById(1), Times.Once);
        }

        [Fact]
        public void GetPatientById_ShouldThrowException_WhenIdNotFound()
        {
            // Arrange
            _mockRepo.Setup(r => r.GetById(999))
                     .Throws(new PatientNotFoundException("Patient not found"));

            // Act & Assert
            Assert.Throws<PatientNotFoundException>(() =>
                _patientService.GetPatientById(999));
        }

        [Fact]
        public void RegisterPatient_ShouldAddPatientSuccessfully()
        {
            // Arrange
            var patient = new Patient
            {
                FullName = "David",
                Gender = GenderType.Male,
                PhoneNumber = "9876543210",
                Email = "david@example.com",
                InsuranceId = "INS103"
            };

            _mockRepo.Setup(r => r.GetAll()).Returns(new List<Patient>());

            // Act
            _patientService.RegisterPatient(patient);

            // Assert
            Assert.Equal(1, patient.PatientId);

            _mockRepo.Verify(r => r.Add(patient), Times.Once);
        }



        [Fact]
        public void UpdatePatient_ShouldReturnSuccessMessage()
        {
            // Arrange
            var updatedPatient = new Patient
            {
                FullName = "Updated Name",
                Gender = GenderType.Female,
                PhoneNumber = "9999999999",
                Email = "updated@example.com",
                InsuranceId = "INS999"
            };

            _mockRepo.Setup(r => r.UpdatePatient(1, updatedPatient))
                     .Returns("Patient updated successfully");

            // Act
            var result = _patientService.UpdatePatientById(1, updatedPatient);

            // Assert
            Assert.Equal("Patient updated successfully", result);

            _mockRepo.Verify(r => r.UpdatePatient(1, updatedPatient), Times.Once);
        }

        [Fact]
        public void UpdatePatient_ShouldThrowException_WhenIdNotFound()
        {
            // Arrange
            var patient = new Patient();

            _mockRepo.Setup(r => r.UpdatePatient(999, patient))
                     .Throws(new PatientNotFoundException("Patient with id 999 not found"));

            // Act & Assert
            Assert.Throws<PatientNotFoundException>(() =>
                _patientService.UpdatePatientById(999, patient));
        }

        [Fact]
        public void DeletePatient_ShouldReturnSuccessMessage()
        {
            // Arrange
            _mockRepo.Setup(r => r.DeletePatient(1))
                     .Returns("Patient with id 1 deleted successfully");

            // Act
            var result = _patientService.DeletePatientById(1);

            // Assert
            Assert.Contains("successfully", result);

            _mockRepo.Verify(r => r.DeletePatient(1), Times.Once);
        }

        [Fact]
        public void DeletePatient_ShouldThrowException_WhenIdNotFound()
        {
            // Arrange
            _mockRepo.Setup(r => r.DeletePatient(999))
                     .Throws(new PatientNotFoundException("Patient with id 999 not found"));

            // Act & Assert
            Assert.Throws<PatientNotFoundException>(() =>
                _patientService.DeletePatientById(999));
        }
    }
}