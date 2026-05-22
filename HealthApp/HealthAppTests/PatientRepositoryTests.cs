using HealthApp.Databases;
using HealthApp.Exceptions;
using HealthApp.Models;
using HealthApp.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAppTests
{
    using HealthApp.Databases;
    using HealthApp.Exceptions;
    using HealthApp.Models;
    using HealthApp.Repository.Impl;

    public class PatientRepositoryTests
    {
        private readonly PatientDb _patientDb;
        private readonly PatientRepository _patientRepository;

        public PatientRepositoryTests()
        {
            _patientDb = new PatientDb();

            _patientDb.patients.AddRange(new List<Patient>
            {
                new Patient
                {
                    PatientId = 5,
                    FullName = "John Doe",
                    DateOfBirth = new DateTime(1995, 5, 10),
                    Gender = GenderType.Male,
                    PhoneNumber = "9876543210",
                    Email = "john@example.com",
                    InsuranceId = "INS101"
                },

                new Patient
                {
                    PatientId = 6,
                    FullName = "Jane Smith",
                    DateOfBirth = new DateTime(1998, 8, 15),
                    Gender = GenderType.Female,
                    PhoneNumber = "9123456780",
                    Email = "jane@example.com",
                    InsuranceId = "INS102"
                },

                new Patient
                {
                    PatientId = 7,
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
            Assert.Equal(7, patients.Count);
            Assert.Equal("John Doe", patients[4].FullName);
        }

        [Fact]
        public void GetById_GivenId_ReturnPatientWithSameId()
        {
            var patient = _patientRepository.GetById(6);

            Assert.NotNull(patient);
            Assert.Equal("Jane Smith", patient.FullName);
            Assert.Equal(GenderType.Female, patient.Gender);
        }

        [Fact]
        public void Add_GivenPatientData_AddToPatientDb()
        {
            Patient patient = new Patient
            {
                PatientId = 8,
                FullName = "Chris Evans",
                DateOfBirth = new DateTime(1990, 12, 25),
                Gender = GenderType.Male,
                PhoneNumber = "9001122334",
                Email = "chris@example.com",
                InsuranceId = "INS104"
            };

            _patientRepository.Add(patient);

            var patients = _patientRepository.GetAll();

            Assert.Equal(8, patients.Count);
            Assert.Equal("Chris Evans", patients[7].FullName);
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
