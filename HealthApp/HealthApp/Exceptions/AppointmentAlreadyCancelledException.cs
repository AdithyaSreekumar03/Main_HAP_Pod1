using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    public class AppointmentAlreadyCancelledException : Exception
    {
        public AppointmentAlreadyCancelledException(string message) : base(message) { }

    }
}
