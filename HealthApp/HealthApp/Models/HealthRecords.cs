using System;
using System.Collections.Generic;
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
    }
}
