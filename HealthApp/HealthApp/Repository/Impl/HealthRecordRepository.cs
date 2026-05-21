using HealthApp.Databases;
using HealthApp.Models;
using HealthApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Repository.Impl
{
    public class HealthRecordRepository : IHealthRecordRepository
    {
        private readonly HealthRecordDb _healthRecordDb;
        public HealthRecordRepository(HealthRecordDb healthRecordDb)
        {
            _healthRecordDb = healthRecordDb;
        }
        public void Add(HealthRecord record)
        {
            _healthRecordDb.Records.Add(record);
        }
        public List<HealthRecord> GetAll()
        {
            return _healthRecordDb.Records;
        }
    }
}
