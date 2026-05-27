using HealthApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Service.Interface
{
    public interface IAppointmentService
    {
        Appointment BookAppointment(
            Patient patient,
            Doctor doctor,
            DateTime date,
            string slot);

        void CancelAppointment(
            int appointmentId,
            string reason);

        Appointment? GetAppointmentById(int id);
        List<Appointment> GetAllAppointments();
        List<Appointment> GetAppointmentsByPatient(int patientId);
        List<string> CheckDoctorAvailability(int doctorId, DateTime date);
        List<Appointment> GetUpcomingAppointmentsByDoctor(int doctorId, DateTime fromDate, DateTime toDate);
        List<Appointment> GetPendingAppointmentsByDoctor(int doctorId);
        void ConfirmAppointment(int appointmentId);
    }
}