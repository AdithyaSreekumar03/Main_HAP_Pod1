using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HealthApp.Models
{
    public class Doctor
    {

        public int doctorID { get; set; }
        public string doctorName { get; set; } = string.Empty;
        public string Specialisation { get; set; } = string.Empty;
        public int YearsOfExperience { get; set; }
        public int ConsultationFee { get; set; }
        public bool IsActive { get; set; }

        public List<DateTime> Appointments = new List<DateTime>();


        public bool IsAvailable(DateTime dateTime)
        {
            return !Appointments.Contains(dateTime);
        }

        public string GetScheduleSummary()
        {
            var todayAppointments = Appointments
                .Where(ap => ap.Date == DateTime.Today);

            int upcoming = todayAppointments.Count(ap => ap > DateTime.Now);
            int completed = todayAppointments.Count(ap => ap <= DateTime.Now);

            return $"Completed: {completed} , Upcoming: {upcoming}";
        }


        public override string ToString()
        {
            return $"Doctor_ID: {doctorID}, Doctor_Name: {doctorName}, Specialization: {Specialisation}, Experience: {YearsOfExperience} years, Fee: {ConsultationFee}, Active: {IsActive}";
        }
    }
}