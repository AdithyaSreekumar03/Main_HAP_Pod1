using HealthApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Repository.Interface
{
    public interface IAppointmentRepository
    {
        void Add(Appointment appointment);
        List<Appointment> GetAll();
        Appointment? GetById(int id);
    }
}