using System.Collections.Generic;
using POD1_NET_ConsoleApp.Models;

namespace POD1_NET_ConsoleApp.Database
{
    public class AppointmentDb
    {
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}