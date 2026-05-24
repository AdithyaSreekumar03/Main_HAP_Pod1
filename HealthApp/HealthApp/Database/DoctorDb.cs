using HealthApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Database
{
    public class DoctorDb
    {
        public List<Doctor> Doctors { get; set; } = new List<Doctor>
        {
            new Doctor
            {
                DoctorId = 1,
                FullName = "Dr. Rajesh Kumar",
                Specialisation = SpecialisationType.Cardiologist,
                DoctorPhoneNo = "9876543210",
                DoctorEmail = "rajesh.kumar@gmail.com",
                YearsOfExperience = 12,
                ConsultationFee = 800,
                IsActive = true
            },

            new Doctor
            {
                DoctorId = 2,
                FullName = "Dr. Priya Sharma",
                Specialisation = SpecialisationType.Dermatologist,
                DoctorPhoneNo = "9123456780",
                DoctorEmail = "priya.sharma@gmail.com",
                YearsOfExperience = 8,
                ConsultationFee = 600,
                IsActive = true
            },

            new Doctor
            {
                DoctorId = 3,
                FullName = "Dr. Arun Reddy",
                Specialisation = SpecialisationType.Neurologist,
                DoctorPhoneNo = "9988776655",
                DoctorEmail = "arun.reddy@gmail.com",
                YearsOfExperience = 15,
                ConsultationFee = 1200,
                IsActive = true
            },

            new Doctor
            {
                DoctorId = 4,
                FullName = "Dr. Sneha Patel",
                Specialisation = SpecialisationType.Pediatrician,
                DoctorPhoneNo = "9012345678",
                DoctorEmail = "sneha.patel@gmail.com",
                YearsOfExperience = 6,
                ConsultationFee = 500,
                IsActive = true
            },

            new Doctor
            {
                DoctorId = 5,
                FullName = "Dr. John Alex",
                Specialisation = SpecialisationType.Orthopedic,
                DoctorPhoneNo = "9090909090",
                DoctorEmail = "john.alex@gmail.com",
                YearsOfExperience = 10,
                ConsultationFee = 900,
                IsActive = false
            }
        };
    }
}