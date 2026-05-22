using HealthApp.Exceptions;
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

        public void AddDoctor(Doctor doctor)
        {

            if (_repo.GetAll().Any())
            {
                doctor.DoctorId =
                _repo.GetAll().Max(d => d.DoctorId) + 1;
            }
            else
            {
                doctor.DoctorId = 1;
            }

            doctor.IsActive = true;

            _repo.Add(doctor);
        }

        public List<Doctor> GetAllDoctors()
        {
            var result = _repo.GetAll();

            if (result == null)
            {
                throw new NoDoctorsRegisteredException("There are no Doctors registered");
            }
            return result;
        }

        public Doctor? GetDoctorById(int id)
        {
            return _repo.GetById(id);
        }

        public List<Doctor> SearchBySpecialisation(SpecialisationType specialisation)
        {
            return _repo.GetAll()
                .Where(d => d.Specialisation == specialisation)
                .ToList();
        }
        public string DeleteDoctorById(int id)
        {
            return _repo.DeleteDoctorById(id);
        }
        public string UpdateDoctorById(int id, Doctor doctor)
        {
            return _repo.UpdateDoctorById(id, doctor);
        }
    }
}
