using Moq;
using POD1_NET_ConsoleApp.Models;
using POD1_NET_ConsoleApp.Repositories.Interfaces;
using POD1_NET_ConsoleApp.Service.Impl;
using POD1_NET_ConsoleApp.Exceptions;

namespace POD1_NET_ConsoleAppTests
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

        //  1. GetAll
        [Fact]
        public void GetAll_ReturnsAllPatients()
        {
            var patients = new List<Patient>
            {
                new Patient { PatientId = 1, FullName = "Mark" },
                new Patient { PatientId = 2, FullName = "Sara" }
            };

            _mockRepo.Setup(r => r.GetAll()).Returns(patients);

            var result = _service.GetAll();

            Assert.NotNull(result);
            Assert.Equal(2, result.Count);

            _mockRepo.Verify(r => r.GetAll(), Times.Once);
        }

        //  2. GetById (Valid)
        [Fact]
        public void GetById_ReturnsPatient_WhenExists()
        {
            var patient = new Patient { PatientId = 100, FullName = "Mark" };

            _mockRepo.Setup(r => r.GetById(100)).Returns(patient);

            var result = _service.GetById(100);

            Assert.NotNull(result);
            Assert.Equal(100, result.PatientId);

            _mockRepo.Verify(r => r.GetById(100), Times.Once);
        }

        //  3. GetById (Invalid → Exception)
        [Fact]
        public void GetById_ShouldThrowException_WhenNotFound()
        {
            _mockRepo.Setup(r => r.GetById(999))
                     .Throws(new PatientNotFoundException("Not found"));

            Assert.Throws<PatientNotFoundException>(
                () => _service.GetById(999)
            );
        }

        //  4. Add Patient
        [Fact]
        public void AddPatient_ShouldReturnSuccessMessage()
        {
            var patient = new Patient { FullName = "New Patient" };

            _mockRepo.Setup(r => r.AddPatient(patient))
                     .Returns("Patient added successfully");

            var result = _service.AddPatient(patient);

            Assert.Equal("Patient added successfully", result);

            _mockRepo.Verify(r => r.AddPatient(patient), Times.Once);
        }

        //  5. Update Patient 
        [Fact]
        public void UpdatePatient_ShouldReturnSuccessMessage()
        {
            var patient = new Patient { FullName = "Updated Name" };

            _mockRepo.Setup(r => r.UpdatePatient(100, patient))
                     .Returns("Patient updated successfully");

            var result = _service.UpdatePatient(100, patient);

            Assert.Equal("Patient updated successfully", result);

            _mockRepo.Verify(r => r.UpdatePatient(100, patient), Times.Once);
        }

        //  6. Update Patient (Invalid → Exception)
        [Fact]
        public void UpdatePatient_ShouldThrowException_WhenNotFound()
        {
            var patient = new Patient();

            _mockRepo.Setup(r => r.UpdatePatient(999, patient))
                     .Throws(new PatientNotFoundException("Not found"));

            Assert.Throws<PatientNotFoundException>(
                () => _service.UpdatePatient(999, patient)
            );
        }

        //  7. Delete Patient (Valid)
        [Fact]
        public void DeletePatient_ShouldReturnSuccessMessage()
        {
            _mockRepo.Setup(r => r.DeletePatient(100))
                     .Returns("Deleted successfully");

            var result = _service.DeletePatient(100);

            Assert.Equal("Deleted successfully", result);

            _mockRepo.Verify(r => r.DeletePatient(100), Times.Once);
        }

        //  8. Delete Patient (Invalid → Exception)
        [Fact]
        public void DeletePatient_ShouldThrowException_WhenNotFound()
        {
            _mockRepo.Setup(r => r.DeletePatient(999))
                     .Throws(new PatientNotFoundException("Not found"));

            Assert.Throws<PatientNotFoundException>(
                () => _service.DeletePatient(999)
            );
        }
    }
}
