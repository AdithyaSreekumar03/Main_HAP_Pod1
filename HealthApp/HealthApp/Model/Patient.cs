using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HealthApp.Model
{
    public enum GenderType
    {
        Male,
        Female,
        Other
    }
    public class Patient
    {
        public int PatientId { get; set; }

        public string FullName { get; set; } = string.Empty;

        public DateOnly DateOfBirth { get; set; }

        public GenderType Gender { get; set; }

        public string PhoneNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string InsuranceId { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; }

        public Patient()
        {
            CreatedDate = DateTime.Now;
        }
        public bool IsValidEmail()
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(
       Email,
       pattern,
       RegexOptions.None,
       TimeSpan.FromSeconds(1)
   );
        }
        public bool IsValidPhoneNumber()
        {
            string pattern = @"^[0-9]{10}$";
            return Regex.IsMatch(
       PhoneNumber,
       pattern,
       RegexOptions.None,
       TimeSpan.FromSeconds(1)
   );
        }
        public bool IsValidName()
        {
            if (string.IsNullOrWhiteSpace(FullName))
                return false;

            string pattern = @"^[a-zA-Z\s\.\-]{3,50}$";
            return Regex.IsMatch(
      FullName,
      pattern,
      RegexOptions.None,
      TimeSpan.FromSeconds(1)
  );
        }

        public int GetAge()
        {
            int age = DateTime.Today.Year - DateOfBirth.Year;

            if (DateOnly.FromDateTime(DateTime.Today) < DateOfBirth.AddYears(age))
            {
                age--;
            }

            return age;
        }

        public string GetProfileSummary()
        {
            Console.WriteLine();
            Console.WriteLine($"Patient Name: {FullName}");
            Console.WriteLine($"Patient DOB: {DateOfBirth}");
            Console.WriteLine($"Patient Gender: {Gender}");
            Console.WriteLine($"Patient Age: {GetAge()}");
            Console.WriteLine($"Patient PhoneNo: {PhoneNumber}");
            Console.WriteLine($"Patient Email: {Email}");
            Console.WriteLine($"Patient Insurence Id: {InsuranceId}");
            Console.WriteLine();

            return "Patient Registered Successfully";

        }
    }
}