using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Model
{
    public class HealthRecord
    {
        public int RecordId { get; set; }

        public Patient Patient { get; set; } = default!;

        public Doctor Doctor { get; set; } = default!;

        public DateTime VisitDate { get; set; }

        public string Diagnosis { get; set; } = string.Empty;

        public string Prescription { get; set; } = string.Empty;

        public string Notes { get; set; } = string.Empty;

        public string GetSummary()
        {
            return
                $"Health Record ID: {RecordId}\n" +
                $"Date: {VisitDate}\n" +
                $"Patient: {Patient.FullName}\n" +
                $"Doctor: Dr. {Doctor.FullName}\n" +
                $"Diagnosis: {Diagnosis}\n" +
                $"Presription: {Prescription}\n" +
                $"Notes: {Notes}";
        }
    }
}