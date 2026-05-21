using HealthApp.Modules;
using HealthApp.Service;
using System;
using System.Collections.Generic;
using System.Text;
using HealthApp.Database;
using HealthApp.Exceptions;
using HealthApp.Repositories.Interface;


namespace HealthApp.Repositories.impl
{


    public class PatientRepository : IPatientRepository

    {
        private readonly PatientDB _db;

        public PatientRepository(PatientDB db)
        {
            this._db = db;
        }
                
        public string AddPatient(Patient patient)
        {
            _db.patient.Add(patient);
            return "Patient added successfully";
        }

        public string UpdatePatient(int id, Patient patient)
        {
            var existing = _db.patient.Find(p => p.PatientId == id);
            if (existing != null)
            {
                existing.FullName = patient.FullName;
                existing.Age = patient.CalculateAge(patient.DateOfBirth);
                existing.PhoneNumber = patient.PhoneNumber;
                existing.Email= patient.Email;
                existing.Gender = patient.Gender;
                existing.InsuranceId = patient.InsuranceId;
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

        public List<Patient> GetAllPatients()
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



    }
}