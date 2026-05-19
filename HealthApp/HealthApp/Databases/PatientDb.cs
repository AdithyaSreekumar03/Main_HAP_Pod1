using HealthApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Databases
{
    public class PatientDb
    {
        public readonly List<Patient> patient = new List<Patient>
        {
            new Patient{PatientId=100,FullName="Mark",Gender="Male",Age=23,PhoneNumber=3456789,Email="david@gmail.com", InsuranceId="INS1005"},
            new Patient{PatientId=200,FullName="Sara",Gender="Female",Age=33,PhoneNumber=23456789,Email="anita@gmail.com", InsuranceId="INS1006"},
            new Patient{PatientId=300,FullName="John",Gender="Male",Age=28,PhoneNumber=23456789,Email="rahul@gmail.com", InsuranceId="INS1007"},
            new Patient{PatientId=400,FullName="Shilpa",Gender="Female",Age=25,PhoneNumber=3456789,Email="neha@gmail.com", InsuranceId="INS1008"},

        };
    }
}
