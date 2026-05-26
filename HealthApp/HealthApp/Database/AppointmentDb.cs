using HealthApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Databases
{
    public class AppointmentDb
    {
        public List<Appointment> Appointments { get; set; } = [];
    }
}