using HealthApp.Model;
using System.Collections.Generic;

namespace HealthApp.Service.Interface
{
    public interface IHealthRecordService
    {
        void AddRecord(HealthRecord record);

        List<HealthRecord> GetPatientRecords(int patientId);

        List<HealthRecord> GetHealthRecordsByDoctor(
            int doctorId,
            int patientId);
    }
}
