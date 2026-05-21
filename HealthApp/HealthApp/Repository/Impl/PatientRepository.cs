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
        private readonly PatientDb _patientDb;
        public PatientRepository(PatientDb patientDb)
        {
            _patientDb = patientDb;
        }
        public void Add(Patient patient)
        {
            _patientDb.patients.Add(patient);
        }
        public List<Patient> GetAll()
        {
            return _patientDb.patients;
        }
        public Patient? GetById(int id)
        {
            var patient = _patientDb.patients.FirstOrDefault(pa => pa.PatientId == id);
            if (patient == null)
            {
                throw new PatientNotFoundException($"Patient with id {id} not found");

            }
            return patient;
        }
        public string DeletePatient(int id)
        {
            var patient = _patientDb.patients.FirstOrDefault(p => p.PatientId == id);
            if (patient == null)
            {
                throw new Exceptions.PatientNotFoundException($"Patient with {id} not found");
            }
            _patientDb.patients.Remove(patient);
            return $"Patient with id {id} deleted successfully";
        }
        public string UpdatePatient(int id, Patient patient)
        {
            var pat = _patientDb.patients.FirstOrDefault(pa => pa.PatientId == id);
            if (pat == null)
            {
                throw new PatientNotFoundException($"Patient with id {id} not found");
            }
            pat.FullName = patient.FullName;
            pat.DateOfBirth = patient.DateOfBirth;
            pat.Gender = patient.Gender;
            pat.PhoneNumber = patient.PhoneNumber;
            pat.Email = patient.Email;
            pat.InsuranceId = patient.InsuranceId;
            return $"Patient with id {id} updated successfully";
        }
    }
}
