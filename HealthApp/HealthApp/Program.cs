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
using System.Reflection;

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

    Console.WriteLine("==========================================");
    Console.WriteLine("        HEALTHCARE MANAGEMENT SYSTEM       ");
    Console.WriteLine("==========================================\n");

    Console.WriteLine("  [1]  Register Patient");
    Console.WriteLine("  [2]  View All Patients");
    Console.WriteLine("  [3]  Update Patient Details");
    Console.WriteLine("  [4]  Delete Patient");
    Console.WriteLine("  [5]  Add Doctor");
    Console.WriteLine("  [6]  Search Doctors");
    Console.WriteLine("  [7]  Book Appointment");
    Console.WriteLine("  [8]  Cancel Appointment");
    Console.WriteLine("  [9]  Add Health Record");
    Console.WriteLine("  [10] View Patient Appointments");
    Console.WriteLine("  [11] View Health History");
    Console.WriteLine("  [12] Exit\n");

    Console.WriteLine("==========================================");
    Console.Write("Select an option: ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Patient patient = new Patient();

            Console.Write("Name: ");
            patient.FullName =
                Console.ReadLine()!;

            Console.Write("DOB (dd-mm-yyyy): ");
            patient.DateOfBirth =
                DateTime.Parse(
                    Console.ReadLine()!);

            Console.Write("Gender (Male/Female/Other): ");

            string genderInput = Console.ReadLine()!;

            //if (Enum.TryParse(genderInput, true, out GenderType gender))
            //{
            //    patient.Gender = gender;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Gender");
            //    break;
            //}

            Console.Write("Phone: ");
            patient.PhoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Email: ");
            patient.Email = Console.ReadLine()!;

            Console.Write("Insurance ID: ");
            patient.InsuranceId =
                Console.ReadLine()!;

            patientService.AddPatient(patient);

            break;

        case "2":

            var patients = patientService.GetAll();

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

                int updateId = Convert.ToInt32(Console.ReadLine()!);

                var checkPatient = patientService.GetById(updateId);
                if (checkPatient != null)
                {
                    Patient updatedPatient = new Patient();

                    Console.Write("Name: ");
                    updatedPatient.FullName = Console.ReadLine()!;

                    Console.Write("DOB (dd-mm-yyyy): ");
                    updatedPatient.DateOfBirth =
                    DateTime.Parse(Console.ReadLine()!);

                    Console.Write("Gender (Male/Female/Other): ");

                    updatedPatient.Gender = Console.ReadLine()!;

                    //if (Enum.TryParse(genderInput, true,
                    //    out GenderType gender))
                    //{
                    //    updatedPatient.Gender = gender;
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Invalid Gender");
                    //    break;
                    //}

                    Console.Write("Phone: ");
                    updatedPatient.PhoneNumber =
                        Convert.ToInt64(Console.ReadLine())!;

                    Console.Write("Email: ");
                    updatedPatient.Email =
                        Console.ReadLine()!;

                    Console.Write("Insurance ID: ");
                    updatedPatient.InsuranceId =
                        Console.ReadLine()!;

                    string result =
                        patientService.UpdatePatient(
                            updateId,
                            updatedPatient);

                    Console.WriteLine(result);
                }
            }
            catch (PatientNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
                break;

        //case "4":

        //    try
        //    {
               //Console.Write("Enter Patient ID to Delete: ");

        //        int deleteId =
        //            int.Parse(Console.ReadLine()!);

        //        string result =
        //            patientService.DeletePatient(deleteId);

        //        Console.WriteLine(result);
        //    }
        //    catch (PatientNotFoundException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //    break;

        case "4":
            try
            {
                Console.Write("Enter Patient ID: ");
                int id = int.Parse(Console.ReadLine()!);

                Console.WriteLine(patientService.DeletePatient(id));
            }
            catch(PatientNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case "5":

            Doctor doctor = new();

            Console.Write("Name: ");
            doctor.FullName = Console.ReadLine()!;

            Console.Write("Specialisation: ");
            doctor.Specialisation = Console.ReadLine()!;

            Console.Write("Experience: ");
            doctor.YearsOfExperience = int.Parse(Console.ReadLine()!);

            //Console.Write("Email: ");
            //doctor.DoctorEmail = Console.ReadLine()!;

            //Console.Write("Phone: ");
            //doctor.DoctorPhoneNo = Console.ReadLine()!;

            Console.Write("Fee: ");
            doctor.ConsultationFee = Convert.ToDecimal(Console.ReadLine()!);

            doctorService.AddDoctor(doctor);

            Console.WriteLine("\nDoctor Added Successfully");
            break;


        case "6":
            Console.Write("Specialisation: ");
            var docs = doctorService.GetDoctorsBySpecialisation(Console.ReadLine()!);

            foreach (var d in docs)
            {
                Console.WriteLine($"ID: {d.DoctorId} | Dr.{d.FullName}");
            }
            break;

        case "7":
            try
            {
                Console.Write("Patient ID: ");
                var patientObj = patientService.GetById(int.Parse(Console.ReadLine()!));

                Console.Write("Doctor ID: ");
                var doctorObj = doctorService.GetDoctorById(int.Parse(Console.ReadLine()!));

                Console.Write("Date: ");
                DateTime date = DateTime.Parse(Console.ReadLine()!);

                Console.WriteLine("Available Slots:");
                for (int i = 0; i < TimeSlots.Slots.Count; i++)
                    Console.WriteLine($"{i + 1}. {TimeSlots.Slots[i]}");

                int choiceSlot = int.Parse(Console.ReadLine()!);
                string slot = TimeSlots.Slots[choiceSlot - 1];

                var a = appointmentService.BookAppointment(patientObj, doctorObj, date, slot);

                Console.WriteLine("\nAppointment Booked");
                Console.WriteLine(a.GetDetails());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;

        case "8":
            try
            {
                Console.Write("Appointment ID: ");
                int appId = int.Parse(Console.ReadLine()!);

                Console.Write("Reason: ");
                string reason = Console.ReadLine()!;

                appointmentService.CancelAppointment(appId, reason);
                Console.WriteLine("Cancelled.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;


        case "9":
            try
            {
                Console.Write("Appointment ID: ");
                var appt = appointmentService.GetAppointmentById(int.Parse(Console.ReadLine()!));

                if (appt != null)
                {
                    HealthRecords r = new()
                    {
                        Patient = appt.Patient.FullName,
                        Doctor = appt.Doctor.FullName,
                        VisitDate = DateTime.Now
                    };

                    Console.Write("Diagnosis: ");
                    r.Diagnosis = Console.ReadLine()!;

                    Console.Write("Prescription: ");
                    r.Prescription = Console.ReadLine()!;

                    Console.Write("Notes: ");
                    r.Notes = Console.ReadLine()!;

                    healthRecordService.AddRecord(r);
                    appt.Complete();

                    Console.WriteLine("Record Added");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            break;


        case "10":
            Console.Write("Patient ID: ");
            var apps = appointmentService
                .GetAppointmentsByPatient(int.Parse(Console.ReadLine()!));

            foreach (var app in apps)
            {
                Console.WriteLine(app.GetDetails());
            }
            break;


        case "11":
            try
            {
                Console.Write("Patient ID: ");
                var records = healthRecordService
                    .GetRecordsByPatient(Console.ReadLine()!);

                foreach (var r in records)
                {
                    Console.WriteLine(r.GetSummary());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;



        case "12":
            return;
    }

    Console.WriteLine(
        "\nPress any key...");
    Console.ReadKey();
}