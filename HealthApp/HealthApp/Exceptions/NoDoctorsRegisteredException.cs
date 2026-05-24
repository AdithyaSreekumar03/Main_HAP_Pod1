using System;

namespace HealthApp.Exceptions
{
    public class NoDoctorsRegisteredException : Exception
    {
        public NoDoctorsRegisteredException(string message)
            : base(message)
        {
        }
    }
}