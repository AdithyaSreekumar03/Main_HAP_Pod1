using HealthApp.Database;
using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Impl;
using System;
using Xunit;

namespace HealthAppTests.RepositoryTesting
{
    public class DoctorRepositoryTesting
    {
        private readonly DoctorDb _db;
        private readonly DoctorRepository _repo;

        public DoctorRepositoryTesting()
        {
            _db = new DoctorDb();
            _db.Doctors.Clear(); 
            _repo = new DoctorRepository(_db);
        }
        [Fact]
        public void GetById_ShouldReturnNull_WhenNotFound()
        {
            var result = _repo.GetById(999);

            Assert.Null(result);
        }

        [Fact]
        public void Delete_ShouldReturnNull_WhenNotFound()
        {
            var result = _repo.DeleteDoctorById(999);

            Assert.Null(result);
        }
    }
}