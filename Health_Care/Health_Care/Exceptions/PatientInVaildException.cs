using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    public class PatientInValidException : Exception
    {
        public PatientInValidException(string message) : base(message)
        {

        }
    }
}
