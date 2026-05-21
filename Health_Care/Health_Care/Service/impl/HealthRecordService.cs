using HealthApp.Database;
using HealthApp.Models;
using HealthApp.Modules;
using HealthApp.Repositories.Interface;
using HealthApp.Service;
using HealthApp.Service.Interface;
using System.Collections.Generic;


namespace HealthApp.Service.impl
{
    public class HealthRecordService: IHealthRecordService
    {
        private readonly IHealthRecordRepository _repo;
        int currentId;
        public HealthRecordService(IHealthRecordRepository repo)
        {
            _repo = repo;
        }

        public void AddRecord(HealthRecord record)
        {

            record.RecordId = currentId++;
            _repo.Add(record);
        }

        public void UpdateRecord(int id, HealthRecord record)
        {
            _repo.Update(id, record);
        }

        public List<HealthRecord> GetAllRecords()
        {
            return _repo.GetAll();
        }

        public List<HealthRecord> GetRecordsByPatient(string patient)
        {
            var list = _repo.GetByPatient(patient);

            if (list.Count == 0)
                throw new Exception("No records found for patient");

            return list;
        }

        public List<HealthRecord> GetRecordsByDoctor(string doctor)
        {
            var list = _repo.GetByDoctor(doctor);

            if (list.Count == 0)
                throw new Exception("No records found for doctor");

            return list;
        }
    }
}