using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    public class AppointmentConflictException : Exception
    {
        public AppointmentConflictException(string message)
            : base(message)
        {
        }
    }
}
