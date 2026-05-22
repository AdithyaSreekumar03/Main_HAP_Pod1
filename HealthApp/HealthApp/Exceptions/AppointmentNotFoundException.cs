using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    public class AppointmentNotFoundException : Exception
    {
        public AppointmentNotFoundException(string message) : base(message) { }
    }
}