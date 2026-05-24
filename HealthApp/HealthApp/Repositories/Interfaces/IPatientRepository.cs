using HealthApp.Model;
using System.Collections.Generic;

namespace HealthApp.Repository.Interface
{
    public interface IPatientRepository
    {
        void Add(Patient patient);

        List<Patient> GetAll();

        // ✅ Return null if not found
        Patient? GetById(int id);

        // ✅ Return deleted patient or null
        Patient? DeletePatient(int id);

        // ✅ Return updated patient or null
        Patient? UpdatePatient(int id, Patient patient);
    }
}
