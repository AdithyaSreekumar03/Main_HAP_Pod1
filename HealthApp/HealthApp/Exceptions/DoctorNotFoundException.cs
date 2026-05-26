using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    public class DoctorNotFoundException : Exception
    {
        public DoctorNotFoundException(string message) : base(message) { }
    }
}
