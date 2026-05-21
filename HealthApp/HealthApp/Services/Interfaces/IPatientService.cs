using System.Collections.Generic;
using POD1_NET_ConsoleApp.Models;

namespace POD1_NET_ConsoleApp.Service.Interfaces
{
    public interface IPatientService
    {
        string AddPatient(Patient patient);
        string UpdatePatient(int id, Patient patient);
        string DeletePatient(int id);

        List<Patient> GetAll();
        Patient GetById(int id);
    }
}
