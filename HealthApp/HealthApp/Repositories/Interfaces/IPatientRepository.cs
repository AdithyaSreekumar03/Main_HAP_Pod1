using System.Collections.Generic;
using POD1_NET_ConsoleApp.Models;

namespace POD1_NET_ConsoleApp.Repositories.Interfaces
{
    public interface IPatientRepository
    {
        string AddPatient(Patient patient);
        string UpdatePatient(int id, Patient patient);
        string DeletePatient(int id);

        List<Patient> GetAll();
        Patient GetById(int id);
    }
}
