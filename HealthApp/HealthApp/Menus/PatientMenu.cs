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
                Console.WriteLine(" ================ PATIENT MENU =================");
                Console.WriteLine("| Option | Description                          |");
                Console.WriteLine("|--------|--------------------------------------|");
                Console.WriteLine("| 1      | Register Patient                     |");
                Console.WriteLine("| 2      | Update Profile                       |");
                Console.WriteLine("| 3      | Search Doctors by Specialization     |");
                Console.WriteLine("| 4      | Book Appointment                     |");
                Console.WriteLine("| 5      | Cancel Appointment                   |");
                Console.WriteLine("| 6      | View Upcoming Appointments           |");
                Console.WriteLine("| 7      | View Health History                  |");
                Console.WriteLine("| 0      | Exit to Main Menu                    |");
                Console.WriteLine(" ===============================================");
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
                        Console.WriteLine("Invalid Choice Please try again.");
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
                Console.Write("Patient ID: ");

                int pId = int.Parse(Console.ReadLine()!);

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
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void ViewAppointments()
        {
            try
            {
                Console.Write("Patient ID: ");

                int pid =
                    int.Parse(Console.ReadLine()!);

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
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void CancelAppointment()
        {
            try
            {
                Console.Write("Appointment ID: ");

                int appointmentId =
                    int.Parse(Console.ReadLine()!);

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
            catch (AppointmentNotFoundException ex)
            {
                Console.WriteLine(ex.Message);

            }


        } 
        private void BookAppointment()
        {
            DateTime date;

            try
            {
                Console.Write("Patient ID: ");

                int patientId =
                    int.Parse(Console.ReadLine()!);

                var selectedPatient =
                    _patientService
                    .GetPatientById(patientId);

                Console.WriteLine("\nSearch Doctors by Specialization: \n");
                SearchDoctors();

                Console.Write("Doctor ID: ");

                int doctorId =
                    int.Parse(Console.ReadLine()!);

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
<<<<<<< HEAD
                        continue;
=======
>>>>>>> dac60939d2c38f01977edc5d4e79df730b30c9d5
                    }


                    if (date.Date < DateTime.Today)
                    {
                        Console.WriteLine(
                            "Appointment date cannot be in the past.");
                        continue;
                    }

                    if (date.Date > DateTime.Today.AddDays(90))
                    {
                        Console.WriteLine("Appointments can only be booked within next 90 days.");
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
<<<<<<< HEAD
  
        }

        private static string ReadSlot()
        {
            Console.WriteLine("\nAvailable Slots:");

            for (int i = 0; i < TimeSlots.Slots.Count; i++)
=======
            catch (Exception ex)
>>>>>>> dac60939d2c38f01977edc5d4e79df730b30c9d5
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

                while (true)
                {
                    Console.WriteLine("Select Specialisation:");

                    foreach (var item in Enum.GetValues<SpecialisationType>())
                    {
                        Console.WriteLine($"{(int)item}. {item}");
                    }

                    Console.Write("Choose: ");

                    string specInput = Console.ReadLine()!;

                    if (int.TryParse(specInput, out int value)
                        && Enum.IsDefined(typeof(SpecialisationType), value))
                    {
                        specialisation = (SpecialisationType)value;
                        break;
                    }

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
                    Console.WriteLine($"\nID : {d.DoctorId}");
                    Console.WriteLine($"Name : {d.FullName}");
                    Console.WriteLine($"Specialisation: {d.Specialisation}");
                    Console.WriteLine($"Experience : {d.YearsOfExperience}");
                    Console.WriteLine($"Consultation Fees: {d.ConsultationFee}\n");
                }
            }
<<<<<<< HEAD
            catch (DoctorNotFoundException ex)
=======

            string specInput = Console.ReadLine()!;

            if (!Enum.TryParse(
            specInput,
            true,
            out SpecialisationType specialisation) || !Enum.IsDefined(specialisation))
>>>>>>> dac60939d2c38f01977edc5d4e79df730b30c9d5
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void UpdatePatient()
        {
            try
            {
                Console.Write("Enter Patient ID to Update: ");
                int updateId = int.Parse(Console.ReadLine()!);

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

<<<<<<< HEAD
            patient.DateOfBirth = ReadDOB(); 
=======
            patient.DateOfBirth = ReadDOB(); // ✅ separated
>>>>>>> dac60939d2c38f01977edc5d4e79df730b30c9d5

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
<<<<<<< HEAD
=======
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
>>>>>>> dac60939d2c38f01977edc5d4e79df730b30c9d5
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
        

    }
}