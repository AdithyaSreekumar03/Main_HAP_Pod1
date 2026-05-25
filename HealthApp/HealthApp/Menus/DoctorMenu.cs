using HealthApp.Exceptions;

using HealthApp.Model;

using HealthApp.Service.Interface;

using System.ComponentModel.DataAnnotations;

namespace HealthApp.Menu

{

    public class DoctorMenu

    {

        private readonly IDoctorService _doctorService;

        private readonly IAppointmentService _appointmentService;

        private readonly IHealthRecordService _healthService;

        public DoctorMenu(

            IDoctorService doctorService,

            IAppointmentService appointmentService,

            IHealthRecordService healthService)

        {

            _doctorService = doctorService;

            _appointmentService = appointmentService;

            _healthService = healthService;

        }

        public void Show()

        {

            while (true)

            {

                Console.Clear();

                Console.WriteLine("===== DOCTOR MENU =====");

                Console.WriteLine("1. Add Doctor");

                Console.WriteLine("2. View Appointment by Doctor");

                Console.WriteLine("3. Add Health Record");

                Console.WriteLine("4. Confirm Appointment");

                Console.WriteLine("5. Make Active / Inactive");

                Console.WriteLine("6. View Patient Health Record");

                Console.WriteLine("7. View Upcoming Appointments");

                Console.WriteLine("8. View Pending Appointments");

                Console.WriteLine("9. Cancel Appointment");

                Console.WriteLine("0. Exit to Main Menu");

                Console.Write("\nChoose: ");

                var choice = Console.ReadLine();

                switch (choice)

                {

                    case "1":

                        AddDoctor();

                        break;

                    case "2":

                        ViewAppointmentsByDoctor();

                        break;

                    case "3":

                        AddHealthRecord();

                        break;

                    case "4":

                        ConfirmAppointment();

                        break;

                    case "5":

                        ChangeDoctorStatus();

                        break;

                    case "6":

                        ViewPatientHealthRecord();

                        break;

                    case "7":

                        ViewUpcomingAppointments();

                        break;

                    case "8":

                        ViewPendingAppointments();

                        break;

                    case "9":

                        CancelAppointment();

                        break;

                    case "0":

                        return;

                    default:

                        Console.WriteLine("Invalid Choice.");

                        break;

                }

                Pause();

            }

        }

        private void AddDoctor()

        {

            try

            {

                Console.WriteLine("\n--- Add Doctor ---");

                Doctor doc = new();

                while (true)

                {

                    Console.Write("Name: ");

                    doc.FullName = Console.ReadLine()!;

                    if (doc.IsValidName()) break;

                    Console.WriteLine("Invalid Name");

                }

                Console.WriteLine("Select Specialisation:");

                foreach (var item in Enum.GetValues<SpecialisationType>())

                {

                    Console.WriteLine($"{(int)item}. {item}");

                }

                if (!Enum.TryParse(Console.ReadLine(), out SpecialisationType spec))

                {

                    Console.WriteLine("Invalid Specialisation");

                    return;

                }

                doc.Specialisation = spec;

                Console.Write("Experience: ");

                if (!int.TryParse(Console.ReadLine(), out int exp))

                {

                    Console.WriteLine("Invalid Experience");

                    return;

                }

                doc.YearsOfExperience = exp;

                while (true)

                {

                    Console.Write("Email: ");

                    doc.DoctorEmail = Console.ReadLine()!;

                    if (doc.IsValidEmail()) break;

                    Console.WriteLine("Invalid Email");

                }

                while (true)

                {

                    Console.Write("Phone: ");

                    doc.DoctorPhoneNo = Console.ReadLine()!;

                    if (doc.IsValidPhoneNumber()) break;

                    Console.WriteLine("Invalid Phone");

                }

                while (true)

                {

                    Console.Write("Fee: ");

                    if (decimal.TryParse(Console.ReadLine(), out decimal fee) && fee > 0)

                    {

                        doc.ConsultationFee = fee;

                        break;

                    }

                    Console.WriteLine("Invalid Fee");

                }

                _doctorService.AddDoctor(doc);

                Console.WriteLine("Doctor Added Successfully ");

            }

            catch (Exception ex)

            {

                Console.WriteLine($"Error: {ex.Message}");

            }

        }

        private void ViewAppointmentsByDoctor()

