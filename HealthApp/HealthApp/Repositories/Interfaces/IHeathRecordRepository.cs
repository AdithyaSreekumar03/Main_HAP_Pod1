using System.Collections.Generic;
using POD1_NET_ConsoleApp.Models;

namespace POD1_NET_ConsoleApp.Repository.Interfaces
{
    public interface IHealthRecordRepository
    {
        void AddRecord(HealthRecords record);
        void UpdateRecord(int id, HealthRecords record);

        List<HealthRecords> GetAllRecords();

        List<HealthRecords> GetRecordsByPatient(string patient);
        List<HealthRecords> GetRecordsByDoctor(string doctor);
    }
}
