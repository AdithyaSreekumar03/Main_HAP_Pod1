using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HealthApp.Models
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
            return
                $"Doctor Id: {DoctorId}\n" +
                $"Doctor Name: {FullName}\n" +
                $"Doctor Specialisation: {Specialisation}\n" +
                $"Doctor Phone Number: {DoctorPhoneNo}\n" +
                $"Doctor Email: {DoctorEmail}\n" +
                $"Doctor Years of Experience: {YearsOfExperience}\n" +
                $"Doctor Consultation Fees: {ConsultationFee}\n";
        }
        public bool IsValidEmail()
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(
                DoctorEmail,
                pattern,
                RegexOptions.None,
                TimeSpan.FromSeconds(1));
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
