<<<<<<< HEAD
﻿using System.Linq;
using Xunit;
using POD1_NET_ConsoleApp.Database;
using POD1_NET_ConsoleApp.Models;
using POD1_NET_ConsoleApp.Repositories.Impl;
using POD1_NET_ConsoleApp.Exceptions;

namespace POD1_NET_ConsoleAppTests
{
    public class PatientRepositoryTests
    {
        //  1. Get All Patients
        [Fact]
        public void GetAll_ShouldReturnAllPatients()
        {
            var db = new PatientDb();
            var repo = new PatientRepository(db);

            var result = repo.GetAll();

            Assert.NotNull(result);
            Assert.Equal(2, result.Count); // based on your DB
        }

        //  2. Get By Id (Valid)
        [Fact]
        public void GetById_ShouldReturnPatient_WhenExists()
        {
            var db = new PatientDb();
            var repo = new PatientRepository(db);

            var patient = repo.GetById(100);

            Assert.NotNull(patient);
            Assert.Equal("Mark", patient.FullName);
        }

        // 3. Get By Id (Invalid → Exception)
        [Fact]
        public void GetById_ShouldThrowException_WhenNotFound()
        {
            var db = new PatientDb();
            var repo = new PatientRepository(db);

            Assert.Throws<PatientNotFoundException>(
                () => repo.GetById(999)
            );
        }

        // 4. Add Patient
        [Fact]
        public void AddPatient_ShouldIncreaseCount()
        {
            var db = new PatientDb();
            var repo = new PatientRepository(db);

            var newPatient = new Patient
            {
                FullName = "TestUser",
                DateOfBirth = new System.DateTime(2000, 1, 1),
                Gender = "Male",

            };

            var result = repo.AddPatient(newPatient);

            Assert.Equal("Patient added successfully", result);
            Assert.Equal(3, repo.GetAll().Count);
        }

        //  5. Update Patient (Valid)
        [Fact]
        public void UpdatePatient_ShouldModifyData()
        {
            var db = new PatientDb();
            var repo = new PatientRepository(db);

            var updated = new Patient
            {
                FullName = "Updated Name"
            };

            var result = repo.UpdatePatient(100, updated);

            Assert.Equal("Patient updated successfully", result);
            Assert.Equal("Updated Name", repo.GetById(100).FullName);
        }

        //  6. Update Patient (Invalid → Exception)
        [Fact]
        public void UpdatePatient_ShouldThrowException_WhenNotFound()
        {
            var db = new PatientDb();
            var repo = new PatientRepository(db);

            var patient = new Patient();

            Assert.Throws<PatientNotFoundException>(
                () => repo.UpdatePatient(999, patient)
            );
        }

        //  7. Delete Patient (Valid)
        [Fact]
        public void DeletePatient_ShouldRemovePatient()
        {
            var db = new PatientDb();
            var repo = new PatientRepository(db);

            var result = repo.DeletePatient(100);

            Assert.Equal("Deleted successfully", result);
            Assert.Equal(1, repo.GetAll().Count);
        }

