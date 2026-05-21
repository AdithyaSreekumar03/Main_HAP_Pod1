using System;
using System.Linq;
using System.Collections.Generic;
using POD1_NET_ConsoleApp.Models;
using POD1_NET_ConsoleApp.Database;
using POD1_NET_ConsoleApp.Exceptions;
using POD1_NET_ConsoleApp.Repositories.Interfaces;

namespace POD1_NET_ConsoleApp.Repositories.Impl
{
    public class PatientRepository : IPatientRepository
    {
        private readonly PatientDb _db;

        public PatientRepository(PatientDb db)
        {
            _db = db;
        }

        public string AddPatient(Patient patient)
        {
            patient.Age = CalculateAge(patient.DateOfBirth);
            _db.Patients.Add(patient);
            return "Patient added successfully";
        }

        public string UpdatePatient(int id, Patient patient)
        {
            var existing = _db.Patients.FirstOrDefault(p => p.PatientId == id);

            if (existing == null)
                throw new PatientNotFoundException("Patient not found");

            existing.FullName = patient.FullName;
            return "Patient updated successfully";
        }

        public string DeletePatient(int id)
        {
            var patient = _db.Patients.FirstOrDefault(p => p.PatientId == id);

            if (patient == null)
                throw new PatientNotFoundException("Patient not found");

            _db.Patients.Remove(patient);
            return "Deleted successfully";
        }

        public List<Patient> GetAll()
        {
            return _db.Patients.ToList();
        }

        public Patient GetById(int id)
        {
            var patient = _db.Patients.FirstOrDefault(p => p.PatientId == id);

            if (patient == null)
                throw new PatientNotFoundException($"Patient with ID {id} not found");

            return patient;
        }

        private int CalculateAge(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
                age--;

            return age;
        }
    }
}
