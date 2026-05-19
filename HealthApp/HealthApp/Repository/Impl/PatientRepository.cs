using HealthApp.Databases;
using HealthApp.Models;
using HealthApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Repository.Impl
{
    public class PatientRepository : IPatientRepository
    {
        private readonly PatientDb _db;
        private static int currentId = 1;
        public PatientRepository(PatientDb db)
        {
            this._db = db;
        }

        public string AddPatient(Patient patient)
        {
            patient.Age = CalculateAge(patient.DateOfBirth);
            patient.PatientId = currentId++;
            _db.patient.Add(patient);
            return "Patient added successfully";
        }

        public string UpdatePatient(int id, Patient patient)
        {
            var existing = _db.patient.Find(p => p.PatientId == id);
            if (existing != null)
            {
                existing.FullName = patient.FullName;
                return "Patient updated";
            }
            throw new PatientNotFoundException("Patient not found");
        }
        public string DeletePatient(int id)
        {
            var patient = _db.patient.Find(p => p.PatientId == id);
            if (patient != null)
            {
                _db.patient.Remove(patient);
                return "Deleted successfully";
            }
            throw new PatientNotFoundException("Patient not found");
        }
        public List<Patient> GetAll()
        {
            return _db.patient.ToList();
        }

        public Patient GetById(int id)
        {


            var patient = _db.patient.Find(p => p.PatientId == id);

            if (patient == null)
            {
                throw new PatientNotFoundException($"Patient with ID {id} not found");
            }

            return patient;

        }
        private int CalculateAge(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
            {
                age--;
            }

            return age;
        }
    }
}
