using HealthApp.Constants;
using HealthApp.Databases;
using HealthApp.Exceptions;
using HealthApp.Models;
using HealthApp.Repository.Impl;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using HealthApp.Service.Interface;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;

var services = new ServiceCollection();

services.AddSingleton<PatientDb>();
services.AddSingleton<DoctorDb>();
services.AddSingleton<AppointmentDb>();
services.AddSingleton<HealthRecordDb>();

services.AddScoped<IPatientRepository, PatientRepository>();
services.AddScoped<IDoctorRepository, DoctorRepository>();
services.AddScoped<IAppointmentRepository, AppointmentRepository>();
services.AddScoped<IHealthRecordRepository, HealthRecordRepository>();

services.AddScoped<IPatientService, PatientService>();
services.AddScoped<IDoctorService, DoctorService>();
services.AddScoped<IAppointmentService, AppointmentService>();
services.AddScoped<IHealthRecordService, HealthRecordService>();

var provider = services.BuildServiceProvider();

var patientService = provider.GetRequiredService<IPatientService>();
var doctorService = provider.GetRequiredService<IDoctorService>();
var appointmentService = provider.GetRequiredService<IAppointmentService>();
var healthRecordService = provider.GetRequiredService<IHealthRecordService>();

Console.Clear();
while (true)
{
    Console.Clear();

    Console.WriteLine(
        "===== HEALTHCARE MANAGEMENT =====");

    Console.WriteLine("1. Register Patient");
    Console.WriteLine("2. Get All Patients");
    Console.WriteLine("3. Update Patient");
    Console.WriteLine("4. Delete Patient");
    Console.WriteLine("5. Add Doctor");
    Console.WriteLine("6. Get All Doctors");
    Console.WriteLine("7. Delete Doctor");
    Console.WriteLine("8. Update Doctor");
    Console.WriteLine("9. Search Doctors");
    Console.WriteLine("10. Book Appointment");
    Console.WriteLine("11. Cancel Appointment");
    Console.WriteLine("12. Add Health Record");
    Console.WriteLine("13. View Patient Upcoming Appointments");
    Console.WriteLine("14. View Health History");
    Console.WriteLine("15. Check Doctor Availability");
    Console.WriteLine("16. View Doctor Upcoming Appointment");
    Console.WriteLine("17. View Health Records By Doctor");
    Console.WriteLine("18. Make Doctor Active/Inactive");
    Console.WriteLine("19. View Pending Appointments");
    Console.WriteLine("20. Confirm Appointment");
    Console.WriteLine("21. Cancel Appointment By Doctor");
    Console.WriteLine("22. Exit");


    Console.Write("\nChoose: ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            try
            {
                Patient patient = new Patient();
                while (true)
                {
                    Console.Write("Name: ");
                    patient.FullName =
                        Console.ReadLine()!;
                    if (patient.IsValidName())
                    {
                        break;
                    }
                    Console.WriteLine("The Name is Invalid.");
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
                        Console.WriteLine("Invalid Date Format. Use dd-MM-yyyy");
                        continue;
                    }

                    if (dob > DateOnly.FromDateTime(DateTime.Today))
                    {
                        Console.WriteLine("DOB cannot be a future date.");
                        continue;
                    }

                    patient.DateOfBirth = dob;
                    break;
                }
                Console.Write("Gender (Male/Female/Other): ");

                string genderInput = Console.ReadLine()!;

                if (Enum.TryParse(genderInput, true, out GenderType gender))
                {
                    patient.Gender = gender;
                }
                else
                {
                    Console.WriteLine("Invalid Gender");
                    break;
                }
                while (true)
                {
                    Console.Write("Phone: ");
                    patient.PhoneNumber =
                        Console.ReadLine()!;

                    if (patient.IsValidPhoneNumber())
                    {
                        break;
                    }
                    Console.WriteLine("Inavlid Phone number.");
                }

                while (true)
                {
                    Console.Write("Email: ");
                    patient.Email =
                        Console.ReadLine()!;

                    if (patient.IsValidEmail())
                    {
                        break;
                    }
                    Console.WriteLine("Invalid Email Format.");
                }


                Console.Write("Insurance ID: ");
                patient.InsuranceId =
                    Console.ReadLine()!;

                patientService
                    .RegisterPatient(patient);


                Console.WriteLine(patient.GetProfileSummary());
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case "2":

            var patients = patientService.GetAllPatients();

            if (!patients.Any())
            {
                Console.WriteLine("No Patients Found");
            }
            else
            {
                foreach (var p in patients)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine($"ID: {p.PatientId}");
                    Console.WriteLine($"Name: {p.FullName}");
                    Console.WriteLine($"DOB: {p.DateOfBirth.ToShortDateString()}");
                    Console.WriteLine($"Gender: {p.Gender}");
                    Console.WriteLine($"Age: {p.GetAge()}");
                    Console.WriteLine($"Phone: {p.PhoneNumber}");
                    Console.WriteLine($"Email: {p.Email}");
                    Console.WriteLine($"Insurance ID: {p.InsuranceId}");
                }
            }

            break;
        case "3":

            try
            {
                Console.Write("Enter Patient ID to Update: ");

                int updateId = int.Parse(Console.ReadLine()!);

                Patient updatedPatient = new Patient();

                while (true)
                {
                    Console.Write("Name: ");
                    updatedPatient.FullName =
                        Console.ReadLine()!;
                    if (updatedPatient.IsValidName())
                    {
                        break;
                    }
                    Console.WriteLine("The Name is Invalid.");
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
                        Console.WriteLine("Invalid Date Format. Use dd-MM-yyyy");
                        continue;
                    }

                    if (dob > DateOnly.FromDateTime(DateTime.Today))
                    {
                        Console.WriteLine("DOB cannot be a future date.");
                        continue;
                    }

                    updatedPatient.DateOfBirth = dob;
                    break;
                }

                Console.Write("Gender (Male/Female/Other): ");

                string genderInput = Console.ReadLine()!;

                if (Enum.TryParse(genderInput, true,
                    out GenderType gender))
                {
                    updatedPatient.Gender = gender;
                }
                else
                {
                    Console.WriteLine("Invalid Gender");
                    break;
                }

                while (true)
                {
                    Console.Write("Phone: ");
                    updatedPatient.PhoneNumber =
                        Console.ReadLine()!;

                    if (updatedPatient.IsValidPhoneNumber())
                    {
                        break;
                    }
                    Console.WriteLine("Inavlid Phone number.");
                }

                while (true)
                {
                    Console.Write("Email: ");
                    updatedPatient.Email =
                        Console.ReadLine()!;

                    if (updatedPatient.IsValidEmail())
                    {
                        break;
                    }
                    Console.WriteLine("Invalid Email Format.");
                }

                Console.Write("Insurance ID: ");
                updatedPatient.InsuranceId =
                    Console.ReadLine()!;

                string result =
                    patientService.UpdatePatientById(
                        updateId,
                        updatedPatient);

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

            break;

        case "4":

            try
            {
                Console.Write("Enter Patient ID to Delete: ");

                int deleteId =
                    int.Parse(Console.ReadLine()!);

                string result =
                    patientService.DeletePatientById(deleteId);

                Console.WriteLine(result);
            }
            catch (PatientNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            break;

        case "5":

            Doctor doctor = new();

            while (true)
            {
                Console.Write("Name: ");

                doctor.FullName = Console.ReadLine()!;

                if (doctor.IsValidName())
                    break;

                Console.WriteLine("Invalid Name.");
            }


            Console.WriteLine("Select Specialisation:");

            foreach (var item in Enum.GetValues<SpecialisationType>())
            {
                Console.WriteLine($"{(int)item}. {item}");
            }

            string specialInput = Console.ReadLine()!;

            if (Enum.TryParse(specialInput, out SpecialisationType special))
            {
                doctor.Specialisation = special;
            }
            else
            {
                Console.WriteLine("Invalid Specialisation");
                break;
            }

            Console.Write("Experience: ");
            doctor.YearsOfExperience =
                int.Parse(
                    Console.ReadLine()!);


            while (true)
            {
                Console.Write("Email: ");
                doctor.DoctorEmail = Console.ReadLine()!;

                if (doctor.IsValidEmail())
                {
                    break;
                }
                Console.WriteLine("Invalid Email Format");

            }



            while (true)
            {
                Console.Write("Phone Number: ");
                doctor.DoctorPhoneNo = Console.ReadLine()!;
                if (doctor.IsValidPhoneNumber())
                {
                    break;
                }
                Console.WriteLine("Invalid Phone Number");
            }

            while (true)
            {
                Console.Write("Fee: ");

                string feeInput = Console.ReadLine()!;

                if (decimal.TryParse(feeInput, out decimal fee))
                {
                    if (fee <= 0)
                    {
                        Console.WriteLine(
                            "Fee must be greater than zero.");
                        continue;
                    }

                    doctor.ConsultationFee = fee;
                    break;
                }

                Console.WriteLine(
                    "Invalid Fee. Enter numbers only.");
            }

            doctorService.AddDoctor(doctor);

            doctor.GetDoctorDetailsSummary();

            break;

        case "6":
            try
            {
                var doct = doctorService.GetAllDoctors();
                foreach (var doc in doct)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine($"ID: {doc.DoctorId}");
                    Console.WriteLine($"Name: {doc.FullName}");
                    Console.WriteLine($"Specialisation: {doc.Specialisation}");
                    Console.WriteLine($"Email: {doc.DoctorEmail}");
                    Console.WriteLine($"Phone: {doc.DoctorPhoneNo}");
                    Console.WriteLine($"Years of Experience: {doc.YearsOfExperience}");
                    Console.WriteLine($"Consulattion Fee: {doc.ConsultationFee}");
                    Console.WriteLine($"IsActive: {doc.IsActive}");
                }
            }
            catch (NoPatientsRegisteredException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case "7":
            try
            {
                Console.Write("Enter Doctor ID to Delete: ");

                int delId =
                    int.Parse(Console.ReadLine()!);

                string result =
                    doctorService.DeleteDoctorById(delId);

                Console.WriteLine(result);
            }
            catch (DoctorNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case "8":
            try
            {
                Console.Write("Enter Doctor ID to Update: ");

                int updateId = int.Parse(Console.ReadLine()!);

                Doctor updatedDoctor = new Doctor();
                while (true)
                {
                    Console.Write("Name: ");
                    updatedDoctor.FullName = Console.ReadLine()!;

                    if (updatedDoctor.IsValidName())
                    {
                        break;
                    }
                    Console.WriteLine("The Name is Invalid.");
                }

                Console.WriteLine("Select Specialisation:");

                foreach (var item in Enum.GetValues<SpecialisationType>())
                {
                    Console.WriteLine($"{(int)item}. {item}");
                }

                string speciInput = Console.ReadLine()!;

                if (Enum.TryParse(speciInput, out SpecialisationType spec))
                {
                    updatedDoctor.Specialisation = spec;
                }
                else
                {
                    Console.WriteLine("Invalid Specialisation");
                    break;
                }

                while (true)
                {
                    Console.Write("Phone: ");
                    updatedDoctor.DoctorPhoneNo =
                        Console.ReadLine()!;

                    if (updatedDoctor.IsValidPhoneNumber())
                    {
                        break;
                    }
                    Console.WriteLine("Invalid Phone Number");
                }

                while (true)
                {
                    Console.Write("Email: ");
                    updatedDoctor.DoctorEmail =
                        Console.ReadLine()!;
                    if (updatedDoctor.IsValidEmail())
                    {
                        break;
                    }
                    Console.WriteLine("Invalid Email Format");

                }


                Console.Write("Years of Experience: ");
                updatedDoctor.YearsOfExperience =
                    int.Parse(
                        Console.ReadLine()!);

                Console.Write("Fee: ");
                updatedDoctor.ConsultationFee =
                     decimal.Parse(
                         Console.ReadLine()!);


                string result =
                    doctorService.UpdateDoctorById(
                        updateId,
                        updatedDoctor);

                Console.WriteLine(result);
            }
            catch (PatientNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            break;


        case "9":

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
                break;
            }

            var doctors =
                doctorService
                .SearchBySpecialisation(specialisation);

            foreach (var d in doctors)
            {
                Console.WriteLine(
                    $"ID:{d.DoctorId} " +
                    $"Dr.{d.FullName}");
            }

            break;

        case "10":
            DateTime date;
            try
            {
                Console.Write("Patient ID: ");

                int patientId =
                    int.Parse(Console.ReadLine()!);

                var selectedPatient =
                    patientService
                    .GetPatientById(patientId);

                Console.Write("Doctor ID: ");

                int doctorId =
                    int.Parse(Console.ReadLine()!);

                var selectedDoctor =
                    doctorService
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
                    appointmentService
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

            break;

        case "11":

            Console.Write(
                "Appointment ID: ");

            int appointmentId =
                int.Parse(Console.ReadLine()!);

            Console.Write(
                "Reason: ");

            string reason =
                Console.ReadLine()!;

            appointmentService
                .CancelAppointment(
                    appointmentId,
                    reason);

            Console.WriteLine(
                "Appointment Cancelled.");
            break;

        case "12":

            Console.Write(
                "Appointment ID: ");

            int appId =
                int.Parse(Console.ReadLine()!);

            var app =
                appointmentService
                .GetAppointmentById(appId);

            if (app != null)
            {
                HealthRecord record = new()
                {
                    Patient = app.Patient,

                    Doctor = app.Doctor,

                    VisitDate = DateTime.Now
                };

                Console.Write(
                    "Diagnosis: ");

                record.Diagnosis =
                    Console.ReadLine()!;

                Console.Write(
                    "Prescription: ");

                record.Prescription =
                    Console.ReadLine()!;

                Console.Write(
                    "Notes: ");

                record.Notes =
                    Console.ReadLine()!;

                healthRecordService.AddRecord(record);



                app.Complete();

                Console.WriteLine(
                    "Health Record Added.");
            }

            break;

        case "13":

            Console.Write(
                "Patient ID: ");

            int pid =
                int.Parse(Console.ReadLine()!);

            var appointments =
                appointmentService
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

            break;

        case "14":

            Console.Write(
                "Patient ID: ");

            int pId =
                int.Parse(Console.ReadLine()!);

            var records =
                healthRecordService
                .GetPatientRecords(pId);

            foreach (var r in records)
            {
                Console.WriteLine(
                    r.GetSummary());
            }

            break;

        case "15":

            try
            {
                Console.Write("Doctor ID: ");

                int doctorId =
                    int.Parse(Console.ReadLine()!);

                Console.Write(
                    "Enter Date (dd-MM-yyyy): ");

                string input =
                    Console.ReadLine()!;

                if (!DateTime.TryParseExact(
                        input,
                        "dd-MM-yyyy",
                        null,
                        System.Globalization.DateTimeStyles.None,
                        out DateTime dat))
                {
                    Console.WriteLine(
                        "Invalid Date Format.");

                    break;
                }

                var availableSlots =
                    appointmentService
                    .CheckDoctorAvailability(
                        doctorId,
                        dat);

                Console.WriteLine(
                    "\nAvailable Slots:");

                foreach (var slot in availableSlots)
                {
                    Console.WriteLine(slot);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Error: {ex.Message}");
            }

            break;

        case "16":

            try
            {
                Console.Write("Doctor ID: ");

                int doctorId =
                    int.Parse(Console.ReadLine()!);

                Console.Write(
                    "From Date (dd-MM-yyyy): ");

                DateTime fromDate =
                    DateTime.ParseExact(
                        Console.ReadLine()!,
                        "dd-MM-yyyy",
                        null);

                Console.Write(
                    "To Date (dd-MM-yyyy): ");

                DateTime toDate =
                    DateTime.ParseExact(
                        Console.ReadLine()!,
                        "dd-MM-yyyy",
                        null);

                var apptments =
                    appointmentService
                    .GetUpcomingAppointmentsByDoctor(
                        doctorId,
                        fromDate,
                        toDate);

                if (!apptments.Any())
                {
                    Console.WriteLine(
                        "No upcoming appointments found.");
                }
                else
                {
                    Console.WriteLine(
                        "\nUpcoming Appointments:\n");

                    foreach (var appointment in apptments)
                    {
                        Console.WriteLine(
                            $"Appointment ID : {appointment.AppointmentId}");

                        Console.WriteLine(
                            $"Patient Name   : {appointment.Patient.FullName}");

                        Console.WriteLine(
                            $"Date           : {appointment.ScheduledDate:dd-MM-yyyy}");

                        Console.WriteLine(
                            $"Slot           : {appointment.TimeSlot}");

                        Console.WriteLine(
                            $"Status         : {appointment.Status}");

                        Console.WriteLine(
                            "--------------------------------");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Error: {ex.Message}");
            }

            break;

        case "17":

            try
            {
                Console.Write("Doctor ID: ");

                int doctorId =
                    int.Parse(Console.ReadLine()!);

                Console.Write("Patient ID: ");

                int patientId =
                    int.Parse(Console.ReadLine()!);

                var record =
                    healthRecordService
                    .GetHealthRecordsByDoctor(
                        doctorId,
                        patientId);

                if (!record.Any())
                {
                    Console.WriteLine(
                        "No health records found.");
                }
                else
                {
                    Console.WriteLine(
                        "\nHealth Records:\n");

                    foreach (var rec in record)
                    {
                        Console.WriteLine(
                            $"Record ID    : {rec.RecordId}");

                        Console.WriteLine(
                            $"Patient Name : {rec.Patient.FullName}");

                        Console.WriteLine(
                            $"Doctor Name  : Dr. {rec.Doctor.FullName}");

                        Console.WriteLine(
                            $"Visit Date   : {rec.VisitDate:dd-MM-yyyy}");

                        Console.WriteLine(
                            $"Diagnosis    : {rec.Diagnosis}");

                        Console.WriteLine(
                            $"Prescription : {rec.Prescription}");

                        Console.WriteLine(
                            $"Notes        : {rec.Notes}");

                        Console.WriteLine(
                            "--------------------------------");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Error: {ex.Message}");
            }

            break;

        case "18":

            try
            {
                Console.Write("Enter Doctor ID: ");

                int doctorId =
                    int.Parse(Console.ReadLine()!);

                Console.Write(
                    "Make Doctor Active? (yes/no): ");

                string input =
                    Console.ReadLine()!.Trim().ToLower();

                bool isActive;

                if (input == "yes")
                {
                    isActive = true;
                }
                else if (input == "no")
                {
                    isActive = false;
                }
                else
                {
                    Console.WriteLine(
                        "Invalid input. Enter yes or no.");
                    break;
                }

                string result =
                    doctorService.ChangeDoctorStatus(
                        doctorId,
                        isActive);

                Console.WriteLine(result);
            }
            catch (DoctorNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            break;

        case "19":

            Console.Write("Doctor ID: ");

            int doctId =
                int.Parse(Console.ReadLine()!);

            var pendingAppointments =
                appointmentService
                .GetPendingAppointmentsByDoctor(
                    doctId);

            if (!pendingAppointments.Any())
            {
                Console.WriteLine(
                    "No pending appointments.");
            }
            else
            {
                foreach (var appointment
                    in pendingAppointments)
                {
                    Console.WriteLine(
                        appointment.GetDetails());

                    Console.WriteLine(
                        "----------------------");
                }
            }

            break;

        case "20":

            try
            {
                Console.Write(
                    "Appointment ID: ");

                int appointId =
                    int.Parse(Console.ReadLine()!);

                appointmentService
                    .ConfirmAppointment(
                        appointId);

                Console.WriteLine(
                    "Appointment confirmed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            break;

        case "21":

            try
            {
                Console.Write(
                    "Appointment ID: ");

                int appoinmentId =
                    int.Parse(Console.ReadLine()!);

                Console.Write(
                    "Reason for cancellation: ");

                string reson =
                    Console.ReadLine()!;

                appointmentService
                    .CancelAppointment(
                        appoinmentId,
                        reson);

                Console.WriteLine(
                    "Appointment cancelled.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            break;

        case "22":
            return;
    }

    Console.WriteLine(
        "\nPress any key...");
    Console.ReadKey();
}