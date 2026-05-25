using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    public class NotValidSpecialisationException:Exception
    {
        public NotValidSpecialisationException(string message):base(message) { }
    }
}
