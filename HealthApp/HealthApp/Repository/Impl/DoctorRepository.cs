using HealthApp.Databases;
using HealthApp.Exceptions;
using HealthApp.Models;
using HealthApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Repository.Impl
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DoctorDb _doctorDb;

        public DoctorRepository(DoctorDb db)
        {
            _doctorDb = db;
        }
        public string AddDoctor(Doctor doctor)
        {
            doctor.DoctorId = _doctorDb.doctorDb.Count == 0 ? 1 : _doctorDb.doctorDb.Max(p => p.DoctorId) + 1;
            _doctorDb.doctorDb.Add(doctor);
            return "Doctor added successfully";

        }

        public string DeleteDoctor(int doctorId)
        {

            var doctor = _doctorDb.doctorDb.FirstOrDefault(d => d.DoctorId == doctorId);

            if (doctor == null)
                throw new DoctorNotFoundException($"Doctor with id {doctorId} not found");

            _doctorDb.doctorDb.Remove(doctor);
            return "Doctor deleted successfully";

        }

        public List<Doctor> GetAllDoctors()
        {
            return _doctorDb.doctorDb;
        }

        public List<Doctor> GetAvailableDoctors()
        {
            return _doctorDb.doctorDb.Where(d => d.IsActive).ToList();
        }

        public Doctor GetDoctorById(int doctorId)
        {
            var result = _doctorDb.doctorDb.Find(d => d.DoctorId == doctorId);
            if (result == null)
                throw new DoctorNotFoundException($"Doctor with id {doctorId} not found");
            return result;
        }

        public List<Doctor> GetDoctorsBySpecialisation(string specialisation)
        {

            return (_doctorDb.doctorDb
                    .Where(d => d.Specialisation.Equals(specialisation, StringComparison.OrdinalIgnoreCase))
                    .ToList());
        }

        public string GetDoctorScheduleSummary(int doctorId)
        {

            var doctor = GetDoctorById(doctorId);

            //if (doctor == null)
            //    throw new DoctorNotFoundException($"Doctor with id {doctorId} not found");

            return doctor.GetScheduleSummary();
        }

        public bool IsDoctorAvailable(int doctorId, DateTime date)
        {
            var doctor = GetDoctorById(doctorId);

            if (doctor == null)
                throw new DoctorNotFoundException($"Doctor with id {doctorId} not found");

            return doctor.IsAvailable(date);

        }

        public string UpdateDoctor(int id, Doctor doctor)
        {

            var existing = _doctorDb.doctorDb.FirstOrDefault(d => d.DoctorId == id);

            if (existing == null)
                throw new DoctorNotFoundException($"Doctor with id {id} not found");

            existing.FullName = doctor.FullName;
            existing.Specialisation = doctor.Specialisation;
            existing.YearsOfExperience = doctor.YearsOfExperience;
            existing.ConsultationFee = doctor.ConsultationFee;
            existing.IsActive = doctor.IsActive;

            return "Doctor updated successfully";

        }
    }
}
