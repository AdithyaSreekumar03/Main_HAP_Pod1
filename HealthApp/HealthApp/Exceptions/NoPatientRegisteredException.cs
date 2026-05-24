using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    public class NoPatientRegisteredException : Exception
    {
        public NoPatientRegisteredException(string message) : base(message) { }
    }
}
