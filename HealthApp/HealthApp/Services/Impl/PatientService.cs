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
            var patients = _repo.GetAll();

            if (patients.Count > 0)
            {
                patient.PatientId =
                    patients.Max(p => p.PatientId) + 1;
            }
            else
            {
                patient.PatientId = 1;
            }

            _repo.Add(patient);
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