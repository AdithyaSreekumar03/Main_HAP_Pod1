using HealthApp.Constants;
using HealthApp.Exceptions;
using HealthApp.Models;
using HealthApp.Modules;
using HealthApp.Repositories.Interface;
using HealthApp.Service.Interface;
using HealthApp.Exceptions;


namespace HealthApp.Service.impl
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _repo;
        private int count_id = 1;
        public AppointmentService(IAppointmentRepository repo)
        {
            _repo = repo;
        }
        public Appointment BookAppointment(
            Patient patient,
            Doctor doctor,
            DateTime date,
            string slot)
        {
            if (!doctor.IsActive)
            {
                throw new DoctorUnavailableException("Doctor unavailable.");
            }

            if (!DateTime.TryParse(slot, out DateTime slotTime))
            {
                throw new Exception("Invalid slot format.");
            }

            DateTime appointmentDateTime = date.Date + slotTime.TimeOfDay;

            if (appointmentDateTime < DateTime.Now)
            {
                throw new PastDateException("Cannot book past date/time.");
            }


            bool alreadyBooked =_repo.GetAll().Any(a =>a.Doctor.doctorID ==doctor.doctorID 
            && a.ScheduledDate.Date == date.Date && a.TimeSlot == slot && a.Status !=AppointmentStatus.Cancelled);

            if (alreadyBooked)
            {
                throw new AppointmentConflictException(
                    "Slot already booked.");
            }
            Appointment appointment = new(){
                AppointmentId = count_id++,
                Patient = patient,
                Doctor = doctor,
                ScheduledDate = date,
                TimeSlot = slot
            };


            appointment.Confirm();
            _repo.Add(appointment);
            return appointment;
        }

        public void CancelAppointment(int appointmentId,string reason)
        {
            var appointment =_repo.GetById(appointmentId);
            if (appointment == null)
            {
                throw new Exception("Appointment not found.");
            }
            appointment.Cancel(reason);
        }
        public Appointment? GetAppointmentById(int id){
            return _repo.GetById(id);
        }
        public List<Appointment>GetAllAppointments()
        {
            return _repo.GetAll();
        }
        public List<Appointment>GetAppointmentsByPatient(int patientId)
        {
            return _repo.GetAll().Where(a =>a.Patient.PatientId ==patientId).ToList();
        }
        public List<Appointment> GetAppointmentsByDoctor(int doctorId)
        {
            return _repo.GetAll().Where(a => a.Doctor.doctorID == doctorId).ToList();
        }

    }

}