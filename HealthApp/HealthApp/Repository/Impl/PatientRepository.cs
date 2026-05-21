using HealthApp.Databases;
using HealthApp.Exceptions;
using HealthApp.Models;
using HealthApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace HealthApp.Repository.Impl
{
    public class PatientRepository : IPatientRepository
    {
        private readonly PatientDb _db;
        public PatientRepository(PatientDb db)
        {
            this._db = db;
        }

        public string AddPatient(Patient patient)
        {
            patient.Age = CalculateAge(patient.DateOfBirth);
            patient.PatientId = _db.patients.Count == 0 ? 1 : _db.patients.Max(p => p.PatientId) + 1;
            _db.patients.Add(patient);
            return "Patient added successfully";
        }

        public string UpdatePatient(int id, Patient patient)
        {
            var existing = _db.patients.Find(p => p.PatientId == id);

            if (existing != null)
            {
                existing.FullName = patient.FullName;
                existing.DateOfBirth = patient.DateOfBirth;
                existing.Gender = patient.Gender;
                existing.PhoneNumber = patient.PhoneNumber;
                existing.Email = patient.Email;
                existing.InsuranceId = patient.InsuranceId;
                existing.Age = CalculateAge(patient.DateOfBirth);

                return "Patient updated successfully";
            }

            throw new PatientNotFoundException("Patient not found");
        }
        public string DeletePatient(int id)
        {
            var patient = _db.patients.Find(p => p.PatientId == id);
            if (patient != null)
            {
                _db.patients.Remove(patient);
                return "Deleted successfully";
            }
            throw new PatientNotFoundException("Patient not found");
        }
        public List<Patient> GetAll()
        {
            return _db.patients.ToList();
        }

        public Patient GetById(int id)
        {


            var patient = _db.patients.Find(p => p.PatientId == id);

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
