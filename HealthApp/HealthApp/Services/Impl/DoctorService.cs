using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using HealthApp.Service.Interface;
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

        // ADD DOCTOR
        public void AddDoctor(Doctor doctor)
        {

            var doctors = _repo.GetAll();

            if (doctors.Count != 0)
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

        // GET ALL DOCTORS
        public List<Doctor> GetAllDoctors()
        {
            var doctors = _repo.GetAll();

            if (doctors == null || doctors.Count == 0)
            {
                throw new NoDoctorsRegisteredException("No doctors found.");
            }

            return doctors;
        }

        // GET BY ID
        public Doctor? GetDoctorById(int id)
        {
            var doctor = _repo.GetById(id);

            if (doctor == null)
            {
                throw new DoctorNotFoundException($"Doctor with id {id} not found");
            }

            return doctor;
        }

        //  SEARCH BY SPECIALISATION
        public List<Doctor> SearchBySpecialisation(SpecialisationType specialisation)
        {
            var doctors = _repo.GetAll();

            var result = doctors
                .Where(d => d.Specialisation == specialisation)
                .ToList();

            if (result.Count == 0)
            {
                throw new DoctorNotFoundException($"No doctors found with specialization {specialisation}");
            }

            return result;
        }

    

        //  CHANGE STATUS
        public string ChangeDoctorStatus(int id, bool isActive)
        {
            var doctor = _repo.ChangeDoctorStatus(id, isActive);

            if (doctor == null)
            {
                throw new DoctorNotFoundException($"Doctor with id {id} not found");
            }

            return isActive
                ? $"Doctor with id {id} is now Active"
                : $"Doctor with id {id} is now Inactive";
        }
    }
}