using HealthApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Service.Interface
{
    public interface IDoctorService
    {
        void AddDoctor(Doctor doctor);
        List<Doctor> GetAllDoctors();
        Doctor? GetDoctorById(int id);
        List<Doctor> SearchBySpecialisation(SpecialisationType specialisation);
        string ChangeDoctorStatus(int id, bool isActive);
    }
}