using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Models
{
    public enum AppointmentStatus
    {
        Pending,
        Cancelled,
        Confirmed,
        Completed
    }
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public Patient Patient { get; set; } = default!;
        public Doctor Doctor { get; set; } = default!;
        public DateTime ScheduledDate { get; set; }
        public string TimeSlot { get; set; } = string.Empty;
        public string? CancellationReason { get; private set; }
        public AppointmentStatus Status { get; private set; } = AppointmentStatus.Pending;

        public void Confirm()
        {
            if (Status == AppointmentStatus.Cancelled)
            {
                Console.WriteLine("Cannot Confirm a Cancelled Appointment");
                return;
            }
            Status = AppointmentStatus.Confirmed;
        }

        public void Cancel(string reason)
        {
            if (Status == AppointmentStatus.Completed)
            {
                Console.WriteLine("Cannot Cancel a Completed Appointment");
                return;
            }
            Status = AppointmentStatus.Cancelled;
            CancellationReason = reason;

        }

        public void Complete()
        {
            if (Status == AppointmentStatus.Cancelled || Status == AppointmentStatus.Pending)
            {
                Console.WriteLine("Cannot Complete Cancelled or Pending Appointments");
                return;
            }
            Status = AppointmentStatus.Completed;
        }
        public void GetDetails()
        {
            Console.WriteLine($"Appointment ID: {AppointmentId}\n" +
                $"Patient Name: {Patient.FullName}\n" +
                $"Doctor Name:Dr.{Doctor.FullName} ({Doctor.Specialisation})\n" +
                $"Date: {ScheduledDate:dd-MM-yyyy}\n" +
                $"TimeSlot: {TimeSlot}\n" +
                $"Status: {Status}\n" +
                $"Cancellation Reason:{CancellationReason ?? "N/A"}");

        }
    }
}
