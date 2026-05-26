using HealthApp.Database;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace HealthApp.Repository.Impl
{
    public class PatientRepository : IPatientRepository
    {
        private readonly PatientDb _db;

        public PatientRepository(PatientDb db)
        {
            _db = db;
        }

        public void Add(Patient patient)
        {
            _db.Patients.Add(patient);
        }

        public List<Patient> GetAll()
        {
            return _db.Patients;
        }

        public Patient? GetById(int id)
        {
            return _db.Patients.FirstOrDefault(p => p.PatientId == id);
        }

        public Patient? UpdatePatientById(int id, Patient updated)
        {
            var existing = _db.Patients.FirstOrDefault(p => p.PatientId == id);

            if (existing == null)
                return null;

            existing.FullName = updated.FullName;
            existing.Email = updated.Email;
            existing.PhoneNumber = updated.PhoneNumber;

            return existing;
        }

        public Patient? DeletePatientById(int id)
        {
            var patient = _db.Patients.FirstOrDefault(p => p.PatientId == id);

            if (patient == null)
                return null;

            _db.Patients.Remove(patient);
            return patient;
        }
    }
}