using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthApp.Service.Impl
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _repo;

        public DoctorService(IDoctorRepository repo)
        {
            _repo = repo;
        }

        // ✅ ADD DOCTOR
        public void AddDoctor(Doctor doctor)
        {
            var doctors = _repo.GetAll();

            if (doctors.Any())
            {
                doctor.DoctorId = doctors.Max(d => d.DoctorId) + 1;
            }
            else
            {
                doctor.DoctorId = 1;
            }

            doctor.IsActive = true;

            _repo.Add(doctor);
        }

        // ✅ GET ALL DOCTORS (IMPROVED)
        public List<Doctor> GetAllDoctors()
        {
            var result = _repo.GetAll();

            // ✅ FIX: Check BOTH null and empty
            if (result == null || !result.Any())
            {
                throw new NoDoctorsRegisteredException("No doctors found");
            }

            return result;
        }

        // ✅ GET BY ID
        public Doctor? GetDoctorById(int id)
        {
            // Repo already throws exception if not found ✅
            return _repo.GetById(id);
        }

        // ✅ SEARCH
        public List<Doctor> SearchBySpecialisation(SpecialisationType specialisation)
        {
            var doctors = _repo.GetAll();

            var filtered = doctors
                .Where(d => d.Specialisation == specialisation)
                .ToList();

            return filtered;
        }

        // ✅ DELETE
        public string DeleteDoctorById(int id)
        {
            // Exception handled in repo ✅
            return _repo.DeleteDoctorById(id);
        }

        // ✅ UPDATE
        public string UpdateDoctorById(int id, Doctor doctor)
        {
            return _repo.UpdateDoctorById(id, doctor);
        }

        // ✅ CHANGE STATUS
        public string ChangeDoctorStatus(int id, bool isActive)
        {
            return _repo.ChangeDoctorStatus(id, isActive);
        }
    }
}