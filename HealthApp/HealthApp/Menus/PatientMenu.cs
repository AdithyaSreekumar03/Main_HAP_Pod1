using HealthApp.Constant;
using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace HealthApp.Menus
{
    public class PatientMenu
    {
        private readonly IPatientService _patientService;
        private readonly IDoctorService _doctorService;
        private readonly IAppointmentService _appointmentService;
        private readonly IHealthRecordService _healthService;

        public PatientMenu(
            IPatientService patientService,
            IDoctorService doctorService,
            IAppointmentService appointmentService,
            IHealthRecordService healthService)
        {
            _patientService = patientService;
            _doctorService = doctorService;
            _appointmentService = appointmentService;
            _healthService = healthService;
        }

        public void Show()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== PATIENT MENU =====");

                Console.WriteLine("1. Register Patient");
                Console.WriteLine("2. Update Profile");
                Console.WriteLine("3. Search Doctors by Specialization");
                Console.WriteLine("4. Book Appointment");
                Console.WriteLine("5. Cancel Appointment");
                Console.WriteLine("6. View Upcoming Appointments");
                Console.WriteLine("7. View Health History");
                Console.WriteLine("0. Exit to Main Menu");

                Console.Write("\nChoose: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RegisterPatient();
                        break;

                    case "2":
                        UpdatePatient();
                        break;

                    case "3":
                        SearchDoctors();
                        break;

                    case "4":
                        BookAppointment();
                        break;

                    case "5":
                        CancelAppointment();
                        break;

                    case "6":
                        ViewAppointments();
                        break;

                    case "7":
                        ViewHealthHistory();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid Choice. Please try again.");
                        break;
                }
                Pause();
            }
        }

        private void RegisterPatient()
        {
            try
            {
                Console.WriteLine("\n--- Register Patient ---");

                Patient patient = CollectPatientDetails();

                _patientService.RegisterPatient(patient);

                Console.WriteLine("\nPatient Registered Successfully");
                Console.WriteLine(patient.GetProfileSummary());
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Pause()
        {
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();

        }

        private void ViewHealthHistory()
        {
            try
            {
                int pId = ReadInt("Patient ID: ");

                var records = _healthService.GetPatientRecords(pId);

                if (records.Count == 0)
                {
                    Console.WriteLine("No health records found.");
                    return;
                }

                foreach (var r in records)
                {
                    Console.WriteLine(r.GetSummary());
                }
            }
            catch(NoHealthRecordAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
           
        }

        private void ViewAppointments()
        {
            try
            {

                int pid = ReadInt("Patient ID: ");


                var appointments =
                    _appointmentService
                    .GetAppointmentsByPatient(pid);

                if (appointments.Count == 0)
                {
                    Console.WriteLine(
                        "No upcoming appointments found.");
                }
                else
                {
                    foreach (var a in appointments)
                    {
                        Console.WriteLine(a.GetDetails());

                        Console.WriteLine(
                            "---------------");
                    }
                }
            }
            catch(AppointmentNotFoundException ex)
            {
                Console.WriteLine (ex.Message);
            }
            }
           
        

        private void CancelAppointment()
        {
            try
            {

                int appointmentId = ReadInt("Appointment ID: ");


                Console.Write("Reason: ");

                string reason =
                    Console.ReadLine()!;

                _appointmentService
                    .CancelAppointment(
                        appointmentId,
                        reason);

                Console.WriteLine(
                    "Appointment Cancelled.");

            }
            catch(AppointmentNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(AppointmentAlreadyCancelledException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(AppointmentAlreadyCompletedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }
        private void BookAppointment()
        {
            DateTime date;

            try
            {
              

                int patientId = ReadInt("Patient ID: ");
                    

                var selectedPatient =
                    _patientService
                    .GetPatientById(patientId);


                Console.WriteLine("\nSearch Doctors by Specialization: \n");
                SearchDoctors();


                int doctorId = ReadInt("Doctor ID: ");
                    
                var selectedDoctor =
                    _doctorService
                    .GetDoctorById(doctorId);

                while (true)
                {
                    Console.Write("Appointment Date (dd-MM-yyyy): ");

                    string input = Console.ReadLine()!;

                    if (!DateTime.TryParseExact(
                            input,
                            "dd-MM-yyyy",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None,
                            out date))
                    {
                        Console.WriteLine("Invalid date format. Use dd-MM-yyyy");
                        continue;
                    }


                    if (date.Date < DateTime.Today)
                    {
                        Console.WriteLine(
                            "Appointment date cannot be in the past.");
                        continue;
                    }

                    break;
                }



                string slot = ReadSlot();

                var appointment =
                    _appointmentService
                    .BookAppointment(
                        selectedPatient!,
                        selectedDoctor!,
                        date,
                        slot);

                Console.WriteLine(
                    "\nAppointment Booked Successfully\n");

                Console.WriteLine(
                    appointment.GetDetails());
            }
            catch (PastDateException ex)
            {
                Console.WriteLine(
                    $"Error: {ex.Message}");
            }
            catch (DoctorUnavailableException ex)
            {
                Console.WriteLine(
                    $"Error: {ex.Message}");
            }
            catch (SlotAlreadyOverException ex)
            {
                Console.WriteLine(
                    $"Error: {ex.Message}");
            }
            catch (AppointmentConflictException ex)
            {
                Console.WriteLine(
                    $"Error: {ex.Message}");
            }
            catch (PatientNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (DoctorNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (InvalidDateRangeException ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }
            
        }

        private static string ReadSlot()
        {
            Console.WriteLine("\nAvailable Slots:");

            for (int i = 0; i < TimeSlots.Slots.Count; i++)
            {
                Console.WriteLine(
                    $"{i + 1}. {TimeSlots.Slots[i]}");
            }

            while (true)
            {
                Console.Write("Choose Slot: ");

                if (int.TryParse(Console.ReadLine(), out int choice)
                    && choice >= 1
                    && choice <= TimeSlots.Slots.Count)
                {
                    return TimeSlots.Slots[choice - 1];
                }

                Console.WriteLine("Invalid Slot Selection");
            }
        }
        private void SearchDoctors()
        {
            try
            {
                SpecialisationType specialisation;

                // Keep asking until valid specialisation is entered
                while (true)
                {
                    Console.WriteLine("Select Specialisation:");

                    foreach (var item in Enum.GetValues<SpecialisationType>())
                    {
                        Console.WriteLine($"{(int)item}. {item}");
                    }

                    Console.Write("Choose: ");

                    string specInput = Console.ReadLine()!;

                    // Accept numeric input
                    if (int.TryParse(specInput, out int value)
                        && Enum.IsDefined(typeof(SpecialisationType), value))
                    {
                        specialisation = (SpecialisationType)value;
                        break;
                    }

                    // Accept enum name input
                    if (Enum.TryParse(
                        specInput,
                        true,
                        out specialisation)
                        && Enum.IsDefined(specialisation))
                    {
                        break;
                    }

                    Console.WriteLine("Invalid Specialisation");
                }

                var doctors =
                    _doctorService
                    .SearchBySpecialisation(specialisation);

                foreach (var d in doctors)
                {
                    Console.WriteLine(
                        $"ID:{d.DoctorId} " +
                        $"{d.FullName}");
                }
            }
            catch (DoctorNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void UpdatePatient()
        {
            try
            {
               
                int updateId = ReadInt("Enter Patient ID to Update: ");

                Patient updatedPatient = CollectPatientDetails();

                string result = _patientService.UpdatePatientById(updateId, updatedPatient);

                Console.WriteLine(result);
            }
            catch (PatientNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static Patient CollectPatientDetails()
        {
            Patient patient = new();

            patient.FullName = ReadValidInput(
                "Name: ",
                value => new Patient { FullName = value }.IsValidName(),
                "Invalid Name");

            patient.DateOfBirth = ReadDOB(); // ✅ separated

            patient.Gender = ReadGender();

            patient.PhoneNumber = ReadValidInput(
                "Phone: ",
                value => new Patient { PhoneNumber = value }.IsValidPhoneNumber(),
                "Invalid Phone Number.");

            patient.Email = ReadValidInput(
                "Email: ",
                value => new Patient { Email = value }.IsValidEmail(),
                "Invalid Email.");

            Console.Write("Insurance ID: ");
            patient.InsuranceId = Console.ReadLine() ?? string.Empty;

            return patient;
        }
        private static DateOnly ReadDOB()
        {
            while (true)
            {
                Console.Write("DOB (dd-MM-yyyy): ");

                string? input = Console.ReadLine();

                if (!DateOnly.TryParseExact(
                        input,
                        "dd-MM-yyyy",
                        System.Globalization.CultureInfo.InvariantCulture,
                        System.Globalization.DateTimeStyles.None,
                        out DateOnly dob))
                {
                    Console.WriteLine("Invalid Date Format.");
                    continue;
                }

                if (dob > DateOnly.FromDateTime(DateTime.Today))
                {
                    Console.WriteLine("DOB cannot be future.");
                    continue;
                }

                return dob;
            }
        }

        private static GenderType ReadGender()
        {
            while (true)
            {
                Console.Write("Gender (Male/Female/Other): ");

                string? input = Console.ReadLine();

                if (Enum.TryParse(input, true, out GenderType gender) &&
                    Enum.IsDefined(gender))
                {
                    return gender;
                }

                Console.WriteLine("Invalid Gender.");
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

                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty.");
                    continue;
                }

                if (validator(input))
                    return input;

                Console.WriteLine(errorMessage);
            }
        }
        private static int ReadInt(string message) {
            while (true) {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out int value))
                    return value;

                Console.WriteLine("Invalid Id. Try again.");

            }
        }

    }
}