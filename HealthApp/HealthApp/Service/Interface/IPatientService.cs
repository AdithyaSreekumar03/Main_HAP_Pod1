using HealthApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Service.Interface
{
    public interface IPatientService
    {
        void RegisterPatient(Patient patient);

        List<Patient> GetAllPatients();

        Patient? GetPatientById(int id);

        string UpdatePatientById(int id, Patient patient);
    }
}