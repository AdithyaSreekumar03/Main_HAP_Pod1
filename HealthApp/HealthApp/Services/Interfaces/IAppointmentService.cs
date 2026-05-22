using HealthApp.Model;
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

        List<Appointment> GetAppointmentsByPatient(
            int patientId);
    }
}