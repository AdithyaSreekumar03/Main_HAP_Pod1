using HealthApp.Databases;
using HealthApp.Exceptions;
using HealthApp.Models;
using HealthApp.Repository.Impl;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAppTests.Service_Layer
{
    public class HealthRecordServiceTests
    {
        private readonly Mock<IHealthRecordRepository> _mockRepo;
        private readonly HealthRecordService _service;

        public HealthRecordServiceTests()
        {
            _mockRepo = new Mock<IHealthRecordRepository>();
            _service = new HealthRecordService(_mockRepo.Object);
        }

        // ✅ Helper
        private static HealthRecord GetRecord(int patientId = 1, int doctorId = 1)
        {
            return new HealthRecord
            {
                RecordId = 1,
                Patient = new Patient { PatientId = patientId },
                Doctor = new Doctor { DoctorId = doctorId },
                VisitDate = DateTime.Now
            };
        }

        // ✅ 1. ADD RECORD
        [Fact]
        public void AddRecord_ShouldAssignIdAndAdd()
        {
            _mockRepo.Setup(r => r.GetAll()).Returns(new List<HealthRecord>());

            var record = GetRecord();

            _service.AddRecord(record);

            Assert.Equal(1, record.RecordId);
            _mockRepo.Verify(r => r.Add(record), Times.Once);
        }

        [Fact]
        public void GetPatientRecords_ShouldReturnMatchingRecords()
        {
            var records = new List<HealthRecord>
        {
            GetRecord(1),
            GetRecord(2),
            GetRecord(1)
        };

            _mockRepo.Setup(r => r.GetAll()).Returns(records);

            var result = _service.GetPatientRecords(1);

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void GetPatientRecords_ShouldThrowException_WhenNoMatch()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<HealthRecord>());

            Assert.Throws<NoHealthRecordAvailableException>(() =>
                _service.GetPatientRecords(1));
        }

        [Fact]
        public void GetHealthRecordsByDoctor_ShouldReturnFilteredRecords()
        {
            var records = new List<HealthRecord>
        {
            GetRecord(1, 1),
            GetRecord(1, 2),
            GetRecord(1, 1)
        };

            _mockRepo.Setup(r => r.GetAll()).Returns(records);

            var result = _service.GetHealthRecordsByDoctor(1, 1);

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void GetHealthRecordsByDoctor_ShouldBeSortedDescending()
        {
            var r1 = GetRecord(1, 1);
            r1.VisitDate = DateTime.Now;

            var r2 = GetRecord(1, 1);
            r2.VisitDate = DateTime.Now.AddDays(-1);

            var r3 = GetRecord(1, 1);
            r3.VisitDate = DateTime.Now.AddDays(-2);

            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<HealthRecord> { r3, r2, r1 });

            var result = _service.GetHealthRecordsByDoctor(1, 1);

            Assert.Equal(3, result.Count);

            Assert.True(result[0].VisitDate >= result[1].VisitDate);
            Assert.True(result[1].VisitDate >= result[2].VisitDate);
        }


        [Fact]
        public void GetHealthRecordsByDoctor_ShouldThrowException_WhenNoRecordsFound()
        {
            _mockRepo.Setup(r => r.GetAll())
                     .Returns(new List<HealthRecord>());

            Assert.Throws<NoHealthRecordAvailableException>(() =>
                _service.GetHealthRecordsByDoctor(1, 1));
        }

    }
}

