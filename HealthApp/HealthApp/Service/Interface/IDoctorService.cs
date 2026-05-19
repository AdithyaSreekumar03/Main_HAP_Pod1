using HealthApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Service.Interface
{
    public interface IDoctorService
    {
        public string AddDoctor(Doctor doctor);
        public string DeleteDoctor(int doctorId);
        public List<Doctor> GetAllDoctors();
        public List<Doctor> GetAvailableDoctors();
        public Doctor GetDoctorById(int doctorId);
        public List<Doctor> GetDoctorsBySpecialisation(string specialisation);
        public string GetDoctorScheduleSummary(int doctorId);
        public bool IsDoctorAvailable(int doctorId, DateTime date);
        public string UpdateDoctor(int id, Doctor doctor);
    }
}
