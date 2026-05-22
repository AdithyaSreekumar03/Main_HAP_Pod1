using HealthApp.Databases;
using HealthApp.Exceptions;
using HealthApp.Models;
using HealthApp.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAppTests
{
    public class DoctorRepositoryTests
    {
        private readonly DoctorDb _db;
        private readonly DoctorRepository _repo;

        public DoctorRepositoryTests()
        {
            _db = new DoctorDb();
            _repo = new DoctorRepository(_db);
        }

        [Fact]
        public void Add_Should_Add_Doctor()
        {
            var doctor = new Doctor
            {
                DoctorId = 5,
                FullName = "Dr. Smith"
            };

            _repo.Add(doctor);

            Assert.Equal(5,_db.doctors.Count);
            Assert.Equal("Dr. Smith", _db.doctors[4].FullName);
        }

        [Fact]
        public void GetAll_Should_Return_All_Doctors()
        {
            var result = _repo.GetAll();
            Assert.Equal(4, result.Count);
        }

        [Fact]
        public void GetById_Should_Return_Doctor_When_Exists()
        {
            var result = _repo.GetById(1);

            Assert.NotNull(result);
            Assert.Equal("Dr. Vimal", result.FullName);
        }

        [Fact]
        public void GetById_Should_Throw_Exception_When_NotFound()
        {
            Assert.Throws<DoctorNotFoundException>(() =>
                _repo.GetById(99));
        }

        [Fact]
        public void DeleteDoctor_Should_Remove_Doctor()
        {
            var result = _repo.DeleteDoctorById(1);

            Assert.Equal(3,_db.doctors.Count);
            Assert.Contains("successfully", result.ToLower());
        }

        [Fact]
        public void DeleteDoctor_Should_Throw_Exception_When_NotFound()
        {
            Assert.Throws<DoctorNotFoundException>(() =>
                _repo.DeleteDoctorById(100));
        }

        [Fact]
        public void UpdateDoctor_Should_Modify_Doctor()
        {
            var doctor = new Doctor
            {
                DoctorId = 1,
                FullName = "Old Name",
                Specialisation = SpecialisationType.GeneralPhysician,
                DoctorEmail = "old@mail.com",
                DoctorPhoneNo = "9999999999",
                YearsOfExperience = 5,
                ConsultationFee = 200
            };

            _repo.Add(doctor);

            var updatedDoctor = new Doctor
            {
                FullName = "New Name",
                Specialisation = SpecialisationType.Cardiologist,
                DoctorEmail = "new@mail.com",
                DoctorPhoneNo = "8888888888",
                YearsOfExperience = 10,
                ConsultationFee = 500
            };

            var result = _repo.UpdateDoctorById(1, updatedDoctor);

            Assert.Equal("New Name", _db.doctors[0].FullName);
            Assert.Equal(SpecialisationType.Cardiologist, _db.doctors[0].Specialisation);
        }

        [Fact]
        public void UpdateDoctor_Should_Throw_Exception_When_NotFound()
        {
            var updatedDoctor = new Doctor
            {
                FullName = "Test"
            };

            Assert.Throws<DoctorNotFoundException>(() =>
                _repo.UpdateDoctorById(99, updatedDoctor));
        }
    }
}
