using HealthApp.Database;
using HealthApp.Model;
using HealthApp.Repository.Impl;
using System.Numerics;
using Xunit;

namespace HealthApp.Tests
{
    public class DoctorRepositoryTests
    {
        private readonly DoctorDb _db;

        private readonly DoctorRepository _repo;


        public DoctorRepositoryTests()

        {

            _db = new DoctorDb();

            _db.Doctors.Clear();

            _repo = new DoctorRepository(_db);

        }


        // ✅ 1. ADD
        [Fact]

        public void Add_ShouldAddDoctor()

        {

            var doctor = new Doctor { DoctorId = 1 };


            _repo.Add(doctor);


            Assert.Single(_db.Doctors);

        }


        // ✅ 2. GET ALL (WITH DATA)
        [Fact]

        public void GetAll_ShouldReturnDoctors()

        {

            _db.Doctors.Add(new Doctor());


            var result = _repo.GetAll();


            Assert.Single(result);

        }


        // ✅ 3. GET ALL (EMPTY) ✅ IMPORTANT
        [Fact]

        public void GetAll_ShouldReturnEmpty_WhenNoDoctors()

        {

            var result = _repo.GetAll();


            Assert.Empty(result);

        }


        // ✅ 4. GET BY ID (FOUND)
        [Fact]

        public void GetById_ShouldReturnDoctor()

        {
            var doctor = new Doctor { DoctorId = 1 };

            _db.Doctors.Add(doctor);


            var result = _repo.GetById(1);


            Assert.NotNull(result);

            Assert.Equal(1, result.DoctorId);

        }// ✅ 5. GET BY ID (NOT FOUND) ✅ IMPORTANT
         [Fact]
        public void GetById_ShouldReturnNull_WhenNotFound(){var result = _repo.GetById(999);


        Assert.Null(result);

        }// ✅ 6. CHANGE STATUS (SUCCESS)
         [Fact]
        public void ChangeDoctorStatus_ShouldUpdateStatus(){var doctor = new Doctor{                DoctorId = 1,

    IsActive = true};


_db.Doctors.Add(doctor);


var result = _repo.ChangeDoctorStatus(1, false);


// ✅ Strong assertions
Assert.NotNull(result);

Assert.False(result.IsActive);


            // ✅ ADD THIS (KEY FIX)
            Assert.False(_db.Doctors[0].IsActive);

        }// ✅ 7. CHANGE STATUS (NOT FOUND) ✅ IMPORTANT (else branch)
         [Fact]
        public void ChangeDoctorStatus_ShouldReturnNull_WhenNotFound(){var result = _repo.ChangeDoctorStatus(999, true);


            Assert.Null(result);

        }}}