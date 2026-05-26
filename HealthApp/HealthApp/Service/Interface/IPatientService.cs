using HealthApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Service.Interface
{
    public interface IPatientService
    {
        void RegisterPatient(Patient patient);
        Patient? GetPatientById(int id);
        string UpdatePatientById(int id, Patient patient);
    }
}
