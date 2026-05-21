using HealthApp.Database;
using HealthApp.Exceptions;
using HealthApp.Repositories.Interface;
using HealthApp.Models;
using HealthApp.Service;
using HealthApp.Service.Interface;


namespace HealthApp.Repositories.impl
{
    public class HealthRecordRepository : IHealthRecordRepository
    {
        private readonly HealthRecordsDB _db;

        public HealthRecordRepository(HealthRecordsDB db)
        {
            _db = db;
        }

        public void Add(HealthRecord record)
        {
            _db.HealthRecords.Add(record);
        }

        public void Update(int id, HealthRecord updated)
        {
            var record = _db.HealthRecords.FirstOrDefault(r => r.RecordId == id);

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

        public List<HealthRecord> GetAll()
        {
            return _db.HealthRecords.OrderByDescending(r => r.VisitDate).ToList();
           
        }

        public List<HealthRecord> GetByPatient(string patient)
        {
            return _db.HealthRecords.Where(r => r.Patient == patient).OrderByDescending(r => r.VisitDate).ToList();
        }

        public List<HealthRecord> GetByDoctor(string doctor)
        {
            return _db.HealthRecords.Where(r => r.Doctor == doctor).OrderByDescending(r => r.VisitDate).ToList();
        }
    }
}
