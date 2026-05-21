using HealthApp.Modules;
using HealthApp.Repositories.impl;
using System.Collections.Generic;
using HealthApp.Database;
using HealthApp.Repositories.Interface;
using HealthApp.Service.Interface;

namespace HealthApp.Service.impl
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _rep;
        public PatientService(IPatientRepository rep)
        {
            this._rep = rep;
        }
        int currentId=1;

        public string AddPatient(Patient patient)
        {
            patient.Age = patient.CalculateAge(patient.DateOfBirth);
            patient.PatientId = currentId++;
            return _rep.AddPatient(patient);
            
        }

        public string UpdatePatient(int id, Patient patient)
        {
            return _rep.UpdatePatient(id, patient);
        }

        public string DeletePatient(int id)
        {
            return _rep.DeletePatient(id);
        }

        public List<Patient> GetAllPatients()
        {
            return _rep.GetAllPatients();
        }

        public Patient GetById(int id)
        {
            return _rep.GetById(id);
        }
    }

}