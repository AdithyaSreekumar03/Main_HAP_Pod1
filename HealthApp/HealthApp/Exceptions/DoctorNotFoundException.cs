using System;
using System.Collections.Generic;
using System.Text;

namespace POD1_.NET_ConsoleApp.Exceptions
{
    public class DoctorNotFoundException : Exception
    {
        public DoctorNotFoundException(string message) : base(message) { }
    }
}