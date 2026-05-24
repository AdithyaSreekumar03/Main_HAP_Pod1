using HealthApp.Constants;
using HealthApp.Exceptions;
using HealthApp.Models;
using HealthApp.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        private void Pause()
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

                if (!records.Any())
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

                if (!appointments.Any())
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
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
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
                            null,
                            System.Globalization.DateTimeStyles.None,
                            out date))
                    {
                        Console.WriteLine(
                            "Invalid date format. Use dd-MM-yyyy");
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

                Console.WriteLine(
                    "\nAvailable Slots:");

                for (int i = 0;
                    i < TimeSlots.Slots.Count;
                    i++)
                {
                    Console.WriteLine(
                        $"{i + 1}. " +
                        $"{TimeSlots.Slots[i]}");
                }

                int slotChoice =
                    int.Parse(
                        Console.ReadLine()!);

                string slot =
                    TimeSlots.Slots[
                        slotChoice - 1];

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
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Unexpected Error: {ex.Message}");
            }
        }
        private void SearchDoctors()
        {
            Console.WriteLine("Select Specialisation:");

            foreach (var item in Enum.GetValues<SpecialisationType>())
            {
                Console.WriteLine($"{(int)item}. {item}");
            }

            string specInput = Console.ReadLine()!;

            if (!Enum.TryParse<SpecialisationType>(
                    specInput,
                    true,
                    out SpecialisationType specialisation))
            {
                Console.WriteLine("Invalid Specialisation");
                return;
            }

            var doctors =
                _doctorService
                .SearchBySpecialisation(specialisation);

            foreach (var d in doctors)
            {
                Console.WriteLine(
                    $"ID:{d.DoctorId} " +
                    $"Dr.{d.FullName}");
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

        private Patient CollectPatientDetails()
        {
            Patient patient = new();

            while (true)
            {
                Console.Write("Name: ");
                patient.FullName = Console.ReadLine()!;

                if (patient.IsValidName()) break;

                Console.WriteLine("Invalid Name.");
            }

            while (true)
            {
                Console.Write("DOB (dd-MM-yyyy): ");
                string dobInput = Console.ReadLine()!;

                if (!DateOnly.TryParseExact(
                        dobInput,
                        "dd-MM-yyyy",
                        null,
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
                patient.DateOfBirth = dob;
                break;
            }

            Console.Write("Gender (Male/Female/Other): ");
            string genderInput = Console.ReadLine()!;

            if (!Enum.TryParse(genderInput, true, out GenderType gender))
            {
                Console.WriteLine("Invalid Gender. Defaulting to 'Other'");
                gender = GenderType.Other;
            }

            patient.Gender = gender;

            while (true)
            {
                Console.Write("Phone: ");
                patient.PhoneNumber = Console.ReadLine()!;

                if (patient.IsValidPhoneNumber()) break;

                Console.WriteLine("Invalid Phone Number.");
            }

            while (true)
            {
                Console.Write("Email: ");
                patient.Email = Console.ReadLine()!;

                if (patient.IsValidEmail()) break;

                Console.WriteLine("Invalid Email.");
            }

            Console.Write("Insurance ID: ");
            patient.InsuranceId = Console.ReadLine()!;

            return patient;
        }
    }
}