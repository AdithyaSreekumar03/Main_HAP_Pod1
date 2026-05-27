using HealthApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Service.Interface
{
    public interface IHealthRecordService
    {
        void AddRecord(HealthRecord record);

        List<HealthRecord> GetPatientRecords(
            int patientId);

        List<HealthRecord> GetHealthRecordsByDoctor(int doctorId, int patientId);
    }
}
