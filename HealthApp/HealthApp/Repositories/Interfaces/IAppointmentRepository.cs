using System;
using System.Collections.Generic;
using POD1_NET_ConsoleApp.Models;

namespace POD1_NET_ConsoleApp.Repository.Interfaces
{
    public interface IAppointmentRepository
    {
        string BookAppointment(Appointment appointment);
        List<Appointment> GetAppointmentsByPatient(int patientId);
        List<Appointment> GetAppointmentsByDoctor(int doctorId);
        string ConfirmAppointment(int id);
        string CancelAppointment(int id);
    }
}