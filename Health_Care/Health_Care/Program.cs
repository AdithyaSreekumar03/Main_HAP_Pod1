using HealthApp.Database;
using HealthApp.Models;
using HealthApp.Modules;
using HealthApp.Repositories.impl;
using HealthApp.Repositories.Interface;
using HealthApp.Service.impl;
using HealthApp.Service.Interface;
using Healthcare_Project.Service.impl;
using Microsoft.Extensions.DependencyInjection;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;



class Program
{
    public static void Main()
    {
        var services = new ServiceCollection();

        services.AddSingleton<PatientDB>();
        services.AddSingleton<DoctorDB>();
        services.AddSingleton<HealthRecordsDB>();
        services.AddSingleton<AppointmentDB>();

        services.AddScoped<IPatientRepository, PatientRepository>();
        services.AddScoped<IPatientService, PatientService>();
        services.AddScoped<IDoctorRepository, DoctorRepository>();
        services.AddScoped<IDoctorService,DoctorService>();
        services.AddScoped<IAppointmentRepository,AppointmentRepository>();
        services.AddScoped<IAppointmentService,AppointmentService>();
        services.AddScoped<IHealthRecordRepository, HealthRecordRepository>();
        services.AddScoped<IHealthRecordService, HealthRecordService>();




        var provider = services.BuildServiceProvider();

        var patientService = provider.GetRequiredService<IPatientService>();
        var doctorService = provider.GetRequiredService<IDoctorService>();
        var appointmentService = provider.GetRequiredService<IAppointmentService>();
        var healthService = provider.GetRequiredService<IHealthRecordService>();


        while (true)
        {

            //Patient
            Console.WriteLine("1) Register Patient");
            Console.WriteLine("2) Show all patient details");
            Console.WriteLine("3) Find patient details");
            Console.WriteLine("4) Delete patient");
            //Doctor 
            Console.WriteLine("5) Add Doctor");
            Console.WriteLine("6) Show all doctors");
            Console.WriteLine("7) Find doctor details");
            Console.WriteLine("8) Delete doctor");
            Console.WriteLine("9) Show available doctors");
            //HeathRecords
            Console.WriteLine("10) Add health record");
            Console.WriteLine("11) Show health records");
            Console.WriteLine("12) Update health record");
            Console.WriteLine("13) Search records by patient");
            Console.WriteLine("14) Search records by doctor");

            Console.WriteLine("20) Exit");
            Console.WriteLine();


            Console.WriteLine("Enter the value :");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Patient Registration Form");
                    Patient p = new Patient
                    {
                        CreatedDate = DateTime.Now,
                    };

                    Console.Write("Enter the Patient Name: ");
                    p.FullName = Console.ReadLine()!;

                    while (!p.IsNameValid(p.FullName))
                    {
                        Console.WriteLine("Invalid patient name");
                        Console.Write("Enter the Patient Name again: ");
                        p.FullName = Console.ReadLine()!;
                    }

                    Console.Write("Enter the Date of Birth(yyyy-mm-dd):");
                    p.DateOfBirth = DateTime.Parse(Console.ReadLine()!);
                    Console.Write("Enter the Gender: ");
                    p.Gender = Console.ReadLine()!;
                    Console.Write("Enter the PhoneNumber: ");
                    p.PhoneNumber = Console.ReadLine()!;

                    while (!p.IsPhoneNumberValid(p.PhoneNumber))
                    {
                        Console.WriteLine("Invalid Phone Number");
                        Console.Write("Enter the Phone Number again: ");
                        p.PhoneNumber = Console.ReadLine()!;
                    }
                    
                    
                    Console.Write("Enter the Email: ");
                    p.Email = Console.ReadLine()!;
                    Console.Write("Enter the Insurance Id: ");
                    p.InsuranceId = Console.ReadLine()!;

                    patientService.AddPatient(p);
                    Console.WriteLine();

                    break;
                case 2:
                    Console.WriteLine("All the Patient");
                    var patient = patientService.GetAllPatients();
                    foreach (var pat in patient)
                    {
                        Console.WriteLine(pat);
                    }
                    break;


                case 3:
                    Console.WriteLine("Find the Patient");
                    Console.Write("Enter Patient Id :");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var result = patientService.GetById(id);
                    Console.WriteLine(result);
                    Console.WriteLine();
                    break;


                case 4:
                    Console.WriteLine("Delete the Patient");
                    Console.Write("Enter Patient Id :");
                    id = Convert.ToInt32(Console.ReadLine());
                    var result_ = patientService.DeletePatient(id);
                    Console.WriteLine(result_);
                    Console.WriteLine();
                    break;





                //Doctor
                case 5:
                    Console.WriteLine("Doctor Registration Form");
                    Doctor d = new Doctor
                    {
                        IsActive = true
                    };
                    Console.Write("Enter Doctor Name: ");
                    d.doctorName = Console.ReadLine()!;
                    Console.Write("Enter Specialization: ");
                    d.Specialisation = Console.ReadLine()!;
                    Console.Write("Experience: ");
                    d.YearsOfExperience = int.Parse(Console.ReadLine()!);
                    Console.Write("Consultation Fee: ");
                    d.ConsultationFee = int.Parse(Console.ReadLine()!);

                    doctorService.AddDoctor(d);
                    Console.WriteLine();

                    break;

                case 6:
                    Console.WriteLine("All the Doctors");
                    var doctor = doctorService.GetAllDoctors();
                    foreach (var pat in doctor)
                    {
                        Console.WriteLine(pat);
                    }
                    Console.WriteLine();
                    break;
                case 7:
                    Console.WriteLine("Find the Doctor");
                    Console.Write("Enter Doctor Id :");
                    var i_id = Convert.ToInt32(Console.ReadLine());
                    var i_result = doctorService.GetDoctorById(i_id);
                    Console.WriteLine(i_result);
                    Console.WriteLine();
                    break;
                case 8:
                    Console.WriteLine("Delete the Doctor");
                    Console.Write("Enter Doctor Id :");
                    i_id = Convert.ToInt32(Console.ReadLine());
                    var st_result = doctorService.DeleteDoctor(i_id);
                    Console.WriteLine(st_result);
                    Console.WriteLine();
                    break;

                case 9:
                    Console.WriteLine("Show the Available Doctors");
                    var d_result = doctorService.GetAvailableDoctors();
                    if (d_result.Count > 0)
                    {
                        foreach (var i in d_result)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No doctors available");
                    }


                    break;







                //healthRecords
                case 11:
                    Console.WriteLine("HealthRecords");

                    var h_result = healthService.GetAllRecords();
                    foreach (var record in h_result)
                    {
                        Console.WriteLine(record);
                    }
                    break;
                

                case 20:
                    return;
            }


            Console.WriteLine();
        }




    }
}