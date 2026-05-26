using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    public class AppointmentAlreadyCompletedException : Exception
    {
        public AppointmentAlreadyCompletedException(string message) : base(message) { }
    }
}
