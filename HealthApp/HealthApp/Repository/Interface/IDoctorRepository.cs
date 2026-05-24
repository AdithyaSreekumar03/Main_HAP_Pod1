using HealthApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Repository.Interface
{
    public interface IDoctorRepository
    {
        void Add(Doctor doctor);

        List<Doctor> GetAll();

        Doctor? GetById(int id);
        string DeleteDoctorById(int id);
        string UpdateDoctorById(int id, Doctor doctor);
        string ChangeDoctorStatus(int id, bool isActive);
    }
}
