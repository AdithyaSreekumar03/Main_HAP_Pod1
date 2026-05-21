using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace HealthApp.Models
{
    public class HealthRecords
    {
        public int RecordId { get; set; }
        public string Patient { get; set; }
        public string Doctor { get; set; }
        public DateTime VisitDate { get; set; }
        public string Diagnosis { get; set; }
        public string Prescription { get; set; }
        public string Notes { get; set; }
        public string GetSummary() {

            return $"Record ID: {RecordId}\n" +
                           $"Patient: {Patient}\n" +
                           $"Doctor: {Doctor}\n" +
                           $"Visit Date: {VisitDate:dd-MM-yyyy}\n" +
                           $"Diagnosis: {Diagnosis}\n" +
                           $"Prescription: {Prescription}\n" +
                           $"Notes: {Notes}\n";

        }
    }
}
