using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Service.Impl
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _repo;

        public PatientService(IPatientRepository repo)
        {
            _repo = repo;
        }

        public void RegisterPatient(Patient patient)
        {


            if (_repo.GetAll().Any())
            {
                patient.PatientId =
                _repo.GetAll().Max(p => p.PatientId) + 1;
            }
            else
            {
                patient.PatientId = 1;
            }


            _repo.Add(patient);
        }

        public List<Patient> GetAllPatients()
        {
            return _repo.GetAll();
        }

        public Patient? GetPatientById(int id)
        {
            return _repo.GetById(id);
        }
        public string DeletePatientById(int id)
        {
            return _repo.DeletePatient(id);
        }
        public string UpdatePatientById(int id, Patient patient)
        {


            return _repo.UpdatePatient(id, patient);

        }
    }
}