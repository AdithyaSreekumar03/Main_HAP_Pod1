using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;



    public class DoctorNotFoundException : Exception
    {
        public DoctorNotFoundException(string message) : base(message) { }
    }


}
