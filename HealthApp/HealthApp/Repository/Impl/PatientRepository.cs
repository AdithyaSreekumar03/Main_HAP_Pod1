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
            _patientDb.Patients.Add(patient);
        }

        public List<Patient> GetAll()
        {
            return _patientDb.Patients;
        }

        public Patient? GetById(int id)
        {
            return _patientDb.Patients
                             .FirstOrDefault(pa => pa.PatientId == id);
        }

        public Patient? UpdatePatient(int id, Patient patient)
        {
            var pat = _patientDb.Patients
                                .FirstOrDefault(pa => pa.PatientId == id);

            if (pat == null)
            {
                return null;
            }

            pat.FullName = patient.FullName;
            pat.DateOfBirth = patient.DateOfBirth;
            pat.Gender = patient.Gender;
            pat.PhoneNumber = patient.PhoneNumber;
            pat.Email = patient.Email;
            pat.InsuranceId = patient.InsuranceId;

            return pat;
        }
    }
}