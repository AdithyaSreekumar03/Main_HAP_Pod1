using System;
using System.Collections.Generic;
using System.Text;
using HealthApp.Models;

namespace HealthApp.Database
{
 
    public class HealthRecordsDB
    {
        public List<HealthRecord> HealthRecords { get; set; } = new List<HealthRecord>
        {
           new HealthRecord{RecordId = 2,Patient = "Alice",Doctor = "Dr. Kumar",VisitDate = DateTime.Now,
        Diagnosis = "Cold",Prescription = "Cough syrup",Notes = "Drink warm water"},
            new HealthRecord{RecordId = 1,Patient = "John",Doctor = "Dr. Smith",VisitDate = DateTime.Now,
        Diagnosis = "Fever",Prescription = "Paracetamol",Notes = "Take rest"}
        };

    }
}
