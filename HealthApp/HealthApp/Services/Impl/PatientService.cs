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

        // ✅ REGISTER
        public void RegisterPatient(Patient patient)
        {
            var patients = _repo.GetAll();

            int newId;

            if (patients.Any())
            {
                newId = patients.Max(p => p.PatientId) + 1;
            }
            else
            {
                newId = 1;
            }

            patient.PatientId = newId;

            _repo.Add(patient);
        }

        // ✅ GET BY ID
        public Patient GetPatientById(int id)
        {
            var patient = _repo.GetById(id);

            if (patient == null)
            {
                throw new PatientNotFoundException("Patient not found");
            }

            return patient;
        }

        // ✅ GET ALL
        public List<Patient> GetAllPatients()
        {
            var list = _repo.GetAll();

            if (!list.Any())
            {
                throw new PatientNotFoundException("No patients found");
            }

            return list;
        }

        // ✅ UPDATE
        public string UpdatePatientById(int id, Patient updated)
        {
            var result = _repo.UpdatePatientById(id, updated);

            if (result == null)
            {
                throw new PatientNotFoundException("Patient not found");
            }

            return "Patient updated successfully";
        }

        // ✅ ✅ DELETE (FINAL FIX)
        public string DeletePatientById(int id)
        {
            var result = _repo.DeletePatientById(id);

            if (result == null)
            {
                throw new PatientNotFoundException("Patient not found");
            }

            return "Patient deleted successfully";
        }
    }
}