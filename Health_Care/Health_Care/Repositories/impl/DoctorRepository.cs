using HealthApp.Database;
using HealthApp.Exceptions;
using HealthApp.Models;
using HealthApp.Modules;
using HealthApp.Repositories.Interface;



namespace HealthApp.Repositories.impl
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DoctorDB _doctorDb;

        public DoctorRepository(DoctorDB db)
        {
            _doctorDb = db;
        }
        public string AddDoctor(Doctor doctor)
        {
            _doctorDb.doctors.Add(doctor);
            return "Doctor added successfully";

        }

        public string DeleteDoctor(int doctorId)
        {
            var doctor = _doctorDb.doctors.Find(d => d.doctorID == doctorId);
            if (doctor != null)
            {
                _doctorDb.doctors.Remove(doctor);
                return "Deleted successfully";
            }
            throw new DoctorNotFoundException($"Doctor with id {doctorId} not found");
        }

        public List<Doctor> GetAllDoctors()
        {
            return _doctorDb.doctors;
        }

        public List<Doctor> GetAvailableDoctors()
        {
            var get_available= _doctorDb.doctors.Where(d => d.IsActive).ToList();
            if(get_available.Count > 0)
            {
                return get_available;
            }
            return null;
        }

        public Doctor GetDoctorById(int doctorId)
        {
            var result = _doctorDb.doctors.Find(d => d.doctorID == doctorId);

            if (result == null)
            {
                throw new PatientNotFoundException($"Patient with ID {doctorId} not found");
            }
            return result;
        }

        public List<Doctor> GetDoctorsBySpecialisation(string specialisation)
        {
            var result = _doctorDb.doctors.Where(d => d.Specialisation ==specialisation).ToList();
            if (result.Count > 0)
            {
                return result;
            }
            return null;
        }

        public string GetDoctorScheduleSummary(int doctorId)
        {

            var doctor = GetDoctorById(doctorId);
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

            var result = _doctorDb.doctors.FirstOrDefault(d => d.doctorID == id);

            if (result == null)
                throw new DoctorNotFoundException($"Doctor with id {id} not found");

            result.doctorName = doctor.doctorName;
            result.Specialisation = doctor.Specialisation;
            result.YearsOfExperience = doctor.YearsOfExperience;
            result.ConsultationFee = doctor.ConsultationFee;
            result.IsActive = doctor.IsActive;

            return "Doctor updated successfully";

        }
    }
}
