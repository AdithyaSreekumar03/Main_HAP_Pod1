using HealthApp.Databases;
using HealthApp.Models;
using HealthApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Repository.Impl
{
    public class HealthRecordRepository : IHealthRecordRepository
    {
        private readonly HealthRecordDb _db;

        public HealthRecordRepository(HealthRecordDb db)
        {
            _db = db;
        }

        public void Add(HealthRecords record)
        {
            _db.Records.Add(record);
        }

        public void Update(int id, HealthRecords updated)
        {
            var record = _db.Records.FirstOrDefault(r => r.RecordId == id);

            if (record != null)
            {
                record.Patient = updated.Patient;
                record.Doctor = updated.Doctor;
                record.VisitDate = updated.VisitDate;
                record.Diagnosis = updated.Diagnosis;
                record.Prescription = updated.Prescription;
                record.Notes = updated.Notes;
            }
        }

        public List<HealthRecords> GetAll()
        {
            return _db.Records
                .OrderByDescending(r => r.VisitDate)
                .ToList();
        }

        public List<HealthRecords> GetByPatient(string patient)
        {
            return _db.Records
                .Where(r => r.Patient == patient)
                .OrderByDescending(r => r.VisitDate)
                .ToList();
        }

        public List<HealthRecords> GetByDoctor(string doctor)
        {
            return _db.Records
                .Where(r => r.Doctor == doctor)
                .OrderByDescending(r => r.VisitDate)
                .ToList();
        }
    }
}
