using System;
using System.Collections.Generic;
using System.Linq;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using Moq;
using Xunit;

namespace HealthApp.Tests
{
    public class HealthRecordServiceTests
    {
        private readonly Mock<IHealthRecordRepository> _repoMock;
        private readonly HealthRecordService _service;

        public HealthRecordServiceTests()
        {
            _repoMock = new Mock<IHealthRecordRepository>();
            _service = new HealthRecordService(_repoMock.Object);
        }

        private Patient GetPatient(int id) =>
            new Patient { PatientId = id, FullName = $"Patient{id}" };

        private Doctor GetDoctor() =>
            new Doctor { DoctorId = 1, FullName = "Dr Test" };



        // ✅ 1. AddRecord Should Add Record
        [Fact]
        public void AddRecord_Should_Add_Record()
        {
            _repoMock.Setup(r => r.GetAll()).Returns(new List<HealthRecord>());

            var record = new HealthRecord
            {
                Diagnosis = "Fever",
                Patient = GetPatient(1),
                Doctor = GetDoctor()
            };

            _service.AddRecord(record);

            _repoMock.Verify(r => r.Add(It.IsAny<HealthRecord>()), Times.Once);
        }



        // ✅ 2. AddRecord Should Assign ID
        [Fact]
        public void AddRecord_Should_Set_RecordId()
        {
            _repoMock.Setup(r => r.GetAll()).Returns(new List<HealthRecord>
            {
                new HealthRecord { RecordId = 1 }
            });

            var record = new HealthRecord();

            _service.AddRecord(record);

            Assert.Equal(2, record.RecordId);
        }



        // ✅ 3. GetPatientRecords Should Return Records
        [Fact]
        public void GetPatientRecords_Should_Return_Correct_Records()
        {
            var records = new List<HealthRecord>
            {
                new HealthRecord
                {
                    RecordId = 1,
                    Patient = GetPatient(1),
                    Doctor = GetDoctor(),
                    Diagnosis = "Cold"
                },
                new HealthRecord
                {
                    RecordId = 2,
                    Patient = GetPatient(2),
                    Doctor = GetDoctor(),
                    Diagnosis = "Fever"
                }
            };

            _repoMock.Setup(r => r.GetAll()).Returns(records);

            var result = _service.GetPatientRecords(1);

            Assert.Single(result);
            Assert.Equal("Cold", result[0].Diagnosis);
        }



        // ✅ 4. GetPatientRecords Empty Case
        [Fact]
        public void GetPatientRecords_Should_Return_Empty_When_No_Match()
        {
            _repoMock.Setup(r => r.GetAll()).Returns(new List<HealthRecord>());

            var result = _service.GetPatientRecords(99);

            Assert.Empty(result);
        }
    }
}