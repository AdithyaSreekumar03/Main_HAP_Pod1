using POD1_NET_ConsoleApp.Database;
using POD1_NET_ConsoleApp.Models;
using POD1_NET_ConsoleApp.Repository.Impl;
using Xunit;

namespace POD1_NET_ConsoleAppTests
{
    public class HealthRecordRepositoryTests
    {
        [Fact]
        public void GetAllRecords_ShouldReturnAllRecords()
        {
            var db = new HealthRecordDb();
            var repo = new HealthRecordRepository(db);

            var records = repo.GetAllRecords();

            Assert.NotNull(records);
            Assert.Equal(4, records.Count());
        }

        [Fact]
        public void GetRecordsByPatient_ShouldReturnSingleRecord()
        {
            var db = new HealthRecordDb();
            var repo = new HealthRecordRepository(db);

            var records = repo.GetRecordsByPatient("Anita");

            Assert.NotNull(records);
            Assert.Single(records);

            Assert.Equal("Anita", records.First().Patient);
        }

        [Fact]
        public void GetRecordsByDoctor_ShouldReturnAllPatientsSortedDescending()
        {
            var db = new HealthRecordDb();
            var repo = new HealthRecordRepository(db);

            var records = repo.GetRecordsByDoctor("Dr. Smith");

            Assert.NotNull(records);
            Assert.Equal(2, records.Count());

            Assert.True(records.First().VisitDate >= records.Last().VisitDate);
        }

        [Fact]
        public void AddRecord_ShouldIncreaseCount()
        {
            var db = new HealthRecordDb();
            var repo = new HealthRecordRepository(db);

            var newRecord = new HealthRecords
            {
                RecordId = 5,
                Patient = "Meena",
                Doctor = "Dr. Kumar",
                VisitDate = new System.DateTime(2026, 7, 20),
                Diagnosis = "Cough",
                Prescription = "Syrup",
                Notes = "Rest"
            };

            repo.AddRecord(newRecord);

            Assert.Equal(5, repo.GetAllRecords().Count());
        }

        [Fact]
        public void UpdateRecord_ShouldModifyData()
        {
            var db = new HealthRecordDb();
            var repo = new HealthRecordRepository(db);

            var updated = new HealthRecords
            {
                Patient = "John Updated",
                Doctor = "Dr. Smith",
                VisitDate = new System.DateTime(2026, 8, 1),
                Diagnosis = "Updated",
                Prescription = "Updated",
                Notes = "Updated"
            };

            repo.UpdateRecord(1, updated);

            var record = repo.GetAllRecords().First(r => r.RecordId == 1);

            Assert.Equal("John Updated", record.Patient);
        }
    }
}