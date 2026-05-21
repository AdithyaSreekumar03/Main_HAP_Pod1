using System;

namespace POD1_NET_ConsoleApp.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{PatientId} | {FullName} | {DateOfBirth:yyyy-MM-dd} | {Gender} | {Age}";
        }
    }
}