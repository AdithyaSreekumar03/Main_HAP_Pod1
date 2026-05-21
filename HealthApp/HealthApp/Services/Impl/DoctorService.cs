using System;
using System.Collections.Generic;
using POD1_NET_ConsoleApp.Models;
using POD1_NET_ConsoleApp.Repositories.Interfaces;
using POD1_NET_ConsoleApp.Service.Interfaces;

namespace POD1_NET_ConsoleApp.Service.Impl
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _repo;

        public DoctorService(IDoctorRepository repo)
        {
            _repo = repo;
        }

        // ✅ ADD
        public string AddDoctor(Doctor doctor)
        {
            return _repo.AddDoctor(doctor);
        }

        // ✅ DELETE
        public string DeleteDoctor(int doctorId)
        {
            return _repo.DeleteDoctor(doctorId);
        }

        // ✅ GET ALL
        public List<Doctor> GetAllDoctors()
        {
            return _repo.GetAllDoctors();
        }

        // ✅ AVAILABLE DOCTORS
        public List<Doctor> GetAvailableDoctors()
        {
            return _repo.GetAvailableDoctors();
        }

        // ✅ GET BY ID
        public Doctor GetDoctorById(int doctorId)
        {
            return _repo.GetDoctorById(doctorId);
        }

        // ✅ SEARCH BY SPECIALISATION
        public List<Doctor> GetDoctorsBySpecialisation(string specialisation)
        {
            return _repo.GetDoctorsBySpecialisation(specialisation);
        }

        // ✅ UPDATE
        public string UpdateDoctor(int id, Doctor doctor)
        {
            return _repo.UpdateDoctor(id, doctor);
        }
    }
}
