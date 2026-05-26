using HealthApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Database
{
    public class PatientDb
    {
        public List<Patient> Patients { get; set; }
        public PatientDb()
        {
            Patients = GetDummyPatients();
        }

        private static List<Patient> GetDummyPatients()
        {
            return new List<Patient>
            {
                CreatePatient(
                    1,
                    "Arun Kumar",
                    new DateOnly(1998, 5, 12),
                    GenderType.Male,
                    "9876543210",
                    "arun.kumar@gmail.com",
                    "INS1001"
                ),

                CreatePatient(
                    2,
                    "Priya Sharma",
                    new DateOnly(1995, 8, 25),
                    GenderType.Female,
                    "9123456780",
                    "priya.sharma@gmail.com",
                    "INS1002"
                ),

                CreatePatient(
                    3,
                    "Rahul Verma",
                    new DateOnly(2001, 2, 18),
                    GenderType.Male,
                    "9988776655",
                    "rahul.verma@gmail.com",
                    "INS1003"
                ),

                CreatePatient(
                    4,
                    "Sneha Reddy",
                    new DateOnly(1992, 11, 30),
                    GenderType.Female,
                    "9012345678",
                    "sneha.reddy@gmail.com",
                    "INS1004"
                ),

                CreatePatient(
                    5,
                    "Alex John",
                    new DateOnly(1988, 7, 14),
                    GenderType.Other,
                    "9090909090",
                    "alex.john@gmail.com",
                    "INS1005"
                )
            };
        }

        private static Patient CreatePatient(
            int id,
            string name,
            DateOnly dob,
            GenderType gender,
            string phone,
            string email,
            string insuranceId)
        {
            return new Patient
            {
                PatientId = id,
                FullName = name,
                DateOfBirth = dob,
                Gender = gender,
                PhoneNumber = phone,
                Email = email,
                InsuranceId = insuranceId
            };
        }
    }
}