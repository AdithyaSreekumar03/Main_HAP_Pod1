

using System;

namespace HealthApp.Exceptions
{

    public class InvalidDateRangeException : Exception
    {
        public InvalidDateRangeException(string message)
            : base(message)
        {
        }
    }
}