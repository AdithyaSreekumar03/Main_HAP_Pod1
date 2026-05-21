using System;
using System.Collections.Generic;
using System.Text;
using HealthApp.Models;

namespace HealthApp.Service.Interface
{
    public interface IHealthRecordService
    {
        void AddRecord(HealthRecord record);
        void UpdateRecord(int id, HealthRecord record);
        List<HealthRecord> GetAllRecords();
        List<HealthRecord> GetRecordsByPatient(string patient);
        List<HealthRecord> GetRecordsByDoctor(string doctor);
    }
}
