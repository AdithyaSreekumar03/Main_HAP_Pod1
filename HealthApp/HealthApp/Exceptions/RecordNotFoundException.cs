using System;

namespace HealthApp.Exceptions
{
    public class RecordNotFoundException : Exception
    {
        public RecordNotFoundException(string message)
            : base(message)
        {
        }
    }
}
