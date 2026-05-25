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

        private const string DoctorIdPrompt = "Doctor ID: ";
        private const string InvalidIdPrompt = "Invalid ID";

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

                Console.WriteLine("2. Make Active / Inactive");

                Console.WriteLine("3. View Pending Appointments");

                Console.WriteLine("4. Confirm Appointment");

                Console.WriteLine("5. Cancel Appointment");

                Console.WriteLine("6. View Upcoming Appointments");

                Console.WriteLine("7. Add Health Record");

                Console.WriteLine("8. View Patient Health Record");

                Console.WriteLine("0. Exit to Main Menu");

                Console.Write("\nChoose: ");

                var choice = Console.ReadLine();

                switch (choice)

                {

                    case "1":

                        AddDoctor();

                        break;


                    case "2":

                        ChangeDoctorStatus();

                        break;


                    case "3":

                        ViewPendingAppointments();

                        break;

                    case "4":

                        ConfirmAppointment();

                        break;

                    case "5":

                        CancelAppointment();
                        break;


                    case "6":

                        ViewUpcomingAppointments();

                        break;
                      
                    case "7":

                        AddHealthRecord();

                        break;



                    case "8":

                        ViewPatientHealthRecord();

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

                Doctor doc = new()
                {
                    FullName = ReadValidInput(
                        "Name: ",
                        value =>
                        {
                            var temp = new Doctor { FullName = value };
                            return temp.IsValidName();
                        },
                        "Invalid Name"),

                    Specialisation = ReadSpecialisation(),

                    YearsOfExperience = ReadInt(
                        "Experience: ",
                        "Invalid Experience"),

                    DoctorEmail = ReadValidInput(
                        "Email: ",
                        value =>
                        {
                            var temp = new Doctor { DoctorEmail = value };
                            return temp.IsValidEmail();
                        },
                        "Invalid Email"),

                    DoctorPhoneNo = ReadValidInput(
                        "Phone: ",
                        value =>
                        {
                            var temp = new Doctor { DoctorPhoneNo = value };
                            return temp.IsValidPhoneNumber();
                        },
                        "Invalid Phone"),

                    ConsultationFee = ReadDecimal(
                        "Fee: ",
                        "Invalid Fee")
                };

                _doctorService.AddDoctor(doc);
                Console.WriteLine("Doctor Added Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static string ReadValidInput(
            string message,
            Func<string, bool> validator,
            string errorMessage)
        {
            while (true)
            {
                Console.Write(message);

                string input = Console.ReadLine()!;

                if (validator(input))
                    return input;

                Console.WriteLine(errorMessage);
            }
        }

        private static int ReadInt(string message, string errorMessage)
        {
            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out int value))
                    return value;

                Console.WriteLine(errorMessage);
            }
        }

        private static decimal ReadDecimal(string message, string errorMessage)
        {
            while (true)
            {
                Console.Write(message);

                if (decimal.TryParse(Console.ReadLine(), out decimal value) && value > 0)
                    return value;

                Console.WriteLine(errorMessage);
            }
        }

        private static SpecialisationType ReadSpecialisation()
        {
            while (true)
            {
                Console.WriteLine("Select Specialisation:");

                foreach (var item in Enum.GetValues<SpecialisationType>())
                {
                    Console.WriteLine($"{(int)item}. {item}");
                }

                Console.Write("Choose: ");
                string input = Console.ReadLine()!;

                if (int.TryParse(input, out int value)
                    && Enum.IsDefined(typeof(SpecialisationType), value))
                {
                    return (SpecialisationType)value;
                }

                Console.WriteLine("Invalid Specialisation. Please try again.");
            }
        }

       
        private void AddHealthRecord()

        {

            try

            {

                Console.Write("Appointment ID: ");

                if (!int.TryParse(Console.ReadLine(), out int id))

                {

                    Console.WriteLine(InvalidIdPrompt);

                    return;

                }

                var appointment = _appointmentService.GetAppointmentById(id);

                if (appointment == null)

                {

                    Console.WriteLine("Appointment not found");

                    return;

                }
                if (appointment.Status == AppointmentStatus.Cancelled)
                {
                    Console.WriteLine(
                        "Cannot add health record for a cancelled appointment.");
                    return;
                }

                if (appointment.Status == AppointmentStatus.Pending)
                {
                    Console.WriteLine(
                        "Appointment must be confirmed before adding health record.");
                    return;
                }

                if (appointment.Status == AppointmentStatus.Completed)
                {
                    Console.WriteLine(
                        "Health record already added for this appointment.");
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

                Console.WriteLine("Health Record Added");

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

                    Console.WriteLine(InvalidIdPrompt);

                    return;

                }

                _appointmentService.ConfirmAppointment(id);

                Console.WriteLine("Appointment Confirmed ");

            }

            catch(AppointmentNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
            catch (AppointmentAlreadyConfirmedException ex)

            {

                Console.WriteLine(ex.Message);

            }
            catch (AppointmentAlreadyCancelledException ex)

            {

                Console.WriteLine(ex.Message);

            }
            catch (AppointmentAlreadyCompletedException ex)

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

                    Console.WriteLine(InvalidIdPrompt);

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

                    Console.WriteLine(InvalidIdPrompt);

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

                    Console.WriteLine(InvalidIdPrompt);

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

                    Console.WriteLine(InvalidIdPrompt);

                    return;

                }

                var list = _appointmentService

                    .GetPendingAppointmentsByDoctor(id);

                foreach (var a in list)

                {

                    Console.WriteLine(a.GetDetails());

                }

            }

            catch (AppointmentNotFoundException ex)

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

                    Console.WriteLine(InvalidIdPrompt);

                    return;

                }

                Console.Write("Reason: ");

                string reason = Console.ReadLine()!;

                _appointmentService.CancelAppointment(id, reason);

                Console.WriteLine("Appointment Cancelled ");

            }

            catch (AppointmentAlreadyCancelledException ex)

            {

                Console.WriteLine(ex.Message);

            }
            catch (AppointmentAlreadyCompletedException ex)

            {

                Console.WriteLine(ex.Message);

            }
            catch (AppointmentNotFoundException ex)

            {

                Console.WriteLine(ex.Message);

            }

        }

        private static void Pause()

        {

            Console.WriteLine("\nPress any key...");

            Console.ReadKey();

        }

    }

}