        {

            try

            {

                Console.Write("Doctor ID: ");

                if (!int.TryParse(Console.ReadLine(), out int id))

                {

                    Console.WriteLine("Invalid ID");

                    return;

                }

                var appointments = _appointmentService

                    .GetAllAppointments()

                    .Where(a => a.Doctor.DoctorId == id);

                foreach (var a in appointments)

                {

                    Console.WriteLine(a.GetDetails());

                }

            }

            catch (Exception ex)

            {

                Console.WriteLine($"Error: {ex.Message}");

            }

        }

        private void AddHealthRecord()

        {

            try

            {

                Console.Write("Appointment ID: ");

                if (!int.TryParse(Console.ReadLine(), out int id))

                {

                    Console.WriteLine("Invalid ID");

                    return;

                }

                var appointment = _appointmentService.GetAppointmentById(id);

                if (appointment == null)

                {

                    Console.WriteLine("Appointment not found");

                    return;

                }

                HealthRecord record = new()

                {

                    Patient = appointment.Patient,

                    Doctor = appointment.Doctor,

                    VisitDate = DateTime.Now

                };

                Console.Write("Diagnosis: ");

                record.Diagnosis = Console.ReadLine()!;

                Console.Write("Prescription: ");

                record.Prescription = Console.ReadLine()!;

                Console.Write("Notes: ");

                record.Notes = Console.ReadLine()!;

                _healthService.AddRecord(record);

                appointment.Complete();

                Console.WriteLine("Health Record Added ✅");

            }

            catch (Exception ex)

            {

                Console.WriteLine($"Error: {ex.Message}");

            }

        }

        private void ConfirmAppointment()

        {

            try

            {

                Console.Write("Appointment ID: ");

                if (!int.TryParse(Console.ReadLine(), out int id))

                {

                    Console.WriteLine("Invalid ID");

                    return;

                }

                _appointmentService.ConfirmAppointment(id);

                Console.WriteLine("Appointment Confirmed ");

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

            }

        }

        private void ChangeDoctorStatus()

        {

            try

            {

                Console.Write("Doctor ID: ");

                if (!int.TryParse(Console.ReadLine(), out int id))

                {

                    Console.WriteLine("Invalid ID");

                    return;

                }

                Console.Write("Active? (yes/no): ");

                string input = Console.ReadLine()!.ToLower();

                bool isActive = input == "yes";

                string result = _doctorService.ChangeDoctorStatus(id, isActive);

                Console.WriteLine(result);

            }

            catch (DoctorNotFoundException ex)

            {

                Console.WriteLine(ex.Message);

            }

        }

        private void ViewPatientHealthRecord()

        {

            try

            {

                Console.Write("Patient ID: ");

                if (!int.TryParse(Console.ReadLine(), out int id))

                {

                    Console.WriteLine("Invalid ID");

                    return;

                }

                var records = _healthService.GetPatientRecords(id);

                foreach (var r in records)

                {

                    Console.WriteLine(r.GetSummary());

                }

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

            }

        }

        private void ViewUpcomingAppointments()

        {

            try

            {

                Console.Write("Doctor ID: ");

                if (!int.TryParse(Console.ReadLine(), out int id))

                {

                    Console.WriteLine("Invalid ID");

                    return;

                }

                var list = _appointmentService

                    .GetUpcomingAppointmentsByDoctor(

                        id,

                        DateTime.Today,

                        DateTime.Today.AddDays(30));

                foreach (var a in list)

                {

                    Console.WriteLine(a.GetDetails());

                }

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

            }

        }

        private void ViewPendingAppointments()

        {

            try

            {

                Console.Write("Doctor ID: ");

                if (!int.TryParse(Console.ReadLine(), out int id))

                {

                    Console.WriteLine("Invalid ID");

                    return;

                }

                var list = _appointmentService

                    .GetPendingAppointmentsByDoctor(id);

                foreach (var a in list)

                {

                    Console.WriteLine(a.GetDetails());

                }

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

            }

        }

        private void CancelAppointment()

        {

            try

            {

                Console.Write("Appointment ID: ");

                if (!int.TryParse(Console.ReadLine(), out int id))

                {

                    Console.WriteLine("Invalid ID");

                    return;

                }

                Console.Write("Reason: ");

                string reason = Console.ReadLine()!;

                _appointmentService.CancelAppointment(id, reason);

                Console.WriteLine("Appointment Cancelled ");

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

            }

        }

        private void Pause()

        {

            Console.WriteLine("\nPress any key...");

            Console.ReadKey();

        }

    }

}


