using HealthApp.Databases;
using HealthApp.Exceptions;
using HealthApp.Models;
using HealthApp.Repository.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthAppTests
{
    public class PatientRepositoryTests
    {
        private readonly PatientDb _patientDb;
        private readonly PatientRepository _repository;

        public PatientRepositoryTests()
        {
            _patientDb = new PatientDb();
            _repository = new PatientRepository(_patientDb);
        }


        [Fact]
        public void GetAll_ShouldReturnAllPatients()
        {
            var patients = _repository.GetAll();

            Assert.NotNull(patients);
            Assert.Equal(4, patients.Count);

            var patient = patients.FirstOrDefault(p => p.PatientId == 100);
            Assert.NotNull(patient);
            Assert.Equal("Mark", patient.FullName);
        }


        [Fact]
        public void GetById_ValidId_ReturnsPatient()
        {
            var patient = _repository.GetById(200);

            Assert.NotNull(patient);
            Assert.Equal("Sara", patient.FullName);
            Assert.Equal("Female", patient.Gender);
        }

        [Fact]
        public void GetById_InvalidId_ThrowsException()
        {
            Assert.Throws<PatientNotFoundException>(() => _repository.GetById(9));
        }

        [Fact]
        public void AddPatient_ShouldAddSuccessfully()
        {
            var newPatient = new Patient
            {
                FullName = "Harry",
                DateOfBirth = new DateTime(1990, 1, 1),
                Gender = "Male",
                PhoneNumber = 999999999,
                Email = "harry@test.com",
                InsuranceId = "INS999"
            };

            var result = _repository.AddPatient(newPatient);
            var patients = _repository.GetAll();

            Assert.Equal("Patient added successfully", result);
            Assert.Equal(5, patients.Count);

            var added = patients.FirstOrDefault(p => p.FullName == "Harry");
            Assert.NotNull(added);
            Assert.True(added.Age > 0); 
        }


        [Fact]
        public void UpdatePatient_ValidId_UpdatesFullName()
        {
            var updated = new Patient
            {
                FullName = "Updated Name"
            };

            var result = _repository.UpdatePatient(200, updated);

            Assert.Equal("Patient updated", result);

            var patient = _repository.GetById(200);
            Assert.Equal("Updated Name", patient.FullName);
            Assert.Equal("INS1006", patient.InsuranceId);
        }


        [Fact]
        public void UpdatePatient_InvalidId_ThrowsException()
        {
            var patient = new Patient { FullName = "Test" };
            Assert.Throws<PatientNotFoundException>(() =>
                _repository.UpdatePatient(9, patient));
        }

        [Fact]
        public void DeletePatient_ValidId_DeletesPatient()
        {
            var result = _repository.DeletePatient(300);

            Assert.Equal("Deleted successfully", result);

            Assert.Throws<PatientNotFoundException>(() =>
                _repository.GetById(300));
        }


        [Fact]
        public void DeletePatient_InvalidId_ThrowsException()
        {
            Assert.Throws<PatientNotFoundException>(() =>
                _repository.DeletePatient(9));
        }

    }
}
