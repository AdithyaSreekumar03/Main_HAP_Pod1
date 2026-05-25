using HealthApp.Model;

namespace HealthApp.Repository.Interface
{
    public interface IDoctorRepository
    {
        void Add(Doctor doctor);

        List<Doctor> GetAll();

        Doctor? GetById(int id);

 

        //  Return object after status change
        Doctor? ChangeDoctorStatus(int id, bool isActive);
    }
}

