using System.Collections.Generic;
using POD1_NET_ConsoleApp.Models;
using POD1_NET_ConsoleApp.Repository.Interfaces;
using POD1_NET_ConsoleApp.Services.Interfaces;

namespace POD1_NET_ConsoleApp.Services.Impl
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _repo;

        public AppointmentService(IAppointmentRepository repo)
        {
            _repo = repo;
        }

        public string BookAppointment(Appointment appointment)
        {
            return _repo.BookAppointment(appointment);
        }

        public List<Appointment> GetAppointmentsByPatient(int patientId)
        {
            return _repo.GetAppointmentsByPatient(patientId);
        }

        public List<Appointment> GetAppointmentsByDoctor(int doctorId)
        {
            return _repo.GetAppointmentsByDoctor(doctorId);
        }

        public string ConfirmAppointment(int id)
        {
            return _repo.ConfirmAppointment(id);
        }

        public string CancelAppointment(int id)
        {
            return _repo.CancelAppointment(id);
        }
    }
}