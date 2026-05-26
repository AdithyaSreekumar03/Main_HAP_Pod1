using HealthApp.Model;
using System.Collections.Generic;

namespace HealthApp.Service.Interface
{
    public interface IPatientService
    {
        void RegisterPatient(Patient patient);

        List<Patient> GetAllPatients();

        Patient? GetPatientById(int id);

        string UpdatePatientById(int id, Patient patient);

        // ✅ Added to match service + tests
        string DeletePatientById(int id);
    }
}
