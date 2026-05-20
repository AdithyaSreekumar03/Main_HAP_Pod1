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

    Console.WriteLine("  [1] Register Patient");
    Console.WriteLine("  [2] View All Patients");
    Console.WriteLine("  [3] Update Patient Details");
    Console.WriteLine("  [4] Add Doctor");
    Console.WriteLine("  [5] Search Doctors");
    Console.WriteLine("  [6] Exit\n");

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

                int updateId = int.Parse(Console.ReadLine()!);

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
            catch (PatientNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            break;

        //case "4":

        //    try
        //    {
        //        Console.Write("Enter Patient ID to Delete: ");

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

            Doctor doctor = new();

            Console.Write("Name: ");
            doctor.FullName =
                Console.ReadLine()!;

            Console.Write("Specialisation: ");
            doctor.Specialisation =
                Console.ReadLine()!;

            Console.Write("Experience: ");
            doctor.YearsOfExperience =
                int.Parse(
                    Console.ReadLine()!);

            //Console.Write("Email: ");
            //doctor.DoctorEmail = Console.ReadLine()!;

            //Console.Write("Phone Number: ");
            //doctor.DoctorPhoneNo = Console.ReadLine()!;

            Console.Write("Fee: ");
            doctor.ConsultationFee =
                (int)decimal.Parse(
                    Console.ReadLine()!);


            doctorService.AddDoctor(doctor);

            //doctor.GetDoctorDetailsSummary();


            break;

        case "5":

            Console.Write(
                "Specialisation: ");

            string specialisation =
                Console.ReadLine()!;

            var doctors =
                doctorService
                .GetDoctorsBySpecialisation(
                    specialisation);

            foreach (var d in doctors)
            {
                Console.WriteLine(
                    $"ID:{d.DoctorId} " +
                    $"Dr.{d.FullName}");
            }

            break;

        case "6":
            return;
    }

    Console.WriteLine(
        "\nPress any key...");
    Console.ReadKey();
}