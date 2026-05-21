using POD1_.NET_ConsoleApp.Exceptions;
using POD1_NET_ConsoleApp.Database;
using POD1_NET_ConsoleApp.Exceptions;
using POD1_NET_ConsoleApp.Models;
using POD1_NET_ConsoleApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POD1_NET_ConsoleApp.Repositories.Impl
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DoctorDb _doctorDb;

        public DoctorRepository(DoctorDb db)
        {
            _doctorDb = db;
        }

        //  ADD
        public string AddDoctor(Doctor doctor)
        {
            var exists = _doctorDb.Doctors.Any(d => d.DoctorId == doctor.DoctorId);

            if (exists)
                throw new Exception("Doctor ID already exists ❌");

            _doctorDb.Doctors.Add(doctor);

            return "Doctor added successfully";
        }

        //  DELETE
        public string DeleteDoctor(int doctorId)
        {
            var doctor = _doctorDb.Doctors.FirstOrDefault(d => d.DoctorId == doctorId);

            if (doctor == null)
                throw new DoctorNotFoundException("Doctor not found");

            _doctorDb.Doctors.Remove(doctor);

            return "Doctor deleted successfully";
        }

        //  GET ALL
        public List<Doctor> GetAllDoctors()
        {
            return _doctorDb.Doctors;
        }

        // AVAILABLE
        public List<Doctor> GetAvailableDoctors()
        {
            return _doctorDb.Doctors.Where(d => d.IsActive).ToList();
        }

        //  GET BY ID
        public Doctor GetDoctorById(int doctorId)
        {
            var doctor = _doctorDb.Doctors.FirstOrDefault(d => d.DoctorId == doctorId);

            if (doctor == null)
                throw new DoctorNotFoundException("Doctor not found");

            return doctor;
        }

        //  SEARCH
        public List<Doctor> GetDoctorsBySpecialisation(string specialisation)
        {
            return _doctorDb.Doctors
                .Where(d => d.Specialisation.Equals(specialisation, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        //  UPDATE
        public string UpdateDoctor(int id, Doctor doctor)
        {
            var existing = _doctorDb.Doctors.FirstOrDefault(d => d.DoctorId == id);

            if (existing == null)
                throw new DoctorNotFoundException("Doctor not found");

            existing.FullName = doctor.FullName;
            existing.Specialisation = doctor.Specialisation;
            existing.YearsOfExperience = doctor.YearsOfExperience;
            existing.ConsultationFee = doctor.ConsultationFee;
            existing.IsActive = doctor.IsActive;

            return "Doctor updated successfully";
        }
    }
}
