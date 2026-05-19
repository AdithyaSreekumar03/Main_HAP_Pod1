using HealthApp.Models;
using HealthApp.Repository.Interface;
using HealthApp.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Service.Impl
{
    public class HealthRecordService : IHealthRecordService
    {
        private readonly IHealthRecordRepository _repo;

        public HealthRecordService(IHealthRecordRepository repo)
        {
            _repo = repo;
        }

        public void AddRecord(HealthRecords record)
        {
            _repo.Add(record);
        }

        public void UpdateRecord(int id, HealthRecords record)
        {
            _repo.Update(id, record);
        }

        public List<HealthRecords> GetAllRecords()
        {
            return _repo.GetAll();
        }

        public List<HealthRecords> GetRecordsByPatient(string patient)
        {
            var list = _repo.GetByPatient(patient);

            if (list.Count == 0)
                throw new Exception("No records found for patient");

            return list;
        }

        public List<HealthRecords> GetRecordsByDoctor(string doctor)
        {
            var list = _repo.GetByDoctor(doctor);

            if (list.Count == 0)
                throw new Exception("No records found for doctor");

            return list;
        }
    }
}
