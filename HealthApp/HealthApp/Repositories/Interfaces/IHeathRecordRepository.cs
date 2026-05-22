using HealthApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Repository.Interface
{
    public interface IHealthRecordRepository
    {
        void Add(HealthRecord record);

        List<HealthRecord> GetAll();
    }
}