using HealthApp.Databases;
using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Impl;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using HealthApp.Service.Interface;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HealthAppTests.Service_Layer
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

        [Fact]
        public void Register_ShouldAssignId_WhenEmpty()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Patient>());

            var patient = new Patient();

            _service.RegisterPatient(patient);

            Assert.Equal(1, patient.PatientId);
        }


        [Fact]
        public void Register_ShouldAssignNextId()
        {
            var list = new List<Patient>
        {
            new Patient { PatientId = 1 },
            new Patient { PatientId = 5 }
        };

            _mockRepo.Setup(r => r.GetAll())
                     .Returns(list);

            var patient = new Patient();

            _service.RegisterPatient(patient);

            Assert.Equal(6, patient.PatientId);
        }

        [Fact]
        public void GetById_ShouldReturnPatient()
        {
            var patient = new Patient { PatientId = 1 };

            _mockRepo.Setup(r => r.GetById(1))
                     .Returns(patient);

            var result = _service.GetPatientById(1);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetById_ShouldThrow_WhenNotFound()
        {
            _mockRepo.Setup(r => r.GetById(1))
                     .Returns((Patient?)null);

            Assert.Throws<PatientNotFoundException>(() =>
                _service.GetPatientById(1));
        }

        [Fact]
        public void UpdatePatientById_ShouldReturnSuccessMessage()
        {
            var updated = new Patient
            {
                FullName = "New Name",
                Email = "new@email.com"
            };

            _mockRepo.Setup(r => r.UpdatePatient(1, updated))
                     .Returns(updated);

            var result = _service.UpdatePatientById(1, updated);

            Assert.Equal("Patient with id 1 updated successfully", result);
        }

        [Fact]
        public void UpdatePatientById_ShouldThrowException_WhenNotFound()
        {
            var updated = new Patient();

            _mockRepo.Setup(r => r.UpdatePatient(1, updated))
                     .Returns((Patient?)null);

            Assert.Throws<PatientNotFoundException>(() =>
                _service.UpdatePatientById(1, updated));
        }
    }

}