using HealthApp.Database;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace HealthApp.Repository.Impl
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppointmentDb _appointmentDb;
        public AppointmentRepository(AppointmentDb appointmentDb)
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