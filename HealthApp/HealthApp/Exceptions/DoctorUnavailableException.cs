using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    public class DoctorUnavailableException : Exception
    {
        public DoctorUnavailableException(string message)
            : base(message)
        {
        }
    }
}