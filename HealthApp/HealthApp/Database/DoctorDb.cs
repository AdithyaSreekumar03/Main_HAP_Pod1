using POD1_NET_ConsoleApp.Models;
using System.Collections.Generic;

namespace POD1_NET_ConsoleApp.Database
{
    public class DoctorDb
    {
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}