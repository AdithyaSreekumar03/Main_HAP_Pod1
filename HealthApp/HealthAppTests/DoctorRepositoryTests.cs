using HealthApp.Database;
using HealthApp.Exceptions;
using HealthApp.Model;
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
            // ✅ Arrange
            _db = new DoctorDb();
            _repo = new DoctorRepository(_db);
        }

        // ✅ TEST 1: Add Doctor
        [Fact]
        public void Add_Should_Add_Doctor()
        {
            var doctor = new Doctor
            {
                DoctorId = 1,
                FullName = "Dr. Smith"
            };

            _repo.Add(doctor);

            Assert.Single(_db.Doctors);
            Assert.Equal("Dr. Smith", _db.Doctors[0].FullName);
        }

        // ✅ TEST 2: GetAll Doctors
        [Fact]
        public void GetAll_Should_Return_All_Doctors()
        {
            _repo.Add(new Doctor { DoctorId = 1, FullName = "A" });
            _repo.Add(new Doctor { DoctorId = 2, FullName = "B" });

            var result = _repo.GetAll();

            Assert.Equal(2, result.Count);
        }

        // ✅ TEST 3: GetById Success
        [Fact]
        public void GetById_Should_Return_Doctor_When_Exists()
        {
            var doctor = new Doctor
            {
                DoctorId = 1,
                FullName = "Test Doctor"
            };

            _repo.Add(doctor);

            var result = _repo.GetById(1);

            Assert.NotNull(result);
            Assert.Equal("Test Doctor", result.FullName);
        }

        // ✅ TEST 4: GetById Not Found (Exception)
        [Fact]
        public void GetById_Should_Throw_Exception_When_NotFound()
        {
            Assert.Throws<DoctorNotFoundException>(() =>
                _repo.GetById(99));
        }

        // ✅ TEST 5: Delete Doctor Success
        [Fact]
        public void DeleteDoctor_Should_Remove_Doctor()
        {
            var doctor = new Doctor
            {
                DoctorId = 1,
                FullName = "Test"
            };

            _repo.Add(doctor);

            var result = _repo.DeleteDoctorById(1);

            Assert.Empty(_db.Doctors);
            Assert.Contains("deleted", result.ToLower());
        }

        // ✅ TEST 6: Delete Doctor Not Found
        [Fact]
        public void DeleteDoctor_Should_Throw_Exception_When_NotFound()
        {
            Assert.Throws<DoctorNotFoundException>(() =>
                _repo.DeleteDoctorById(100));
        }

        // ✅ TEST 7: Update Doctor Success
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

            Assert.Equal("New Name", _db.Doctors[0].FullName);
            Assert.Equal(SpecialisationType.Cardiologist, _db.Doctors[0].Specialisation);
        }

        // ✅ TEST 8: Update Doctor Not Found
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
