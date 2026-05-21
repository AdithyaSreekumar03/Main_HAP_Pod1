using HealthApp.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HealthApp.Modules
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public int Age {  get; set; }
        public string Gender { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string InsuranceId { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }



        public bool IsNameValid(string name)
        {
            if (name.Length <= 2 || name.Length >= 50)
                return false;

            foreach (char c in name)
            {
                if (!(char.IsLetter(c) || c == ' ' || c == ','))
                    return false;
            }
            return true;
        }

        public bool IsPhoneNumberValid(string phoneNumber)
        {
            if (phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit))
            {
                return false;
            }
            return true;
        }



        public int CalculateAge(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
            {
                age--;
            }

            return age;
        }

        public override string ToString()
        {
            return $"ID: {PatientId}, Name: {FullName}, Gender: {Gender}, Age: {Age}, Phone: {PhoneNumber}";
        }
    }
}
