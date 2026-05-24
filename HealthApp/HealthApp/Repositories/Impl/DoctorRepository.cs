using HealthApp.Database;
using HealthApp.Model;
using HealthApp.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace HealthApp.Repository.Impl
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DoctorDb _doctorDb;

        public DoctorRepository(DoctorDb doctorDb)
        {
            _doctorDb = doctorDb;
        }

        public void Add(Doctor doctor)
        {
            _doctorDb.Doctors.Add(doctor);
        }

        public List<Doctor> GetAll()
        {
            return _doctorDb.Doctors;
        }

        public Doctor? GetById(int id)
        {
            return _doctorDb.Doctors
                .FirstOrDefault(d => d.DoctorId == id);
        }

        public Doctor? DeleteDoctorById(int id)
        {
            var doctor = _doctorDb.Doctors
                .FirstOrDefault(d => d.DoctorId == id);

            if (doctor != null)
            {
                _doctorDb.Doctors.Remove(doctor);
            }

            return doctor;
        }

        public Doctor? UpdateDoctorById(int id, Doctor doctor)
        {
            var existing = _doctorDb.Doctors
                .FirstOrDefault(d => d.DoctorId == id);

            if (existing != null)
            {
                existing.FullName = doctor.FullName;
                existing.Specialisation = doctor.Specialisation;
                existing.DoctorPhoneNo = doctor.DoctorPhoneNo;
                existing.DoctorEmail = doctor.DoctorEmail;
                existing.YearsOfExperience = doctor.YearsOfExperience;
                existing.ConsultationFee = doctor.ConsultationFee;
            }

            return existing;
        }

        public Doctor? ChangeDoctorStatus(int id, bool isActive)
        {
            var doctor = _doctorDb.Doctors
                .FirstOrDefault(d => d.DoctorId == id);

            if (doctor != null)
            {
                doctor.IsActive = isActive;
            }

            return doctor;
        }
    }
}
