using HealthApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Databases
{
    public class HealthRecordDb
    {
        public List<HealthRecords> Records = new List<HealthRecords>
         {
                new HealthRecords
                {
                    RecordId = 1,
                    Patient = "John",
                    Doctor = "Dr. Smith",
                    VisitDate = new DateTime(2026,5,10),
                    Diagnosis = "Fever",
                    Prescription = "Tablet",
                    Notes = "Rest"
                },
                new HealthRecords
                {
                    RecordId = 2,
                    Patient = "Ravi",
                    Doctor = "Dr. Smith",
                    VisitDate = new DateTime(2026,5,15),
                    Diagnosis = "Cold",
                    Prescription = "Syrup",
                    Notes = "Fluids"
                },
                new HealthRecords
                {
                    RecordId = 3,
                    Patient = "Anita",
                    Doctor = "Dr. Kumar",
                    VisitDate = new DateTime(2026,5,12),
                    Diagnosis = "Headache",
                    Prescription = "Tablet",
                    Notes = "Rest"
                }
                ,
                new HealthRecords
                {
                    RecordId = 4,
                    Patient = "Rishi",
                    Doctor = "Dr. Kumar",
                    VisitDate = new DateTime(2026,6,12),
                    Diagnosis = "Headache",
                    Prescription = "Tablet",
                    Notes = "Rest"
                }
        };
    } 
}

