
using Moq;
using POD1_NET_ConsoleApp.Exceptions;
using POD1_NET_ConsoleApp.Models;
using POD1_NET_ConsoleApp.Repository.Interfaces;
using POD1_NET_ConsoleApp.Services.Impl;
using System.Timers;

namespace POD1_NET_ConsoleAppTests
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

        [Fact]
        public void GetAllRecords_ReturnsAllRecords()
        {
            var records = new List<HealthRecords>
            {
                new HealthRecords { RecordId = 1, Patient = "John", Doctor = "Dr. Smith", VisitDate = DateTime.Now },
                new HealthRecords { RecordId = 2, Patient = "Ravi", Doctor = "Dr. Kumar", VisitDate = DateTime.Now }
            };

            _mockRepo.Setup(r => r.GetAllRecords()).Returns(records);

            var result = _service.GetAllRecords();

            Assert.NotNull(result);
            Assert.Equal(2, result.Count);

            _mockRepo.Verify(r => r.GetAllRecords(), Times.Once);
        }

        [Fact]
        public void GetRecordsByPatient_ReturnsRecords()
        {
            var records = new List<HealthRecords>
            {
                new HealthRecords { RecordId = 1, Patient = "John", Doctor = "Dr. Smith" },
                new HealthRecords { RecordId = 2, Patient = "John", Doctor = "Dr. Kumar" }
            };

            _mockRepo.Setup(r => r.GetRecordsByPatient("John")).Returns(records);

            var result = _service.GetRecordsByPatient("John");

            Assert.NotNull(result);
            Assert.Equal(2, result.Count);

            _mockRepo.Verify(r => r.GetRecordsByPatient("John"), Times.Once);
        }

        [Fact]
        public void GetRecordsByDoctor_ReturnsRecords()
        {
            var records = new List<HealthRecords>
            {
                new HealthRecords { RecordId = 1, Patient = "John", Doctor = "Dr. Smith" }
            };

            _mockRepo.Setup(r => r.GetRecordsByDoctor("Dr. Smith")).Returns(records);

            var result = _service.GetRecordsByDoctor("Dr. Smith");

            Assert.NotNull(result);
            Assert.Single(result);

            _mockRepo.Verify(r => r.GetRecordsByDoctor("Dr. Smith"), Times.Once);
        }

        [Fact]
        public void AddRecord_ShouldCallRepository()
        {
            var record = new HealthRecords { RecordId = 5, Patient = "Ravi", Doctor = "Dr. Kumar" };

            _service.AddRecord(record);

            _mockRepo.Verify(r => r.AddRecord(record), Times.Once);
        }

        [Fact]
        public void UpdateRecord_ShouldCallRepository()
        {
            var updated = new HealthRecords { Patient = "Updated", Doctor = "Dr. Smith" };

            _service.UpdateRecord(1, updated);

            _mockRepo.Verify(r => r.UpdateRecord(1, updated), Times.Once);
        }

        [Fact]
        public void GetRecordsByPatient_ShouldThrowException_WhenNotFound()
        {
            _mockRepo.Setup(r => r.GetRecordsByPatient("XYZ"))
                     .Returns(new List<HealthRecords>());

            Assert.Throws<RecordNotFoundException>(
                () => _service.GetRecordsByPatient("XYZ")
            );
        }

        [Fact]
        public void GetRecordsByDoctor_ShouldThrowException_WhenNotFound()
        {
            _mockRepo.Setup(r => r.GetRecordsByDoctor("Unknown"))
                     .Returns(new List<HealthRecords>());

            Assert.Throws<RecordNotFoundException>(
                () => _service.GetRecordsByDoctor("Unknown")
            );
        }
    }
}
