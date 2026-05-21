using HealthApp.Database;
using HealthApp.Models;
using HealthApp.Repositories.Interface;


namespace HealthApp.Repositories.impl
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppointmentDB _appointmentDb;
        public AppointmentRepository(AppointmentDB appointmentDb)
        {
            _appointmentDb = appointmentDb;
        }

        public void Add(Appointment appointment)

        {
            _appointmentDb.Appointments.Add(appointment);
        }
        public List<Appointment> GetAll()
        {
            return _appointmentDb.Appointments;
        }
        public Appointment? GetById(int id)

        {
            return _appointmentDb.Appointments.FirstOrDefault(a => a.AppointmentId == id);
        }
    }

}