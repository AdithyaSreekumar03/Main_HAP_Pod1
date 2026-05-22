using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    public class NoDoctorsRegisteredException : Exception
    {
        public NoDoctorsRegisteredException(string message) : base(message) { }
    }
}