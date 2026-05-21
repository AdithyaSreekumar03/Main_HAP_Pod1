using System.Collections.Generic;
using POD1_NET_ConsoleApp.Models;

namespace POD1_NET_ConsoleApp.Database
{
    public class HealthRecordDb
    {
        public List<HealthRecords> Records { get; set; } = new List<HealthRecords>();
    }
}