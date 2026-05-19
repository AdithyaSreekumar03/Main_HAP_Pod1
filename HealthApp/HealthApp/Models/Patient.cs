using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string InsuranceId { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return $"ID: {PatientId}, Name: {FullName}, Gender: {Gender}, Age: {Age}, Phone: {PhoneNumber}";
        }
    }
}
