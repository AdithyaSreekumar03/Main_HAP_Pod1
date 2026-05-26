using HealthApp.Model;
using System.Collections.Generic;

namespace HealthApp.Repository.Interface
{
    public interface IHealthRecordRepository
    {
        void Add(HealthRecord record);

        List<HealthRecord> GetAll();
    }
}
