using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Interface;

using System.ComponentModel.DataAnnotations;

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

        //  REGISTER PATIENT
        public void RegisterPatient(Patient patient)
        {
            var patients = _repo.GetAll();

            if (patients.Count == 0)
            {
                patient.PatientId = 1;
            }
            else
            {
                patient.PatientId = patients.Max(p => p.PatientId) + 1;
            }

            _repo.Add(patient);
        }



        //  GET ALL PATIENTS
        public List<Patient> GetAllPatients()
        {
            var patients = _repo.GetAll();

            if (patients == null || patients.Count==0)
            {
                throw new NoPatientRegisteredException("No patients found.");
            }

            return patients;
        }

        // GET PATIENT BY ID
        public Patient? GetPatientById(int id)
        {
            var patient = _repo.GetById(id);

            if (patient == null)
            {
                throw new PatientNotFoundException($"Patient with id {id} not found");
            }

            return patient;
        }

        //  DELETE PATIENT
        public string DeletePatientById(int id)
        {
            var patient = _repo.DeletePatient(id);

            if (patient == null)
            {
                throw new PatientNotFoundException($"Patient with id {id} not found");
            }

            return $"Patient with id {id} deleted successfully";
        }

        // ✅UPDATE PATIENT
        public string UpdatePatientById(int id, Patient patient)
        {
            // VALIDATION
            if (string.IsNullOrWhiteSpace(patient.FullName))
            {
                throw new ValidationException("Patient name cannot be empty.");
            }

            var updated = _repo.UpdatePatient(id, patient);

            if (updated == null)
            {
                throw new PatientNotFoundException($"Patient with id {id} not found");
            }

            return $"Patient with id {id} updated successfully";
        }
    }
}