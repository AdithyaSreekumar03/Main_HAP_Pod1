using Moq;
using Xunit;
using HealthApp.Service.Impl;
using HealthApp.Model;
using HealthApp.Exceptions;
using HealthApp.Repository.Interface;

namespace HealthAppTests.ServiceTesting
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

        //   GetById exception
        [Fact]
        public void GetPatientById_ShouldThrowException_WhenNotFound()
        {
            _mockRepo.Setup(r => r.GetById(1)).Returns((Patient?)null);

            Assert.Throws<PatientNotFoundException>(() =>
                _service.GetPatientById(1));
        }

        //   Delete exception
        [Fact]
        public void DeletePatient_ShouldThrowException_WhenNotFound()
        {
            _mockRepo.Setup(r => r.DeletePatient(1)).Returns((Patient?)null);

            Assert.Throws<PatientNotFoundException>(() =>
                _service.DeletePatientById(1));
        }

        [Fact]
        public void UpdatePatient_ShouldThrowException_WhenNotFound()
        {
            var patient = new Patient
            {
                FullName = "Valid Name",
                DateOfBirth = new DateOnly(2000, 1, 1)
            };

            _mockRepo.Setup(r => r.UpdatePatient(1, patient))
                     .Returns((Patient?)null);

            Assert.Throws<PatientNotFoundException>(() =>
                _service.UpdatePatientById(1, patient));
        }

        //   GetAll exception
        [Fact]
        public void GetAll_ShouldThrow_WhenEmpty()
        {
            _mockRepo.Setup(r => r.GetAll()).Returns(new List<Patient>());

            Assert.Throws<NoPatientsRegisteredException>(() =>
                _service.GetAllPatients());
        }

        //   SUCCESS TEST
        [Fact]
        public void RegisterPatient_ShouldAssignId()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Patient>());

            var patient = new Patient { FullName = "Test", DateOfBirth = new DateOnly(2000, 1, 1) };

            _service.RegisterPatient(patient);

            Assert.Equal(1, patient.PatientId);
        }
    }
}
