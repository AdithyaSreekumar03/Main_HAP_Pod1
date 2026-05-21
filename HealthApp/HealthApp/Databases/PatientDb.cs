using HealthApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Databases
{
    public class PatientDb
    {
        public readonly List<Patient> patients = new List<Patient>
        {
            new Patient
            {
                PatientId = 1,
                FullName = "Mark",
                DateOfBirth = new DateTime(2001, 5, 10), 
                Gender = "Male",
                Age = 23,
                PhoneNumber = 3456789,
                Email = "david@gmail.com",
                InsuranceId = "INS1005"
            },
            new Patient
            {
                PatientId = 2,
                FullName = "Sara",
                DateOfBirth = new DateTime(1991, 3, 15), 
                Gender = "Female",
                Age = 33,
                PhoneNumber = 23456789,
                Email = "anita@gmail.com",
                InsuranceId = "INS1006"
            },
            new Patient
            {
                PatientId = 3,
                FullName = "John",
                DateOfBirth = new DateTime(1996, 8, 20), 
                Gender = "Male",
                Age = 28,
                PhoneNumber = 23456789,
                Email = "rahul@gmail.com",
                InsuranceId = "INS1007"
            },
            new Patient
            {
                PatientId = 4,
                FullName = "Shilpa",
                DateOfBirth = new DateTime(1999, 11, 5), 
                Gender = "Female",
                Age = 25,
                PhoneNumber = 3456789,
                Email = "neha@gmail.com",
                InsuranceId = "INS1008"
            }
        };

    }
}
