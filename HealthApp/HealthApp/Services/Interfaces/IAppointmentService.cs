using System.Collections.Generic;
using POD1_NET_ConsoleApp.Models;

namespace POD1_NET_ConsoleApp.Services.Interfaces
{
    public interface IAppointmentService
    {
        string BookAppointment(Appointment appointment);
        List<Appointment> GetAppointmentsByPatient(int patientId);
        List<Appointment> GetAppointmentsByDoctor(int doctorId);
        string ConfirmAppointment(int id);
        string CancelAppointment(int id);
    }
}
