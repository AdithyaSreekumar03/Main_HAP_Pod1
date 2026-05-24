using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Specialisation = SpecialisationType.Cardiologist
        };

        // ✅ 1. Add Doctor (when no doctors)
        [Fact]
        public void AddDoctor_ShouldAssignId1_WhenEmpty()
        {
            _mockRepo.Setup(r => r.GetAll()).Returns(new List<Doctor>());

            var doctor = GetDoctor();

            _service.AddDoctor(doctor);

            Assert.Equal(1, doctor.DoctorId);
            Assert.True(doctor.IsActive);
            _mockRepo.Verify(r => r.Add(doctor), Times.Once);
        }

        // ✅ 2. Add Doctor (existing doctors)
        [Fact]
        public void AddDoctor_ShouldAssignNextId()
        {
            _mockRepo.Setup(r => r.GetAll()).Returns(new List<Doctor>
            {
                new Doctor { DoctorId = 5 }
            });

            var doctor = GetDoctor();

            _service.AddDoctor(doctor);

            Assert.Equal(6, doctor.DoctorId);
        }

        // ✅ 3. GetAllDoctors (success)
        [Fact]
        public void GetAllDoctors_ShouldReturnDoctors()
        {
            var doctors = new List<Doctor>
            {
                new Doctor { DoctorId = 1 }
            };

            _mockRepo.Setup(r => r.GetAll()).Returns(doctors);

            var result = _service.GetAllDoctors();

            Assert.Single(result);
        }

        
        // ✅ 5. GetDoctorById
        [Fact]
        public void GetDoctorById_ShouldCallRepository()
        {
            var doctor = GetDoctor();

            _mockRepo.Setup(r => r.GetById(1)).Returns(doctor);

            var result = _service.GetDoctorById(1);

            Assert.NotNull(result);
            Assert.Equal(1, result.DoctorId);
        }

        // ✅ 6. Search by Specialisation
        [Fact]
        public void Search_ShouldReturnMatchingDoctors()
        {
            var doctors = new List<Doctor>
            {
                new Doctor { Specialisation = SpecialisationType.Cardiologist },
                new Doctor { Specialisation = SpecialisationType.Dermatologist }
            };

            _mockRepo.Setup(r => r.GetAll()).Returns(doctors);

            var result = _service.SearchBySpecialisation(SpecialisationType.Cardiologist);

            Assert.Single(result);
        }



        // ✅ 11. Change Status
        [Fact]
        public void ChangeStatus_ShouldReturnMessage()
        {
            _mockRepo.Setup(r => r.ChangeDoctorStatus(1, true))
                     .Returns("Active");

            var result = _service.ChangeDoctorStatus(1, true);

            Assert.Equal("Active", result);
        }

        // ✅ 12. Change Status Exception
        [Fact]
        public void ChangeStatus_ShouldThrowException()
        {
            _mockRepo.Setup(r => r.ChangeDoctorStatus(1, true))
                     .Throws(new DoctorNotFoundException("error"));

            Assert.Throws<DoctorNotFoundException>(() =>
                _service.ChangeDoctorStatus(1, true));
        }
    }
}