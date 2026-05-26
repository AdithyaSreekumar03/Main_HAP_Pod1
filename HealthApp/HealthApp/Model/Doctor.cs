using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HealthApp.Model
{
    public enum SpecialisationType
    {
        GeneralPhysician,
        Cardiologist,
        Dermatologist,
        Neurologist,
        Orthopedic,
        Pediatrician,
        Psychiatrist,
        ENT,
        Gynecologist
    }
    public class Doctor
    {
        public int DoctorId { get; set; }

        public string FullName { get; set; } = string.Empty;

        public SpecialisationType Specialisation { get; set; }
        public string DoctorPhoneNo { get; set; } = string.Empty;
        public string DoctorEmail { get; set; } = string.Empty;

        public int YearsOfExperience { get; set; }

        public decimal ConsultationFee { get; set; }

        public bool IsActive { get; set; }

        public string GetDoctorDetailsSummary()
        {
            Console.WriteLine();
            Console.WriteLine($"Doctor Name: {FullName}");
            Console.WriteLine($"Doctor Specialisation: {Specialisation}");
            Console.WriteLine($"Doctor Phone Number: {DoctorPhoneNo}");
            Console.WriteLine($"Doctor Email: {DoctorEmail}");
            Console.WriteLine($"Doctor Years of Experience: {YearsOfExperience}");
            Console.WriteLine($"Doctor Consultation Fees: {ConsultationFee}");
            Console.WriteLine();
            return "Doctor Registered Successfully";
        }
        public bool IsValidEmail()
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(
       DoctorEmail,
       pattern,
       RegexOptions.None,
       TimeSpan.FromSeconds(1)
   );
        }
        public bool IsValidPhoneNumber()
        {
            string pattern = @"^[0-9]{10}$";
            return Regex.IsMatch(DoctorPhoneNo, pattern, RegexOptions.None, TimeSpan.FromSeconds(1));
        }
        public bool IsValidName()
        {
            if (string.IsNullOrWhiteSpace(FullName))
                return false;

            string pattern = @"^[a-zA-Z\s\.\-]{3,50}$";
            return Regex.IsMatch(FullName, pattern, RegexOptions.None, TimeSpan.FromSeconds(1));
        }
    }
}