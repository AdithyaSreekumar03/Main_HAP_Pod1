using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Interface;
using System.Collections.Generic;
using System.Linq;

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
            var patients = _repo.GetAll();
            int newId;

            if (patients.Any())
                newId = patients.Max(p => p.PatientId) + 1;

            else newId = 1;
            patient.PatientId = newId;

            _repo.Add(patient);

        }
        public Patient GetPatientById(int id)
        {
            var patient = _repo.GetById(id);
            
            if (patient == null) 
                throw new PatientNotFoundException("Patient not found");
            return patient;

        }
        public List<Patient> GetAllPatients()
        {
            var list = _repo.GetAll();
            if (!list.Any()) throw new NoPatientsRegisteredException("No patients found");

            return list;

        }
        public string UpdatePatientById(int id, Patient updated)
        {
            var result = _repo.UpdatePatient(id, updated);


            if (result == null) throw new PatientNotFoundException("Patient not found");


            return "Patient updated successfully";

        }
    }
}