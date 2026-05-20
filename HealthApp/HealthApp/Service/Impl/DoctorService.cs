using HealthApp.Models;
using HealthApp.Repository.Interface;
using HealthApp.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Service.Impl
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _repo;

        public DoctorService(IDoctorRepository repo)
        {
            _repo = repo;
        }

        public string AddDoctor(Doctor doctor)
        {
            return _repo.AddDoctor(doctor);
        }

        public string DeleteDoctor(int doctorId)
        {
            return _repo.DeleteDoctor(doctorId);
        }

        public List<Doctor> GetAllDoctors()
        {
            return _repo.GetAllDoctors();
        }

        public List<Doctor> GetAvailableDoctors()
        {
            return _repo.GetAvailableDoctors();
        }

        public Doctor GetDoctorById(int doctorId)
        {
            return _repo.GetDoctorById(doctorId);
        }

        public List<Doctor> GetDoctorsBySpecialisation(string specialisation)
        {
            return _repo.GetDoctorsBySpecialisation(specialisation);
        }
        public string GetDoctorScheduleSummary(int doctorId)
        {
            return _repo.GetDoctorScheduleSummary(doctorId);
        }

        public bool IsDoctorAvailable(int doctorId, DateTime date)
        {
            return _repo.IsDoctorAvailable(doctorId, date);
        }

        public string UpdateDoctor(int id, Doctor doctor)
        {
            return _repo.UpdateDoctor(id, doctor);
        }
    }
}
