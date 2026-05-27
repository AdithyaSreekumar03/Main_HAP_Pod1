using HealthApp.Database;
using HealthApp.Model;
using HealthApp.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAppTests.RepositoryTesting
{
    public class HealthRecordRepositoryTests
    {
        private readonly HealthRecordDb _db;
        private readonly HealthRecordRepository _repo;

        public HealthRecordRepositoryTests()
        {
            _db = new HealthRecordDb();
            _db.Records.Clear();
            _repo = new HealthRecordRepository(_db);
        }

        [Fact]
        public void Add_ShouldAddHealthRecord()
        {
            int before = _db.Records.Count;

            var record = new HealthRecord
            {
                Diagnosis = "Flu"
            };

            _repo.Add(record);

            Assert.Equal(before + 1, _db.Records.Count);
        }

        [Fact]
        public void Add_ShouldHandleMultipleRecords()
        {
            _repo.Add(new HealthRecord());
            _repo.Add(new HealthRecord());

            Assert.Equal(2, _db.Records.Count);
        }

        [Fact]
        public void GetAll_ShouldReturnAllRecords()
        {
            _db.Records.Add(new HealthRecord());
            _db.Records.Add(new HealthRecord());

            var result = _repo.GetAll();

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void GetAll_ShouldReturnEmptyList_WhenNoRecords()
        {
            var result = _repo.GetAll();

            Assert.Empty(result);
        }
    }
}