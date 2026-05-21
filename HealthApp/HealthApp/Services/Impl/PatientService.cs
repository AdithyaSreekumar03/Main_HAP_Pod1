using System.Collections.Generic;
using POD1_NET_ConsoleApp.Models;
using POD1_NET_ConsoleApp.Repositories.Interfaces;
using POD1_NET_ConsoleApp.Service.Interfaces;

namespace POD1_NET_ConsoleApp.Service.Impl
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _rep;

        public PatientService(IPatientRepository rep)
        {
            _rep = rep;
        }

        public string AddPatient(Patient patient)
        {
            return _rep.AddPatient(patient);
        }

        public string UpdatePatient(int id, Patient patient)
        {
            return _rep.UpdatePatient(id, patient);
        }

        public string DeletePatient(int id)
        {
            return _rep.DeletePatient(id);
        }

        public List<Patient> GetAll()
        {
            return _rep.GetAll();
        }

        public Patient GetById(int id)
        {
            return _rep.GetById(id);
        }
    }
}
