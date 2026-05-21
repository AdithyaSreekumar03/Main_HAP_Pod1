using System;

namespace POD1_NET_ConsoleApp.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; } // Booked / Confirmed / Cancelled

        public override string ToString()
        {
            return $"{AppointmentId} | Patient: {PatientId} | Doctor: {DoctorId} | Date: {AppointmentDate} | Status: {Status}";
        }
    }
}