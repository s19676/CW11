using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using WebApplication2.Configurations;

namespace WebApplication2.Models
{
    public class HospitalDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Prescription_Medicament> Prescription_Medicaments { get; set; }

        public HospitalDbContext() { }

        public HospitalDbContext(DbContextOptions options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DoctorConfigurations());
            modelBuilder.ApplyConfiguration(new MedicamentConfigurations());
            modelBuilder.ApplyConfiguration(new PatientConfigurations());
            modelBuilder.ApplyConfiguration(new PrescriptionConfigurations());
            modelBuilder.ApplyConfiguration(new Prescription_MedicationConfiguration());

            var doctorList = new List<Doctor>();
            var doctor = new Doctor();
            doctor.IdDoctor = 1;
            doctor.FirstName = "Janusz";
            doctor.LastName = "Zieba";
            doctor.Email = "AAA";
            doctorList.Add(doctor);
            modelBuilder.Entity<Doctor>().HasData(doctorList);

            var medicamentList = new List<Medicament>();
            var medicament = new Medicament();
            medicament.Description = "This is medicament's description";
            medicament.IdMedicament = 1;
            medicament.Name = "Medicamentus";
            medicament.Type = "Miracle drug";
            medicamentList.Add(medicament);
            modelBuilder.Entity<Medicament>().HasData(medicamentList);

            var patientList = new List<Patient>();
            var patient = new Patient();
            patient.IdPatient = 1;
            patient.BirthDate = DateTime.Now;
            patient.FirstName = "Andrzej";
            patient.LastName = "Kowalski";
            patientList.Add(patient);
            modelBuilder.Entity<Patient>().HasData(patientList);

            var prescriptionList = new List<Prescription>();
            var prescription = new Prescription();
            prescription.Date = DateTime.Now;
            prescription.DueDate = DateTime.Now;
            prescription.IdDoctor = doctor.IdDoctor;
            prescription.IdPatient = patient.IdPatient;
            prescription.IdPrescription = 1;
            prescriptionList.Add(prescription);
            modelBuilder.Entity<Prescription>().HasData(prescriptionList);

            var prescription_MedicamentList = new List<Prescription_Medicament>();
            var prescription_Medicament = new Prescription_Medicament { Details = "Nothing", Dose = 1, IdMedicament = 1, IdPrescription = 1 };
            prescription_MedicamentList.Add(prescription_Medicament);
            modelBuilder.Entity<Prescription_Medicament>().HasData(prescription_MedicamentList);


        }
    }
}