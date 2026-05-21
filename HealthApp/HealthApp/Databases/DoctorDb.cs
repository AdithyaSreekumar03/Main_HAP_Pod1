using HealthApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Databases
{
    public class DoctorDb
    {
        public readonly List<Doctor> doctorDb = new List<Doctor>
        {
            new Doctor{DoctorId = 1, FullName = "Dr. Vimal", Specialisation = "Cardiologist", YearsOfExperience = 12, ConsultationFee = 800m, IsActive = true},
            new Doctor{DoctorId = 2, FullName = "Dr. Rahul", Specialisation = "Dermatologist", YearsOfExperience = 8, ConsultationFee = 600m, IsActive = false},
            new Doctor{DoctorId = 3, FullName = "Dr. Kumar", Specialisation = "Orthopedic", YearsOfExperience = 15, ConsultationFee = 1000m, IsActive = true},
            new Doctor{DoctorId = 4, FullName = "Dr. Muthu", Specialisation = "Pediatrician", YearsOfExperience = 6, ConsultationFee = 500m, IsActive = true}
        };
    }
}
