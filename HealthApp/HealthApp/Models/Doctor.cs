using System;

namespace POD1_NET_ConsoleApp.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string FullName { get; set; }
        public string Specialisation { get; set; }
        public int YearsOfExperience { get; set; }
        public int ConsultationFee { get; set; }
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return $"{DoctorId} | {FullName} | {Specialisation}";
        }
    }
}
