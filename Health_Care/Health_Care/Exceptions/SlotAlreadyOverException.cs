using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    public class SlotAlreadyOverException : Exception
    {
        public SlotAlreadyOverException(string message) : base(message)
        {

        }
    }
}
