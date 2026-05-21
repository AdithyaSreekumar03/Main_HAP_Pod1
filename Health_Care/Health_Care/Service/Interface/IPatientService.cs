using System;
using System.Collections.Generic;
using System.Text;
using HealthApp.Database;
using HealthApp.Modules;


namespace HealthApp.Service.Interface
{
    public interface IPatientService
    {
        string AddPatient(Patient patient);
        string UpdatePatient(int id, Patient patients);
        string DeletePatient(int id);
        List<Patient> GetAllPatients();
        Patient GetById(int id);
    }
}
