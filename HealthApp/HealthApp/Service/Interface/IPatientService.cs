using HealthApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Service.Interface
{
    public interface IPatientService
    {
        string AddPatient(Patient patient);
        string UpdatePatient(int id, Patient patients);
        string DeletePatient(int id);
        List<Patient> GetAll();
        Patient GetById(int id);
    }
}
