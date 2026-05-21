using System;
using System.Linq;
using System.Collections.Generic;
using POD1_NET_ConsoleApp.Models;
using POD1_NET_ConsoleApp.Database;
using POD1_NET_ConsoleApp.Repository.Interfaces;

namespace POD1_NET_ConsoleApp.Repository.Impl
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly AppointmentDb _db;

        public AppointmentRepository(AppointmentDb db)
        {
            _db = db;
        }

        //  BOOK
        public string BookAppointment(Appointment appointment)
        {
            appointment.AppointmentId = _db.Appointments.Count == 0
                ? 1
                : _db.Appointments.Max(a => a.AppointmentId) + 1;

            appointment.Status = "Booked";

            _db.Appointments.Add(appointment);

            return "Appointment booked successfully";
        }

        // GET BY PATIENT
        public List<Appointment> GetAppointmentsByPatient(int patientId)
        {
            return _db.Appointments
                .Where(a => a.PatientId == patientId)
                .ToList();
        }

        //  GET BY DOCTOR
        public List<Appointment> GetAppointmentsByDoctor(int doctorId)
        {
            return _db.Appointments
                .Where(a => a.DoctorId == doctorId)
                .ToList();
        }

        //  CONFIRM
        public string ConfirmAppointment(int id)
        {
            var app = _db.Appointments.FirstOrDefault(a => a.AppointmentId == id);

            if (app == null)
                return "Appointment not found";

            app.Status = "Confirmed";

            return " Appointment Confirmed";
        }

        //  CANCEL 
        public string CancelAppointment(int id)
        {
            var app = _db.Appointments.FirstOrDefault(a => a.AppointmentId == id);

            if (app == null)
                return "Appointment not found";

            app.Status = "Cancelled";

            return " Appointment Cancelled";
        }
    }
}