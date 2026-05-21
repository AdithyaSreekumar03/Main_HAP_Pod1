using HealthApp.Models;
using HealthApp.Modules;


namespace HealthApp.Service.Interface
{
    public interface IAppointmentService 
    {

        Appointment BookAppointment(

            //check
            Patient patient,
            Doctor doctor,
            DateTime date,
            string slot
            );


        void CancelAppointment(
            int appointmentId,
            string reason
            );

        Appointment? GetAppointmentById(int id);
        List<Appointment> GetAllAppointments();
        List<Appointment> GetAppointmentsByPatient(int patientId);
        List<Appointment> GetAppointmentsByDoctor(int patientId);


    }

}