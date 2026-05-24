using HealthApp.Database;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace HealthApp.Repository.Impl
{
    public class PatientRepository : IPatientRepository
    {
        private readonly PatientDb _patientDb;

        public PatientRepository(PatientDb patientDb)
        {
            _patientDb = patientDb;
        }

        public void Add(Patient patient)
        {
            _patientDb.Patients.Add(patient);
        }

        public List<Patient> GetAll()
        {
            return _patientDb.Patients;
        }

        public Patient? GetById(int id)
        {
            return _patientDb.Patients
                .FirstOrDefault(p => p.PatientId == id);
        }

        public Patient? DeletePatient(int id)
        {
            var patient = _patientDb.Patients
                .FirstOrDefault(p => p.PatientId == id);

            if (patient != null)
            {
                _patientDb.Patients.Remove(patient);
            }

            return patient;
        }

        public Patient? UpdatePatient(int id, Patient patient)
        {
            var existing = _patientDb.Patients
                .FirstOrDefault(p => p.PatientId == id);

            if (existing != null)
            {
                existing.FullName = patient.FullName;
                existing.DateOfBirth = patient.DateOfBirth;
                existing.Gender = patient.Gender;
                existing.PhoneNumber = patient.PhoneNumber;
                existing.Email = patient.Email;
                existing.InsuranceId = patient.InsuranceId;
            }

            return existing;
        }
    }
}