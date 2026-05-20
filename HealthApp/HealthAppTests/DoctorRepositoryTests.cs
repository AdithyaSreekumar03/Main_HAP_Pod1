using HealthApp.Databases;
using HealthApp.Exceptions;
using HealthApp.Models;
using HealthApp.Repository.Impl;

namespace HealthAppTests
{
    public class DoctorRepositoryTests
    {
        private DoctorDb _db;
        private DoctorRepository _repo;

        public DoctorRepositoryTests()
        {
            _db = new DoctorDb();
            _repo = new DoctorRepository(_db);
        }

        [Fact]
        public void Add_GivenDoctorData_AddToDoctorDb()
        {
            Doctor doctor = new Doctor
            {
                DoctorId = 5,
                FullName = "Dr. Kannan",
                Specialisation = "General Practitioner",
                YearsOfExperience = 10,
                ConsultationFee = 850,
                IsActive = true
            };
            var results = _repo.AddDoctor(doctor);
            Assert.NotNull(results);
            Assert.Equal("Doctor added successfully", results);
            var Doctor = _repo.GetAllDoctors();
            Assert.Equal(5, Doctor.Count());
            Assert.Equal("Dr. Kannan", Doctor[4].FullName);
        }

        [Fact]
        public void Delete_ProvidedValidDoctorId_DeleteDoctor()
        {
            var result = _repo.DeleteDoctor(3);
            Assert.NotNull(result);
            Assert.Equal("Doctor deleted successfully", result);
            var Doctor = _repo.GetAllDoctors();
            Assert.Equal(3, Doctor.Count());
        }

        [Fact]
        public void Delete_ProvidedInvalidDoctorId_ThrowsDoctorNotFoundException() 
        {
            Assert.Throws<DoctorNotFoundException>(() => _repo.DeleteDoctor(9));
        }

        [Fact]
        public void GetAllDoctors_WhenCalled_ReturnAllDoctors()
        {
            var Doctor = _repo.GetAllDoctors();
            Assert.NotNull(Doctor);
            Assert.False(Doctor[1].IsActive);
            Assert.Equal(1000, Doctor[2].ConsultationFee);
            Assert.Equal(6, Doctor[3].YearsOfExperience);
            Assert.Equal("Cardiologist", Doctor[0].Specialisation);
        }

        [Fact]
        public void GetAvailableDoctors_WhenDoctorIsActive_ReturnsOnlyAvailableDoctor()
        {
            var Doctor = _repo.GetAvailableDoctors();
            Assert.NotNull(Doctor);
            Assert.Equal(3, Doctor.Count());
            Assert.True(Doctor[1].IsActive);
        }

        [Fact]
        public void GetDoctorById_WhenIdIsGiven_ReturnDoctorDataOfThatId()
        {
            var Doctor = _repo.GetDoctorById(1);
            Assert.NotNull(Doctor);
            Assert.Equal("Dr. Vimal", Doctor.FullName);
            Assert.Equal(12, Doctor.YearsOfExperience);
            Assert.Throws<DoctorNotFoundException>(() => _repo.GetDoctorById(5));
        }
        [Fact]
        public void GetDoctorBySpecialization_ReturnsCorrectDoctor()
        {
            var result = _repo.GetDoctorsBySpecialisation("Cardiologist");

            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Equal("Dr. Vimal", result[0].FullName);
        }

        [Fact]

        public void GetDoctorScheduleSummary_ValidDoctor_ReturnsSummary()
        {
            var result = _repo.GetDoctorScheduleSummary(1);
            Assert.NotNull(result);
            Assert.Equal("Dr. Vimal has 3 upcoming Appointments", result);
        }

        [Fact]
        public void IsDoctorAvailable_ActiveWeekday_ReturnsTrue()
        {
            var doctor = new Doctor
            {
                FullName = "Dr. Vimal",
                IsActive = true
            };
            var date = new DateTime(2026, 5, 18);
            var result = doctor.IsAvailable(date);
            Assert.True(result);
        }


        [Fact]
        public void UpdateDoctor_ValidDoctor_UpdatesSuccessfully()
        {
            var updatedDoctor = new Doctor
            {
                FullName = "Dr. Updated",
                Specialisation = "Neurologist",
                YearsOfExperience = 10,
                ConsultationFee = 1200,
                IsActive = true
            };

            var result = _repo.UpdateDoctor(1, updatedDoctor);
            var doctor = _repo.GetDoctorById(1);
            Assert.Equal("Doctor updated successfully", result);
            Assert.Equal("Dr. Updated", doctor.FullName);
            Assert.Equal("Neurologist", doctor.Specialisation);
        }

        [Fact]
        public void GetDoctorScheduleSummary_DoctorNotFound_ThrowsException()
        {
            Assert.Throws<DoctorNotFoundException>(() =>
                _repo.GetDoctorScheduleSummary(9));
        }


        [Fact]
        public void UpdateDoctor_DoctorNotFound_ThrowsException()
        {
            var updatedDoctor = new Doctor { FullName = "Dr. Test" };
            Assert.Throws<DoctorNotFoundException>(() => _repo.UpdateDoctor(9, updatedDoctor));
        }
    }
}
