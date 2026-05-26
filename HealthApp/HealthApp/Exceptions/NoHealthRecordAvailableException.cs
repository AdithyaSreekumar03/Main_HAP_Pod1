using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    public class NoHealthRecordAvailableException : Exception
    {
        public NoHealthRecordAvailableException(string message) : base(message) { }
    }
}