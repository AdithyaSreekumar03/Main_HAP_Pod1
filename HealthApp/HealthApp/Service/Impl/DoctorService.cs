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

            if (!result.Any())
            {
                throw new NoDoctorsRegisteredException("There are no Doctors registered");
            }
            return result;
        }

        public Doctor? GetDoctorById(int id)
        {

            var doctor = _repo.GetById(id);
            if (doctor == null)
            {
                throw new DoctorNotFoundException($"Doctor with id {id} not found");

            }
            return doctor;
        }

        public List<Doctor> SearchBySpecialisation(
     SpecialisationType specialisation)
        {
            return _repo.GetAll()
                .Where(d => d.Specialisation == specialisation)
                .ToList();
        }
        public string DeleteDoctorById(int id)
        {
            var doctor = _repo.DeleteDoctorById(id);

            if (doctor == null)
            {
                throw new Exceptions.DoctorNotFoundException(
                    $"Doctor with id {id} not found");
            }

            return $"Doctor with id {id} deleted successfully";
        }
        public string UpdateDoctorById(int id, Doctor doctor)
        {
            var updatedDoctor = _repo.UpdateDoctorById(id, doctor);

            if (updatedDoctor == null)
            {
                throw new DoctorNotFoundException(
                    $"Doctor with id {id} not found");
            }

            return $"Doctor with id {id} updated successfully";
        }

        public string ChangeDoctorStatus(int id, bool isActive)
        {
            var doctor = _repo.ChangeDoctorStatus(id, isActive);

            if (doctor == null)
            {
                throw new DoctorNotFoundException(
                    $"Doctor with id {id} not found");
            }

            return isActive
                ? $"Doctor with id {id} is now Active"
                : $"Doctor with id {id} is now Inactive";
        }
    }
}
