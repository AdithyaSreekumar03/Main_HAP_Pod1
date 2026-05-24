using HealthApp.Exceptions;
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
            var result = _repo.GetAll();
            if (!result.Any())
            {
                throw new NoPatientRegisteredException("There are no Patients Registered");
            }
            return result;
        }

        public Patient? GetPatientById(int id)
        {
            var patient = _repo.GetById(id);

            if (patient == null)
            {
                throw new PatientNotFoundException(
                    $"Patient with id {id} not found");
            }

            return patient;
        }
        public string DeletePatientById(int id)
        {
            var patient = _repo.DeletePatient(id);

            if (patient == null)
            {
                throw new PatientNotFoundException(
                    $"Patient with id {id} not found");
            }

            return $"Patient with id {id} deleted successfully";
        }
        public string UpdatePatientById(int id, Patient patient)
        {
            var updatedPatient = _repo.UpdatePatient(id, patient);

            if (updatedPatient == null)
            {
                throw new PatientNotFoundException(
                    $"Patient with id {id} not found");
            }

            return $"Patient with id {id} updated successfully";
        }
    }
}
