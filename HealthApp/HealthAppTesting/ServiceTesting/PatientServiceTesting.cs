using System;
using System.Collections.Generic;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using HealthApp.Exceptions;
using Moq;
using Xunit;

namespace HealthApp.Tests
{
    public class PatientServiceTests
    {
        private readonly Mock<IPatientRepository> _repoMock;
        private readonly PatientService _service;

        public PatientServiceTests()
        {
            _repoMock = new Mock<IPatientRepository>();
            _service = new PatientService(_repoMock.Object);
        }

        private Patient GetPatient() =>
            new Patient { PatientId = 1, FullName = "Test" };



        // ✅ 1. Register Patient Success
        [Fact]
        public void RegisterPatient_Should_Add_Patient()
        {
            _repoMock.Setup(r => r.GetAll()).Returns(new List<Patient>());

            var patient = new Patient { FullName = "Rishab" };

            _service.RegisterPatient(patient);

            _repoMock.Verify(r => r.Add(It.IsAny<Patient>()), Times.Once);
        }



        // ✅ 2. Register assigns correct ID
        [Fact]
        public void RegisterPatient_Should_Set_Id()
        {
            _repoMock.Setup(r => r.GetAll()).Returns(new List<Patient>
            {
                new Patient { PatientId = 1 }
            });

            var patient = new Patient();

            _service.RegisterPatient(patient);

            Assert.Equal(2, patient.PatientId);
        }



        // ✅ 3. GetAll Patients
        [Fact]
        public void GetAllPatients_Should_Return_List()
        {
            _repoMock.Setup(r => r.GetAll())
                .Returns(new List<Patient> { GetPatient() });

            var result = _service.GetAllPatients();

            Assert.Single(result);
        }



        // ✅ 4. GetPatientById Success
        [Fact]
        public void GetPatientById_Should_Return_Patient()
        {
            _repoMock.Setup(r => r.GetById(1))
                     .Returns(GetPatient());

            var result = _service.GetPatientById(1);

            Assert.NotNull(result);
            Assert.Equal(1, result.PatientId);
        }



        // ✅ 5. GetPatientById Not Found (Exception)
        [Fact]
        public void GetPatientById_Should_Throw_Exception()
        {
            _repoMock.Setup(r => r.GetById(1))
                     .Throws(new PatientNotFoundException("Not found"));

            Assert.Throws<PatientNotFoundException>(() =>
                _service.GetPatientById(1));
        }



        // ✅ 6. Update Patient Success
        [Fact]
        public void UpdatePatient_Should_Call_Repository()
        {
            var patient = new Patient { FullName = "Updated" };

            _repoMock.Setup(r => r.UpdatePatient(1, patient))
                     .Returns("updated");

            var result = _service.UpdatePatientById(1, patient);

            Assert.Equal("updated", result);
        }



        // ✅ 7. Update Patient Not Found
        [Fact]
        public void UpdatePatient_Should_Throw_Exception()
        {
            var patient = new Patient();

            _repoMock.Setup(r => r.UpdatePatient(1, patient))
                     .Throws(new PatientNotFoundException("Not found"));

            Assert.Throws<PatientNotFoundException>(() =>
                _service.UpdatePatientById(1, patient));
        }



        // ✅ 8. Delete Patient Success
        [Fact]
        public void DeletePatient_Should_Call_Repository()
        {
            _repoMock.Setup(r => r.DeletePatient(1))
                     .Returns("deleted");

            var result = _service.DeletePatientById(1);

            Assert.Equal("deleted", result);
        }



        // ✅ 9. Delete Patient Not Found
        [Fact]
        public void DeletePatient_Should_Throw_Exception()
        {
            _repoMock.Setup(r => r.DeletePatient(1))
                     .Throws(new PatientNotFoundException("Not found"));

            Assert.Throws<PatientNotFoundException>(() =>
                _service.DeletePatientById(1));
        }
    }
}