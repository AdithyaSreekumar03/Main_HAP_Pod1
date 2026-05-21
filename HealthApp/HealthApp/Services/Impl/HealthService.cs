using System.Collections.Generic;
using POD1_NET_ConsoleApp.Models;
using POD1_NET_ConsoleApp.Repository.Interfaces;
using POD1_NET_ConsoleApp.Services.Interfaces;
using POD1_NET_ConsoleApp.Exceptions;

namespace POD1_NET_ConsoleApp.Services.Impl
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
            if (record == null)
                throw new System.Exception("Record cannot be null");

            _repo.AddRecord(record);
        }

        public void UpdateRecord(int id, HealthRecords record)
        {
            if (record == null)
                throw new System.Exception("Update data cannot be null");

            _repo.UpdateRecord(id, record);
        }

        public List<HealthRecords> GetAllRecords()
        {
            var list = _repo.GetAllRecords();

            if (list.Count == 0)
                throw new RecordNotFoundException("No records available");

            return list;
        }

        public List<HealthRecords> GetRecordsByPatient(string patient)
        {
            var list = _repo.GetRecordsByPatient(patient);

            if (list.Count == 0)
                throw new RecordNotFoundException($"No records found for patient {patient}");

            return list;
        }

        public List<HealthRecords> GetRecordsByDoctor(string doctor)
        {
            var list = _repo.GetRecordsByDoctor(doctor);

            if (list.Count == 0)
                throw new RecordNotFoundException($"No records found for doctor {doctor}");

            return list;
        }
    }
}
