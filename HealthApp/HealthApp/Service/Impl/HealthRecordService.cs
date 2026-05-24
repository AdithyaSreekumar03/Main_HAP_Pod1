using HealthApp.Models;
using HealthApp.Repository.Interface;
using HealthApp.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Service.Impl
{
    public class HealthRecordService
      : IHealthRecordService
    {
        private readonly IHealthRecordRepository
            _repo;

        public HealthRecordService(
            IHealthRecordRepository repo)
        {
            _repo = repo;
        }

        public void AddRecord(HealthRecord record)
        {
            record.RecordId =
                _repo.GetAll().Count + 1;

            _repo.Add(record);
        }

        public List<HealthRecord>
            GetPatientRecords(int patientId)
        {
            var result = _repo.GetAll()
                .Where(r =>
                    r.Patient.PatientId ==
                    patientId)
                .ToList();
            if (!result.Any())
            {
                throw new Exception($"There are no health records of the patient with id {patientId}");
            }
            return result;
        }

        public List<HealthRecord>
    GetHealthRecordsByDoctor(
        int doctorId,
        int patientId)
        {
            var result = _repo.GetAll()
                .Where(r =>
                    r.Doctor.DoctorId == doctorId
                    &&
                    r.Patient.PatientId == patientId)
                .OrderByDescending(r => r.VisitDate)
                .ToList();

            if (!result.Any())
            {

                throw new Exception($"There are no health records involving patient with id {patientId} and doctor with doctor id {doctorId}");

            }
            return result;
        }
    }
}