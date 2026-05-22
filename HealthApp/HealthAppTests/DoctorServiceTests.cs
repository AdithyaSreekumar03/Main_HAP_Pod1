using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace HealthAppTests
{
    public class DoctorServiceTests
    {
        private readonly Mock<IDoctorRepository> _mockRepo;
        private readonly DoctorService _doctorService;

        public DoctorServiceTests()
        {
            _mockRepo = new Mock<IDoctorRepository>();
            _doctorService = new DoctorService(_mockRepo.Object);
        }

        [Fact]
        public void GetAllDoctors_ReturnsAllDoctors()
        {
            // Arrange
            var doctors = new List<Doctor>
            {
                new Doctor
                {
                    DoctorId = 1,
                    FullName = "Dr. John Doe",
                    Specialisation = SpecialisationType.Cardiologist,
                    DoctorPhoneNo = "9876543210",
                    DoctorEmail = "john@example.com",
                    YearsOfExperience = 10,
                    ConsultationFee = 500
                },
                new Doctor
                {
                    DoctorId = 2,
                    FullName = "Dr. Jane Smith",
                    Specialisation = SpecialisationType.Dermatologist,
                    DoctorPhoneNo = "9123456780",
                    DoctorEmail = "jane@example.com",
                    YearsOfExperience = 7,
                    ConsultationFee = 700
                }
            };

            _mockRepo.Setup(r => r.GetAll()).Returns(doctors);

            // Act
            var result = _doctorService.GetAllDoctors();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);

            _mockRepo.Verify(r => r.GetAll(), Times.Once);
        }

        [Fact]
        public void GetDoctorById_ReturnsDoctor_WhenIdExists()
        {
            // Arrange
            var doctor = new Doctor
            {
                DoctorId = 1,
                FullName = "Dr. John Doe",
                Specialisation = SpecialisationType.Cardiologist,
                DoctorPhoneNo = "9876543210",
                DoctorEmail = "john@example.com",
                YearsOfExperience = 10,
                ConsultationFee = 500
            };

            _mockRepo.Setup(r => r.GetById(1)).Returns(doctor);


            var result = _doctorService.GetDoctorById(1);


            Assert.NotNull(result);
            Assert.Equal(1, result.DoctorId);

            _mockRepo.Verify(r => r.GetById(1), Times.Once);
        }

        [Fact]
        public void GetDoctorById_ReturnsNull_WhenIdNotFound()
        {

            _mockRepo.Setup(r => r.GetById(999)).Returns((Doctor)null);

            // Act
            var result = _doctorService.GetDoctorById(999);

            // Assert
            Assert.Null(result);

            _mockRepo.Verify(r => r.GetById(999), Times.Once);
        }

        [Fact]
        public void AddDoctor_ShouldAddDoctorSuccessfully()
        {
            // Arrange
            var doctor = new Doctor
            {
                FullName = "Dr. David",
                Specialisation = SpecialisationType.Neurologist,
                DoctorPhoneNo = "9876543210",
                DoctorEmail = "david@example.com",
                YearsOfExperience = 12,
                ConsultationFee = 1000
            };

            _mockRepo.Setup(r => r.GetAll()).Returns(new List<Doctor>());

            // Act
            _doctorService.AddDoctor(doctor);

            // Assert
            Assert.Equal(1, doctor.DoctorId);
            Assert.True(doctor.IsActive);

            _mockRepo.Verify(r => r.Add(doctor), Times.Once);
        }





        [Fact]
        public void SearchBySpecialisation_ReturnsMatchingDoctors()
        {
            // Arrange
            var doctors = new List<Doctor>
            {
                new Doctor
                {
                    DoctorId = 1,
                    FullName = "Dr. John",
                    Specialisation = SpecialisationType.Cardiologist,
                    DoctorPhoneNo = "9876543210",
                    DoctorEmail = "john@example.com"
                },
                new Doctor
                {
                    DoctorId = 2,
                    FullName = "Dr. Jane",
                    Specialisation = SpecialisationType.Dermatologist,
                    DoctorPhoneNo = "9123456780",
                    DoctorEmail = "jane@example.com"
                },
                new Doctor
                {
                    DoctorId = 3,
                    FullName = "Dr. Smith",
                    Specialisation = SpecialisationType.Cardiologist,
                    DoctorPhoneNo = "9988776655",
                    DoctorEmail = "smith@example.com"
                }
            };

            _mockRepo.Setup(r => r.GetAll()).Returns(doctors);

            // Act
            var result = _doctorService.SearchBySpecialisation(
                SpecialisationType.Cardiologist);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.All(result, d =>
                Assert.Equal(SpecialisationType.Cardiologist, d.Specialisation));

            _mockRepo.Verify(r => r.GetAll(), Times.Once);
        }
    }
}