using System;
using System.Collections.Generic;
using System.Text;
using HealthApp.Models;

namespace HealthApp.Database
{
    public class DoctorDB
    {
        public readonly List<Doctor> doctors = new List<Doctor>
        {
            new Doctor{doctorID=100, doctorName="David", Specialisation="Pediatrics", YearsOfExperience=9, ConsultationFee=450, IsActive=true},
            new Doctor{doctorID=200, doctorName="Sara", Specialisation="Neurology", YearsOfExperience=8, ConsultationFee=500, IsActive=true},
            new Doctor{doctorID=300, doctorName="John", Specialisation="Orthopedics", YearsOfExperience=6, ConsultationFee=400, IsActive=true},
            new Doctor{doctorID=400, doctorName="Shilpa", Specialisation="Dermatology", YearsOfExperience=5, ConsultationFee=350, IsActive=true},
            new Doctor{doctorID=500, doctorName="David", Specialisation="Pediatrics", YearsOfExperience=9, ConsultationFee=450, IsActive=true}


        };
    }
}
