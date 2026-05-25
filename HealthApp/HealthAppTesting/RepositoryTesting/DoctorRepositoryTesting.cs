using HealthApp.Database;
using HealthApp.Model;
using HealthApp.Repository.Impl;
using Xunit;

namespace HealthApp.Tests
{
    public class DoctorRepositoryTests
    {
        // ✅ Create fresh repo every test
        private static DoctorRepository CreateRepo(out DoctorDb db)
        {
            db = new DoctorDb();
            db.Doctors = new System.Collections.Generic.List<Doctor>(); // ✅ reset
            return new DoctorRepository(db);
        }

        // ✅ 1. ADD
        [Fact]
        public void Add_ShouldAddDoctor()
        {
            var repo = CreateRepo(out var db);

            var doctor = new Doctor { DoctorId = 1 };

            repo.Add(doctor);

            Assert.Single(db.Doctors);
        }

        // ✅ 2. GET ALL
        [Fact]
        public void GetAll_ShouldReturnDoctors()
        {
            var repo = CreateRepo(out var db);

            db.Doctors.Add(new Doctor());

            var result = repo.GetAll();

            Assert.Single(result);
        }

        // ✅ 3. GET BY ID (FOUND)
        [Fact]
        public void GetById_ShouldReturnDoctor()
        {
            var repo = CreateRepo(out var db);

            var doctor = new Doctor { DoctorId = 1 };
            db.Doctors.Add(doctor);

            var result = repo.GetById(1);

            Assert.NotNull(result);
            Assert.Equal(1, result.DoctorId);
        }

        // ✅ 4. GET BY ID (NOT FOUND)
        [Fact]
        public void GetById_ShouldReturnNull_WhenNotFound()
        {
            var repo = CreateRepo(out var db);

            var result = repo.GetById(99);

            Assert.Null(result);
        }

   



        

        // ✅ 9. CHANGE STATUS SUCCESS
        [Fact]
        public void ChangeStatus_ShouldUpdateStatus()
        {
            var repo = CreateRepo(out var db);

            var doctor = new Doctor
            {
                DoctorId = 1,
                IsActive = true
            };

            db.Doctors.Add(doctor);

            var result = repo.ChangeDoctorStatus(1, false);

            Assert.NotNull(result);
            Assert.False(result.IsActive);
        }

        // ✅ 10. CHANGE STATUS NOT FOUND
        [Fact]
        public void ChangeStatus_ShouldReturnNull_WhenNotFound()
        {
            var repo = CreateRepo(out var db);

            var result = repo.ChangeDoctorStatus(1, true);

            Assert.Null(result);
        }
    }
}