        //  8. Delete Patient (Invalid → Exception)
        [Fact]
        public void DeletePatient_ShouldThrowException_WhenNotFound()
        {
            var db = new PatientDb();
            var repo = new PatientRepository(db);

            Assert.Throws<PatientNotFoundException>(
                () => repo.DeletePatient(999)
            );
        }
    }
}
=======
﻿using HealthApp.Database;
using HealthApp.Exceptions;
using HealthApp.Model;
using HealthApp.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAppTests
{
    public class PatientRepositoryTests
    {
        private readonly PatientDb _patientDb;
        private readonly PatientRepository _patientRepository;

        public PatientRepositoryTests()
        {
            _patientDb = new PatientDb();

            _patientDb.Patients.AddRange(new List<Patient>
            {
                new Patient
                {
                    PatientId = 1,
                    FullName = "John Doe",
                    DateOfBirth = new DateTime(1995, 5, 10),
                    Gender = GenderType.Male,
                    PhoneNumber = "9876543210",
                    Email = "john@example.com",
                    InsuranceId = "INS101"
                },

                new Patient
                {
                    PatientId = 2,
                    FullName = "Jane Smith",
                    DateOfBirth = new DateTime(1998, 8, 15),
                    Gender = GenderType.Female,
                    PhoneNumber = "9123456780",
                    Email = "jane@example.com",
                    InsuranceId = "INS102"
                },

                new Patient
                {
                    PatientId = 3,
                    FullName = "Robert Brown",
                    DateOfBirth = new DateTime(1985, 2, 20),
                    Gender = GenderType.Male,
                    PhoneNumber = "9988776655",
                    Email = "robert@example.com",
                    InsuranceId = "INS103"
                }
            });

            _patientRepository = new PatientRepository(_patientDb);
        }

        [Fact]
        public void GetAll_WhenCalled_ShouldReturn3Patients()
        {
            var patients = _patientRepository.GetAll();

            Assert.NotNull(patients);
            Assert.Equal(3, patients.Count);
            Assert.Equal("John Doe", patients[0].FullName);
        }

        [Fact]
        public void GetById_GivenId_ReturnPatientWithSameId()
        {
            var patient = _patientRepository.GetById(2);

            Assert.NotNull(patient);
            Assert.Equal("Jane Smith", patient.FullName);
            Assert.Equal(GenderType.Female, patient.Gender);
        }

        [Fact]
        public void Add_GivenPatientData_AddToPatientDb()
        {
            Patient patient = new Patient
            {
                PatientId = 4,
                FullName = "Chris Evans",
                DateOfBirth = new DateTime(1990, 12, 25),
                Gender = GenderType.Male,
                PhoneNumber = "9001122334",
                Email = "chris@example.com",
                InsuranceId = "INS104"
            };

            _patientRepository.Add(patient);

            var patients = _patientRepository.GetAll();

            Assert.Equal(4, patients.Count);
            Assert.Equal("Chris Evans", patients[3].FullName);
        }

        [Fact]
        public void Update_GivenPatientIdAndPatient_UpdateThePatient()
        {
            Patient updatedPatient = new Patient
            {
                FullName = "Jane Williams",
                DateOfBirth = new DateTime(1997, 7, 7),
                Gender = GenderType.Male,
                PhoneNumber = "9556677889",
                Email = "jane.williams@example.com",
                InsuranceId = "INS202"
            };

            var result = _patientRepository.UpdatePatient(2, updatedPatient);

            Assert.NotNull(result);
            Assert.Equal("Patient with id 2 updated successfully", result);

            var patient = _patientRepository.GetById(2);

            Assert.Equal("Jane Williams", patient.FullName);
            Assert.Equal("INS202", patient.InsuranceId);
        }

        [Fact]
        public void Update_WhenProvidedWithInvalidId_ThrowsPatientNotFoundException()
        {
            Patient patient = new Patient
            {
                FullName = "Invalid Patient",
                DateOfBirth = new DateTime(2000, 1, 1),
                Gender = GenderType.Male,
                PhoneNumber = "9999999999",
                Email = "invalid@example.com",
                InsuranceId = "INS999"
            };

            Assert.Throws<PatientNotFoundException>(
                () => _patientRepository.UpdatePatient(10, patient)
            );
        }

        [Fact]
        public void Delete_WhenProvidedWithPatientId_DeletePatient()
        {
            var result = _patientRepository.DeletePatient(3);

            Assert.NotNull(result);
            Assert.Equal("Patient with id 3 deleted successfully", result);

            Assert.Throws<PatientNotFoundException>(
                () => _patientRepository.GetById(3)
            );
        }

        [Fact]
        public void Delete_WhenProvidedWithInvalidId_ThrowsPatientNotFoundException()
        {
            Assert.Throws<PatientNotFoundException>(
                () => _patientRepository.DeletePatient(100)
            );
        }

        [Fact]
        public void GetById_WhenProvidedInvalidId_ThrowsPatientNotFoundException()
        {
            Assert.Throws<PatientNotFoundException>(
                () => _patientRepository.GetById(50)
            );
        }
    }
}
>>>>>>> 6fd5414360c5379749467140bb0624c15612e801
