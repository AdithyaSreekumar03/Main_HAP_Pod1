using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace HealthApp.Tests
{
    public class DoctorServiceTesting
    {
        private readonly Mock<IDoctorRepository> _mockRepo;
        private readonly DoctorService _service;

        public DoctorServiceTesting()
        {
            _mockRepo = new Mock<IDoctorRepository>();
            _service = new DoctorService(_mockRepo.Object);
        }

        // ✅ Helper
        private Doctor GetDoctor() => new Doctor
        {
            DoctorId = 1,
            FullName = "Test Doctor",
            Specialisation = SpecialisationType.Cardiologist,
            IsActive = true
        };

        // ✅ 1. Add Doctor
        [Fact]
        public void AddDoctor_ShouldAssignId()
        {
            _mockRepo.Setup(r => r.GetAll()).Returns(new List<Doctor>());

            var doctor = GetDoctor();

            _service.AddDoctor(doctor);

            Assert.Equal(1, doctor.DoctorId);
            Assert.True(doctor.IsActive);
            _mockRepo.Verify(r => r.Add(doctor), Times.Once);
        }

        // ✅ 2. Get All Doctors (Success)
        [Fact]
        public void GetAllDoctors_ShouldReturnDoctors()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Doctor> { GetDoctor() });

            var result = _service.GetAllDoctors();

            Assert.Single(result);
        }

        // ✅ 3. Get All Doctors (Exception)
        [Fact]
        public void GetAllDoctors_ShouldThrowException_WhenEmpty()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Doctor>());

            Assert.Throws<NoDoctorsRegisteredException>(() =>
                _service.GetAllDoctors());
        }

        // ✅ 4. Get Doctor By Id (Success)
        [Fact]
        public void GetDoctorById_ShouldReturnDoctor()
        {
            _mockRepo.Setup(r => r.GetById(1))
                     .Returns(GetDoctor());

            var result = _service.GetDoctorById(1);

            Assert.NotNull(result);
        }

        // ✅ 5. Get Doctor By Id (Exception)
        [Fact]
        public void GetDoctorById_ShouldThrowException_WhenNotFound()
        {
            _mockRepo.Setup(r => r.GetById(1))
                     .Returns((Doctor?)null);

            Assert.Throws<DoctorNotFoundException>(() =>
                _service.GetDoctorById(1));
        }

        // ✅ 6. Search By Specialisation (Success)
        [Fact]
        public void Search_ShouldReturnDoctors()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Doctor> { GetDoctor() });

            var result = _service.SearchBySpecialisation(SpecialisationType.Cardiologist);

            Assert.Single(result);
        }

        // ✅ 7. Search By Specialisation (Exception)
        [Fact]
        public void Search_ShouldThrowException_WhenNoMatch()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Doctor>());

            Assert.Throws<DoctorNotFoundException>(() =>
                _service.SearchBySpecialisation(SpecialisationType.Cardiologist));
        }





        // ✅ 12. Change Status (Success)
        [Fact]
        public void ChangeStatus_ShouldReturnMessage()
        {
            var doctor = GetDoctor();

            _mockRepo.Setup(r => r.ChangeDoctorStatus(1, false))
                     .Returns(doctor);

            var result = _service.ChangeDoctorStatus(1, false);

            Assert.Contains("Inactive", result);
        }

        // ✅ 13. Change Status (Exception)
        [Fact]
        public void ChangeStatus_ShouldThrowException_WhenNotFound()
        {
            _mockRepo.Setup(r => r.ChangeDoctorStatus(1, true))
                     .Returns((Doctor?)null);

            Assert.Throws<DoctorNotFoundException>(() =>
                _service.ChangeDoctorStatus(1, true));
        }
    }
}