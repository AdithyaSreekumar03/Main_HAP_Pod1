using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string FullName { get; set; }
        public string Specialisation { get; set; }
        public int YearsOfExperience { get; set; }
        public decimal ConsultationFee { get; set; }
        public bool IsActive { get; set; }

        public bool IsAvailable(DateTime date)
        {
            int Appointments = 3;
            if (IsActive && date.DayOfWeek != DayOfWeek.Sunday && Appointments < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetScheduleSummary()
        {
            int upcomingAppointments = 3;
            return FullName + " has " + upcomingAppointments + " upcoming Appointments";
        }
    }
}
