using HealthApp.Database;
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
            if (doctor == null)
            {
                throw new DoctorNotFoundException($"Doctor with id {id} not found");

            }
            return doctor;
        }
        public string DeleteDoctorById(int id)
        {

            var doctor = _doctorDb.Doctors.FirstOrDefault(p => p.DoctorId == id);
            if (doctor == null)
            {
                throw new Exceptions.DoctorNotFoundException($"Doctor with {id} not found");
            }
            _doctorDb.Doctors.Remove(doctor);
            return $"Doctor with id {id} deleted successfully";
        }
        public string UpdateDoctorById(int id, Doctor doctor)
        {
            var doc = _doctorDb.Doctors.FirstOrDefault(dc => dc.DoctorId == id);
            if (doc == null)
            {
                throw new DoctorNotFoundException($"Doctor with id {id} not found");
            }
            doc.FullName = doctor.FullName;
            doc.Specialisation = doctor.Specialisation;
            doc.DoctorPhoneNo = doctor.DoctorPhoneNo;
            doc.DoctorEmail = doctor.DoctorEmail;
            doc.YearsOfExperience = doctor.YearsOfExperience;
            doc.ConsultationFee = doctor.ConsultationFee;
            return $"Doctor with id {id} updated successfully";


        }

        public string ChangeDoctorStatus(int id, bool isActive)
        {
            var doctor = _doctorDb.Doctors
                .FirstOrDefault(d => d.DoctorId == id);

            if (doctor == null)
            {
                throw new DoctorNotFoundException(
                    $"Doctor with id {id} not found");
            }

            doctor.IsActive = isActive;

            return isActive
                ? $"Doctor with id {id} is now Active"
                : $"Doctor with id {id} is now Inactive";
        }
    }
}
