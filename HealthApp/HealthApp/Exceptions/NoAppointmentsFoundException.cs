using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    public class NoAppointmentsFoundException : Exception
    {
        public NoAppointmentsFoundException(string message) : base(message) { }
    }
}
