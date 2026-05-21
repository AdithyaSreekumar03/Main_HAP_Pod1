using System;
using System.Collections.Generic;
using System.Text;
using HealthApp.Models;

namespace HealthApp.Repositories.Interface
{
    public interface IHealthRecordRepository
    {
        void Add(HealthRecord record);
        void Update(int id, HealthRecord record);
        List<HealthRecord> GetAll();
        List<HealthRecord> GetByPatient(string patient);
        List<HealthRecord> GetByDoctor(string doctor);
    }
}
