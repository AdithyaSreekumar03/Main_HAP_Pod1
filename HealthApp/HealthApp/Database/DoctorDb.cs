using HealthApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Databases
{
    public class DoctorDb
    {
        public List<Doctor> Doctors { get; set; } =
        [
            new Doctor
            {
                DoctorId = 1,
                FullName = "Dr. Arun",
                Specialisation = SpecialisationType.GeneralPhysician,
                DoctorPhoneNo = "9000000001",
                DoctorEmail = "arun@gmail.com",
                YearsOfExperience = 10,
                ConsultationFee = 500m,
                IsActive = true
            },
            new Doctor
            {
                DoctorId = 2,
                FullName = "Dr. Vimal",
                Specialisation = SpecialisationType.Cardiologist,
                DoctorPhoneNo = "9000000002",
                DoctorEmail = "vimal@gmail.com",
                YearsOfExperience = 12,
                ConsultationFee = 800m,
                IsActive = true
            },
            new Doctor
            {
                DoctorId = 3,
                FullName = "Dr. Rahul",
                Specialisation = SpecialisationType.Dermatologist,
                DoctorPhoneNo = "9000000003",
                DoctorEmail = "rahul@gmail.com",
                YearsOfExperience = 8,
                ConsultationFee = 600m,
                IsActive = false
            },
            new Doctor
            {
                DoctorId = 4,
                FullName = "Dr. Meena",
                Specialisation = SpecialisationType.Neurologist,
                DoctorPhoneNo = "9000000004",
                DoctorEmail = "meena@gmail.com",
                YearsOfExperience = 14,
                ConsultationFee = 1200m,
                IsActive = true
            },
            new Doctor
            {
                DoctorId = 5,
                FullName = "Dr. Kumar",
                Specialisation = SpecialisationType.Orthopedic,
                DoctorPhoneNo = "9000000005",
                DoctorEmail = "kumar@gmail.com",
                YearsOfExperience = 15,
                ConsultationFee = 1000m,
                IsActive = true
            },
            new Doctor
            {
                DoctorId = 6,
                FullName = "Dr. Lakshmi",
                Specialisation = SpecialisationType.Pediatrician,
                DoctorPhoneNo = "9000000006",
                DoctorEmail = "lakshmi@gmail.com",
                YearsOfExperience = 9,
                ConsultationFee = 700m,
                IsActive = true
            },
            new Doctor
            {
                DoctorId = 7,
                FullName = "Dr. Ravi",
                Specialisation = SpecialisationType.Psychiatrist,
                DoctorPhoneNo = "9000000007",
                DoctorEmail = "ravi@gmail.com",
                YearsOfExperience = 11,
                ConsultationFee = 900m,
                IsActive = true
            },
            new Doctor
            {
                DoctorId = 8,
                FullName = "Dr. Suresh",
                Specialisation = SpecialisationType.ENT,
                DoctorPhoneNo = "9000000008",
                DoctorEmail = "suresh@gmail.com",
                YearsOfExperience = 7,
                ConsultationFee = 650m,
                IsActive = true
            },
            new Doctor
            {
                DoctorId = 9,
                FullName = "Dr. Priya",
                Specialisation = SpecialisationType.Gynecologist,
                DoctorPhoneNo = "9000000009",
                DoctorEmail = "priya@gmail.com",
                YearsOfExperience = 13,
                ConsultationFee = 950m,
                IsActive = true
            }
        ];
    }
}