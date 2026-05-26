using HealthApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Databases
{
    public class DoctorDb
    {
        public List<Doctor> Doctors { get; set; } = new List<Doctor>
        {
            new Doctor
            {
                DoctorId = 1,
                FullName = "Vimal Rajan",
                Specialisation = SpecialisationType.Cardiologist,
                DoctorPhoneNo = "9876543210",
                DoctorEmail = "vimal@gmail.com",
                YearsOfExperience = 12,
                ConsultationFee = 800m,
                IsActive = true
            },
            new Doctor
            {
                DoctorId = 2,
                FullName = "Rahul Sharma",
                Specialisation = SpecialisationType.Dermatologist,
                DoctorPhoneNo = "9123456780",
                DoctorEmail = "rahul@gmail.com",
                YearsOfExperience = 8,
                ConsultationFee = 600m,
                IsActive = false
            },
            new Doctor
            {
                DoctorId = 3,
                FullName = "Kumaravel Pandian",
                Specialisation = SpecialisationType.Orthopedic,
                DoctorPhoneNo = "9988776655",
                DoctorEmail = "kumar@gmail.com",
                YearsOfExperience = 15,
                ConsultationFee = 1000m,
                IsActive = true
            },
            new Doctor
            {
                DoctorId = 4,
                FullName = "Muthu Krishnan",
                Specialisation = SpecialisationType.Pediatrician,
                DoctorPhoneNo = "9012345678",
                DoctorEmail = "muthu@gmail.com",
                YearsOfExperience = 6,
                ConsultationFee = 500m,
                IsActive = true
            }
        };
    }
}