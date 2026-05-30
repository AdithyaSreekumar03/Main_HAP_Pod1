using HealthApp.Databases;
using HealthApp.Exceptions;
using HealthApp.Model;

using HealthApp.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

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
            var doctor = _doctorDb.Doctors
                .FirstOrDefault(d => d.DoctorId == id);

            return doctor;
        }

        public Doctor? ChangeDoctorStatus(int id, bool isActive)
        {
            var doctor = _doctorDb.Doctors
                                  .FirstOrDefault(d => d.DoctorId == id);

            if (doctor == null)
            {
                return null;
            }

            doctor.IsActive = isActive;

            return doctor;
        }
    }
}