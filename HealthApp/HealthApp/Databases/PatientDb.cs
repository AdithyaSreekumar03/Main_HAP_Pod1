using HealthApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Databases
{
    public class PatientDb
    {
        public List<Patient> patients = new List<Patient>
        {
            new Patient
            {
                PatientId = 1,
                FullName = "Mark David",
                DateOfBirth = new DateOnly(2001, 5, 10),
                Gender = GenderType.Male,
                PhoneNumber = "9876543210",
                Email = "mark.david@gmail.com",
                InsuranceId = "INS1005"
            },
            new Patient
            {
                PatientId = 2,
                FullName = "Sara Thomas",
                DateOfBirth = new DateOnly(1991, 3, 15),
                Gender = GenderType.Female,
                PhoneNumber = "9123456780",
                Email = "sara.thomas@gmail.com",
                InsuranceId = "INS1006"
            },
            new Patient
            {
                PatientId = 3,
                FullName = "John Mathew",
                DateOfBirth = new DateOnly(1996, 8, 20),
                Gender = GenderType.Male,
                PhoneNumber = "9988776655",
                Email = "john.mathew@gmail.com",
                InsuranceId = "INS1007"
            },
            new Patient
            {
                PatientId = 4,
                FullName = "Shilpa Nair",
                DateOfBirth = new DateOnly(1999, 11, 5),
                Gender = GenderType.Female,
                PhoneNumber = "9012345678",
                Email = "shilpa.nair@gmail.com",
                InsuranceId = "INS1008"
            }
        };
    }
}
