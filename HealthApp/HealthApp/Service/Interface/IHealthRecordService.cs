using HealthApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Service.Interface
{
    public interface IHealthRecordService
    {
        void AddRecord(HealthRecords record);
        void UpdateRecord(int id, HealthRecords record);

        List<HealthRecords> GetAllRecords();

        List<HealthRecords> GetRecordsByPatient(string patient);
        List<HealthRecords> GetRecordsByDoctor(string doctor);
    }
}
