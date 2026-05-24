using HealthApp.Database;
using HealthApp.Exceptions;
using HealthApp.Menu;
using HealthApp.Menus;
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

services.AddTransient<PatientMenu>();
services.AddTransient<DoctorMenu>();

var provider = services.BuildServiceProvider();

var patientService = provider.GetRequiredService<IPatientService>();
var doctorService = provider.GetRequiredService<IDoctorService>();
var appointmentService = provider.GetRequiredService<IAppointmentService>();
var healthRecordService = provider.GetRequiredService<IHealthRecordService>();

var patientMenu = provider.GetRequiredService<PatientMenu>();
var doctorMenu = provider.GetRequiredService<DoctorMenu>();


while (true)
{
    Console.Clear();
    Console.WriteLine("===== HEALTHCARE MANAGEMENT SYSTEM =====");
    Console.WriteLine("1. Patient Menu");
    Console.WriteLine("2. Doctor Menu");
    Console.WriteLine("3. Exit");

    Console.Write("\nChoose: ");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            patientMenu.Show();
            break;

        case "2":
            doctorMenu.Show();
            break;

        case "3":
            return;

        default:
            Console.WriteLine("Invalid choice.");
            Console.ReadKey();
            break;
    }
}