using System.Collections.Generic;
using POD1_NET_ConsoleApp.Models;

namespace POD1_NET_ConsoleApp.Database
{
    public class PatientDb
    {
        public List<Patient> Patients { get; set; } = new List<Patient>();
    }
}