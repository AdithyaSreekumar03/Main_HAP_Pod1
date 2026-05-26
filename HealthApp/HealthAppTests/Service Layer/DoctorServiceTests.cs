using HealthApp.Databases;
using HealthApp.Exceptions;
using HealthApp.Models;
using HealthApp.Repository.Impl;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAppTests.Service_Layer
{
    public class DoctorServiceTests
    {
        private readonly Mock<IDoctorRepository> _mockRepo;
        private readonly DoctorService _service;

        public DoctorServiceTests()
        {
            _mockRepo = new Mock<IDoctorRepository>();
            _service = new DoctorService(_mockRepo.Object);
        }

        // ✅ Helper
        private static Doctor GetDoctor() => new Doctor
        {
            DoctorId = 1,
            FullName = "Test Doctor",
            Specialisation = SpecialisationType.Cardiologist,
            IsActive = true
        };

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

        [Fact]
        public void GetAllDoctors_ShouldReturnDoctors()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Doctor> { GetDoctor() });

            var result = _service.GetAllDoctors();

            Assert.Single(result);
        }

        [Fact]
        public void GetAllDoctors_ShouldThrowException_WhenEmpty()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Doctor>());

            Assert.Throws<NoDoctorsRegisteredException>(() =>
                _service.GetAllDoctors());
        }

        [Fact]
        public void GetDoctorById_ShouldReturnDoctor()
        {
            _mockRepo.Setup(r => r.GetById(1))
                     .Returns(GetDoctor());

            var result = _service.GetDoctorById(1);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetDoctorById_ShouldThrowException_WhenNotFound()
        {
            _mockRepo.Setup(r => r.GetById(1))
                     .Returns((Doctor?)null);

            Assert.Throws<DoctorNotFoundException>(() =>
                _service.GetDoctorById(1));
        }

        [Fact]
        public void Search_ShouldReturnDoctors()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Doctor> { GetDoctor() });

            var result = _service.SearchBySpecialisation(SpecialisationType.Cardiologist);

            Assert.Single(result);
        }

        [Fact]
        public void Search_ShouldThrowException_WhenNoMatch()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<Doctor>());

            Assert.Throws<DoctorNotFoundException>(() =>
                _service.SearchBySpecialisation(SpecialisationType.Cardiologist));
        }

        [Fact]
        public void ChangeStatus_ShouldReturnMessage()
        {
            var doctor = GetDoctor();

            _mockRepo.Setup(r => r.ChangeDoctorStatus(1, false))
                     .Returns(doctor);

            var result = _service.ChangeDoctorStatus(1, false);

            Assert.Contains("Inactive", result);
        }

        [Fact]
        public void ChangeStatus_ShouldThrowException_WhenNotFound()
        {
            _mockRepo.Setup(r => r.ChangeDoctorStatus(1, true))
                     .Returns((Doctor?)null);

            Assert.Throws<DoctorNotFoundException>(() => _service.ChangeDoctorStatus(1, true));
        }
    }
}
