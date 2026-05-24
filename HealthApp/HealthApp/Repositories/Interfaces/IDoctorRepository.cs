using HealthApp.Model;
using HealthApp.Model;

namespace HealthApp.Repository.Interface
{
    public interface IDoctorRepository
    {
        void Add(Doctor doctor);

        List<Doctor> GetAll();

        Doctor? GetById(int id);

        // ✅ Return object instead of string
        Doctor? DeleteDoctorById(int id);

        // ✅ Return updated object
        Doctor? UpdateDoctorById(int id, Doctor doctor);

        // ✅ Return object after status change
        Doctor? ChangeDoctorStatus(int id, bool isActive);
    }
}

