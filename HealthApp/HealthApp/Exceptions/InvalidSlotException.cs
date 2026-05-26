
using System;

namespace HealthApp.Exceptions
{

    public class InvalidSlotException : Exception
    {
        public InvalidSlotException(string message) : base(message)
        {
        }
    }
}