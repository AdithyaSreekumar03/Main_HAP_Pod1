using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Models
{
    public class HealthRecord 
    {
        public int RecordId { get; set; }
        public string Patient { get; set; } = string.Empty;
        public string Doctor { get; set; } = string.Empty;
        public DateTime VisitDate { get; set; }
        public string Diagnosis { get; set; } = string.Empty;
        public string Prescription { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"RecordId: {RecordId} \n    Patient: {Patient} visited {Doctor} on {VisitDate.ToShortDateString()} \n    Suggested Diagnosis: {Diagnosis} \n    Prescriptions: {Prescription}";
        }
    }
}
