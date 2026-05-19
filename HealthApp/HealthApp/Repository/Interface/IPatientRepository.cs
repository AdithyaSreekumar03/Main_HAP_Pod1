using HealthApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Repository.Interface
{
    public interface IPatientRepository
    {
        string AddPatient(Patient patient);
        string UpdatePatient(int id, Patient patients);
        string DeletePatient(int id);
        List<Patient> GetAll();
        Patient GetById(int id);
    }
}
