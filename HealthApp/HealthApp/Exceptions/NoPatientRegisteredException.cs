using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    public class NoPatientsRegisteredException : Exception
    {
        public NoPatientsRegisteredException(string message) : base(message) { }
    }
}