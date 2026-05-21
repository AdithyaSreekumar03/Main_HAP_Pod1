using System;
using System.Collections.Generic;
using POD1_NET_ConsoleApp.Models;

namespace POD1_NET_ConsoleApp.Repositories.Interfaces
{
    public interface IDoctorRepository
    {
        string AddDoctor(Doctor doctor);
        string DeleteDoctor(int doctorId);
        List<Doctor> GetAllDoctors();
        List<Doctor> GetAvailableDoctors();
        Doctor GetDoctorById(int doctorId);
        List<Doctor> GetDoctorsBySpecialisation(string specialisation);
        string UpdateDoctor(int id, Doctor doctor);
    }
}