using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    public class AppointmentAlreadyConfirmedException:Exception
    {
        public AppointmentAlreadyConfirmedException(string message) : base(message) { }
    }
}
