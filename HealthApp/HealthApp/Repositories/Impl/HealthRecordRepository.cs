using System.Linq;
using System.Collections.Generic;
using POD1_NET_ConsoleApp.Models;
using POD1_NET_ConsoleApp.Database;
using POD1_NET_ConsoleApp.Repository.Interfaces;
using POD1_NET_ConsoleApp.Exceptions;

namespace POD1_NET_ConsoleApp.Repository.Impl
{
    public class HealthRecordRepository : IHealthRecordRepository
    {
        private readonly HealthRecordDb _db;

        public HealthRecordRepository(HealthRecordDb db)
        {
            _db = db;
        }

        public void AddRecord(HealthRecords record)
        {
            if (record == null)
                throw new System.Exception("Record cannot be null");

            _db.Records.Add(record);
        }

        public void UpdateRecord(int id, HealthRecords updated)
        {
            var record = _db.Records.FirstOrDefault(r => r.RecordId == id);

            if (record == null)
                throw new RecordNotFoundException($"Record with ID {id} not found");

            record.Patient = updated.Patient;
            record.Doctor = updated.Doctor;
            record.VisitDate = updated.VisitDate;
            record.Diagnosis = updated.Diagnosis;
            record.Prescription = updated.Prescription;
            record.Notes = updated.Notes;
        }

        public List<HealthRecords> GetAllRecords()
        {
            if (_db.Records.Count == 0)
                throw new RecordNotFoundException("No records available");

            return _db.Records
                .OrderByDescending(r => r.VisitDate)
                .ToList();
        }

        public List<HealthRecords> GetRecordsByPatient(string patient)
        {
            var list = _db.Records
                .Where(r => r.Patient == patient)
                .OrderByDescending(r => r.VisitDate)
                .ToList();

            if (list.Count == 0)
                throw new RecordNotFoundException($"No records found for patient {patient}");

            return list;
        }

        public List<HealthRecords> GetRecordsByDoctor(string doctor)
        {
            var list = _db.Records
                .Where(r => r.Doctor == doctor)
                .OrderByDescending(r => r.VisitDate)
                .ToList();

            if (list.Count == 0)
                throw new RecordNotFoundException($"No records found for doctor {doctor}");

            return list;
        }
    }
}
