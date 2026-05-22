using HealthApp.Database;
using HealthApp.Model;
using HealthApp.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Numerics;
using Xunit;

namespace HealthAppTesting.RepositoryTesting
{
    public class HealthRecordRepositoryTests
    {
        private readonly HealthRecordDb _db;
        private readonly HealthRecordRepository _repo;

        public HealthRecordRepositoryTests()
        {
            _db = new HealthRecordDb();
            _repo = new HealthRecordRepository(_db);
        }

        [Fact]
        public void Add_Should_Add_Record_To_List()
        {
            // Arrange
            var record = new HealthRecord
            {
                RecordId = 1,
                Diagnosis = "Fever",
                Prescription = "Paracetamol",
                Notes = "Take rest",
                Patient = new Patient
                {
                    PatientId = 1,
                    FullName = "Rishab"
                },
                Doctor = new Doctor
                {
                    DoctorId = 1,
                    FullName = "Dr. Smith"
                },
                VisitDate = DateTime.Now
            };

            // Act
            _repo.Add(record);

            // Assert
            Assert.Single(_db.Records);
            Assert.Equal("Fever", _db.Records[0].Diagnosis);
            Assert.Equal("Rishab", _db.Records[0].Patient.FullName);
        }

        [Fact]
        public void GetAll_Should_Return_All_Records()
        {
            // Arrange
            var record1 = new HealthRecord
            {
                RecordId = 1,
                Diagnosis = "Cold",
                Patient = new Patient { PatientId = 1, FullName = "A" },
                Doctor = new Doctor { DoctorId = 1, FullName = "Dr. A" }
            };

            var record2 = new HealthRecord
            {
                RecordId = 2,
                Diagnosis = "Fever",
                Patient = new Patient { PatientId = 2, FullName = "B" },
                Doctor = new Doctor { DoctorId = 2, FullName = "Dr. B" }
            };

            _repo.Add(record1);
            _repo.Add(record2);

            // Act
            var result = _repo.GetAll();

            // Assert
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void GetAll_Should_Return_Empty_When_No_Records()
        {
            // Act
            var result = _repo.GetAll();

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Add_Multiple_Records_Should_Store_Correctly()
        {
            // Arrange
            var record1 = new HealthRecord
            {
                RecordId = 1,
                Diagnosis = "Headache",
                Patient = new Patient { PatientId = 1, FullName = "X" },
                Doctor = new Doctor { DoctorId = 1, FullName = "Dr. X" }
            };

            var record2 = new HealthRecord
            {
                RecordId = 2,
                Diagnosis = "Back Pain",
                Patient = new Patient { PatientId = 2, FullName = "Y" },
                Doctor = new Doctor { DoctorId = 2, FullName = "Dr. Y" }
            };

            // Act
            _repo.Add(record1);
            _repo.Add(record2);

            // Assert
            Assert.Equal("Headache", _db.Records[0].Diagnosis);
            Assert.Equal("Back Pain", _db.Records[1].Diagnosis);
        }
    }
}
