using System;
using System.Collections.Generic;
using System.Linq;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using HealthApp.Exceptions;
using Moq;
using Xunit;

namespace HealthApp.Tests
{
    public class DoctorServiceTests
    {
        private readonly Mock<IDoctorRepository> _repoMock;
        private readonly DoctorService _service;

        public DoctorServiceTests()
        {
            _repoMock = new Mock<IDoctorRepository>();
            _service = new DoctorService(_repoMock.Object);
        }

        private Doctor GetDoctor() =>
            new Doctor { DoctorId = 1, FullName = "Dr Test", IsActive = true };



        // ✅ 1. Add Doctor
        [Fact]
        public void AddDoctor_Should_Add_Doctor()
        {
            _repoMock.Setup(r => r.GetAll()).Returns(new List<Doctor>());

            var doctor = new Doctor { FullName = "New Doctor" };

            _service.AddDoctor(doctor);

            _repoMock.Verify(r => r.Add(It.IsAny<Doctor>()), Times.Once);
        }



        // ✅ 2. ID Assignment
        [Fact]
        public void AddDoctor_Should_Set_Id()
        {
            _repoMock.Setup(r => r.GetAll())
                .Returns(new List<Doctor>
                {
                    new Doctor { DoctorId = 1 }
                });

            var doctor = new Doctor();

            _service.AddDoctor(doctor);

            Assert.Equal(2, doctor.DoctorId);
        }



        // ✅ 3. IsActive default
        [Fact]
        public void AddDoctor_Should_Set_IsActive_True()
        {
            _repoMock.Setup(r => r.GetAll()).Returns(new List<Doctor>());

            var doctor = new Doctor();

            _service.AddDoctor(doctor);

            Assert.True(doctor.IsActive);
        }



        // ✅ 4. GetAllDoctors Success
        [Fact]
        public void GetAllDoctors_Should_Return_List()
        {
            _repoMock.Setup(r => r.GetAll())
                .Returns(new List<Doctor> { GetDoctor() });

            var result = _service.GetAllDoctors();

            Assert.Single(result);
        }


        // ✅ 6. GetDoctorById Success
        [Fact]
        public void GetDoctorById_Should_Return_Doctor()
        {
            _repoMock.Setup(r => r.GetById(1))
                     .Returns(GetDoctor());

            var result = _service.GetDoctorById(1);

            Assert.NotNull(result);
            Assert.Equal("Dr Test", result.FullName);
        }



        // ✅ 7. GetDoctorById Exception
        [Fact]
        public void GetDoctorById_Should_Throw_Exception()
        {
            _repoMock.Setup(r => r.GetById(1))
                     .Throws(new DoctorNotFoundException("Not found"));

            Assert.Throws<DoctorNotFoundException>(() =>
                _service.GetDoctorById(1));
        }



        // ✅ 8. Search by Specialisation
        [Fact]
        public void Search_Should_Return_Filtered_Doctors()
        {
            var doctors = new List<Doctor>
            {
                new Doctor { DoctorId = 1, Specialisation = SpecialisationType.Cardiologist },
                new Doctor { DoctorId = 2, Specialisation = SpecialisationType.Dermatologist }
            };

            _repoMock.Setup(r => r.GetAll()).Returns(doctors);

            var result = _service.SearchBySpecialisation(SpecialisationType.Cardiologist);

            Assert.Single(result);
            Assert.Equal(SpecialisationType.Cardiologist, result[0].Specialisation);
        }



        // ✅ 9. Delete Success
        [Fact]
        public void DeleteDoctor_Should_Call_Repository()
        {
            _repoMock.Setup(r => r.DeleteDoctorById(1))
                     .Returns("deleted");

            var result = _service.DeleteDoctorById(1);

            Assert.Equal("deleted", result);
        }



        // ✅ 10. Delete Exception
        [Fact]
        public void DeleteDoctor_Should_Throw_Exception()
        {
            _repoMock.Setup(r => r.DeleteDoctorById(1))
                     .Throws(new DoctorNotFoundException("Not found"));

            Assert.Throws<DoctorNotFoundException>(() =>
                _service.DeleteDoctorById(1));
        }



        // ✅ 11. Update Success
        [Fact]
        public void UpdateDoctor_Should_Call_Repository()
        {
            var updatedDoctor = new Doctor { FullName = "Updated" };

            _repoMock.Setup(r => r.UpdateDoctorById(1, updatedDoctor))
                     .Returns("updated");

            var result = _service.UpdateDoctorById(1, updatedDoctor);

            Assert.Equal("updated", result);
        }



        // ✅ 12. Update Exception
        [Fact]
        public void UpdateDoctor_Should_Throw_Exception()
        {
            var updatedDoctor = new Doctor();

            _repoMock.Setup(r => r.UpdateDoctorById(1, updatedDoctor))
                     .Throws(new DoctorNotFoundException("Not found"));

            Assert.Throws<DoctorNotFoundException>(() =>
                _service.UpdateDoctorById(1, updatedDoctor));
        }
    }
}
