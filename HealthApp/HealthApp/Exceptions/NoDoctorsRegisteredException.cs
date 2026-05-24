using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    internal class NoDoctorsRegisteredException : Exception
    {
        public NoDoctorsRegisteredException(string message) : base(message) { }
    }
}