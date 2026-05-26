using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    public class InvalidSlotException : Exception
    {
        public InvalidSlotException(string message) : base(message)
        {
        }
    }
}
