using HealthApp.Constant;
using HealthApp.Database;
using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Impl;
using HealthApp.Repository.Interface;
using HealthApp.Service.Impl;
using HealthApp.Service.Interface;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Numerics;
using Microsoft.Extensions.DependencyInjection;

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
    Console.WriteLine("13. View Patient Appointments");
    Console.WriteLine("14. View Health History");
    Console.WriteLine("15. Exit");

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
                    Console.Write("DOB (dd-mm-yyyy): ");

                    string dobInput = Console.ReadLine()!;

                    if (!DateTime.TryParse(dobInput, out DateTime dob))
                    {
                        Console.WriteLine("Invalid Date Format.");
                        continue;
                    }

                    if (dob > DateTime.Today)
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
                    Console.Write("DOB (dd-mm-yyyy): ");

                    string dobInput = Console.ReadLine()!;

                    if (!DateTime.TryParse(dobInput, out DateTime dob))
                    {
                        Console.WriteLine("Invalid Date Format.");
                        continue;
                    }

                    if (dob > DateTime.Today)
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

            Console.Write("Fee: ");
            doctor.ConsultationFee =
                decimal.Parse(
                    Console.ReadLine()!);


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

                Console.Write("Date: ");

                DateTime date =
                    DateTime.Parse(
                        Console.ReadLine()!);

                Console.WriteLine(
                    "\nAvailable Slots:");

                for (int i = 0;
                    i < TimeSlot.Slots.Count;
                    i++)
                {
                    Console.WriteLine(
                        $"{i + 1}. " +
                        $"{TimeSlot.Slots[i]}");
                }

                int slotChoice =
                    int.Parse(
                        Console.ReadLine()!);

                string slot =
                    TimeSlot.Slots[
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

                healthRecordService
                    .AddRecord(record);



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

            foreach (var a in appointments)
            {
                Console.WriteLine(
                    a.GetDetails());

                Console.WriteLine(
                    "---------------");
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
            return;
    }

    Console.WriteLine(
        "\nPress any key...");
    Console.ReadKey();
}