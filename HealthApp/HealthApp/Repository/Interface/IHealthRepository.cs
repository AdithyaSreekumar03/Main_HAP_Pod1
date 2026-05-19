using HealthApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Repository.Interface
{
    public interface IHealthRecordRepository
    {
        void Add(HealthRecords record);
        void Update(int id, HealthRecords record);
        List<HealthRecords> GetAll();
        List<HealthRecords> GetByPatient(string patient);
        List<HealthRecords> GetByDoctor(string doctor);
    }
}
