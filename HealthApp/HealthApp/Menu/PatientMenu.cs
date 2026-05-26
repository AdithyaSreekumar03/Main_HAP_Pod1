using HealthApp.Constant;
using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Globalization; // ✅ ADDED

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
                Console.WriteLine("3. Search Doctors");
                Console.WriteLine("4. Book Appointment");
                Console.WriteLine("5. Cancel Appointment");
                Console.WriteLine("6. View Appointments");
                Console.WriteLine("7. View Health History");
                Console.WriteLine("0. Exit");

                Console.Write("Choose: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": RegisterPatient(); break;
                    case "2": UpdatePatient(); break;
                    case "3": SearchDoctors(); break;
                    case "4": BookAppointment(); break;
                    case "5": CancelAppointment(); break;
                    case "6": ViewAppointments(); break;
                    case "7": ViewHealthHistory(); break;
                    case "0": return;
                    default: Console.WriteLine("Invalid Choice"); break;
                }

                Pause();
            }
        }

        private void RegisterPatient()
        {
            try
            {
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

        private void UpdatePatient()
        {
            try
            {
                Console.Write("Enter Patient ID: ");
                int id = int.Parse(Console.ReadLine()!);

                Patient updated = CollectPatientDetails();
                Console.WriteLine(_patientService.UpdatePatientById(id, updated));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void SearchDoctors()
        {
            Console.WriteLine("Select Specialisation:");

            foreach (var item in Enum.GetValues<SpecialisationType>())
            {
                Console.WriteLine($"{(int)item}. {item}");
            }

            if (!Enum.TryParse(Console.ReadLine(), true, out SpecialisationType spec))
            {
                Console.WriteLine("Invalid Specialisation");
                return;
            }

            foreach (var d in _doctorService.SearchBySpecialisation(spec))
            {
                Console.WriteLine($"ID: {d.DoctorId} {d.FullName}");
            }
        }

        private void BookAppointment()
        {
            try
            {
                Console.Write("Patient ID: ");
                int patientId = int.Parse(Console.ReadLine()!);

                Console.Write("Doctor ID: ");
                int doctorId = int.Parse(Console.ReadLine()!);

                DateTime date = ReadAppointmentDate();
                string slot = ReadSlot();

                var appointment = _appointmentService.BookAppointment(
                    _patientService.GetPatientById(patientId)!,
                    _doctorService.GetDoctorById(doctorId)!,
                    date,
                    slot);

                Console.WriteLine("\nAppointment Booked Successfully");
                Console.WriteLine(appointment.GetDetails());
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
                int id = int.Parse(Console.ReadLine()!);

                Console.Write("Reason: ");
                string reason = Console.ReadLine()!;

                _appointmentService.CancelAppointment(id, reason);
                Console.WriteLine("Appointment Cancelled");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ViewAppointments()
        {
            try
            {
                Console.Write("Patient ID: ");
                int id = int.Parse(Console.ReadLine()!);

                var list = _appointmentService.GetAppointmentsByPatient(id);

                if (!list.Any())
                {
                    Console.WriteLine("No appointments found");
                    return;
                }

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

        private void ViewHealthHistory()
        {
            try
            {
                Console.Write("Patient ID: ");
                int id = int.Parse(Console.ReadLine()!);

                foreach (var r in _healthService.GetPatientRecords(id))
                {
                    Console.WriteLine(r.GetSummary());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static DateTime ReadAppointmentDate()
        {
            while (true)
            {
                Console.Write("Date (dd-MM-yyyy): ");
                string input = Console.ReadLine()!;

                if (!DateTime.TryParseExact(
                        input,
                        "dd-MM-yyyy",
                        CultureInfo.InvariantCulture, // ✅ FIX
                        DateTimeStyles.None,
                        out DateTime date))
                {
                    Console.WriteLine("Invalid format");
                    continue;
                }

                if (date < DateTime.Today)
                {
                    Console.WriteLine("Cannot be past date");
                    continue;
                }

                return date;
            }
        }

        private static DateOnly ReadDOB()
        {
            while (true)
            {
                Console.Write("DOB (dd-MM-yyyy): ");
                string input = Console.ReadLine()!;

                if (!DateOnly.TryParseExact(
                        input,
                        "dd-MM-yyyy",
                        CultureInfo.InvariantCulture, // ✅ FIX
                        DateTimeStyles.None,
                        out DateOnly dob))
                {
                    Console.WriteLine("Invalid Format");
                    continue;
                }

                if (dob > DateOnly.FromDateTime(DateTime.Today))
                {
                    Console.WriteLine("Future date not allowed");
                    continue;
                }

                return dob;
            }
        }

        // ✅ Rest unchanged (clean & valid)
        private static Patient CollectPatientDetails() => new()
        {
            FullName = ReadName(),
            DateOfBirth = ReadDOB(),
            Gender = ReadGender(),
            PhoneNumber = ReadPhone(),
            Email = ReadEmail(),
            InsuranceId = ReadInsuranceId()
        };

        private static string ReadName()
        {
            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine()!;
                if (new Patient { FullName = name }.IsValidName()) return name;
                Console.WriteLine("Invalid Name");
            }
        }

        private static GenderType ReadGender()
        {
            while (true)
            {
                Console.Write("Gender: ");
                if (Enum.TryParse(Console.ReadLine(), true, out GenderType g))
                    return g;
                Console.WriteLine("Invalid");
            }
        }

        private static string ReadPhone()
        {
            while (true)
            {
                Console.Write("Phone: ");
                string phone = Console.ReadLine()!;
                if (new Patient { PhoneNumber = phone }.IsValidPhoneNumber()) return phone;
                Console.WriteLine("Invalid Phone");
            }
        }

        private static string ReadEmail()
        {
            while (true)
            {
                Console.Write("Email: ");
                string email = Console.ReadLine()!;
                if (new Patient { Email = email }.IsValidEmail()) return email;
                Console.WriteLine("Invalid Email");
            }
        }

        private static string ReadInsuranceId()
        {
            Console.Write("Insurance ID: ");
            return Console.ReadLine()!;
        }

        private static string ReadSlot()
        {
            Console.WriteLine("\nAvailable Slots:");
            for (int i = 0; i < TimeSlots.Slots.Count; i++)
                Console.WriteLine($"{i + 1}. {TimeSlots.Slots[i]}");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int choice)
                    && choice >= 1
                    && choice <= TimeSlots.Slots.Count)
                    return TimeSlots.Slots[choice - 1];

                Console.WriteLine("Invalid Slot");
            }
        }

        private static void Pause()
        {
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}
