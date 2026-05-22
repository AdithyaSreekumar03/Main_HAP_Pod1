using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    public class PastDateException : Exception
    {
        public PastDateException(string message)
            : base(message)
        {
        }
    }
}