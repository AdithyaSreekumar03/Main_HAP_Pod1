using HealthApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Repository.Interface
{
    public interface IPatientRepository
    {
        void Add(Patient patient);
        List<Patient> GetAll();
        Patient? GetById(int id);
        Patient? UpdatePatient(int id, Patient patient);
    }
}