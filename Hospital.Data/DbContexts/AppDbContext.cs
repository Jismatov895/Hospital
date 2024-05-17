﻿using Hospital.Domain.Commons;
using Hospital.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Data.DbContexts;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<PrescriptionItem> PrescriptionItems { get; set; }
    public DbSet<UserContact> UserContacts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost; Database=HospitalDb; Port=5432; User ID=postgres; Password=root");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Ali",
                    LastName = "Valiyev",
                    Password = "Password",
                    Email = "Valijonov@gmail.com",
                },
                new User
                {
                    Id = 2,
                    FirstName = "Ali",
                    LastName = "Valiyev",
                    Password = "Password",
                    Email = "Valijonov@gmail.com",
                },
                new User
                {
                    Id = 3,
                    FirstName = "Ali",
                    LastName = "Valiyev",
                    Password = "Password",
                    Email = "Valijonov@gmail.com",
                },
                new User
                {
                    Id = 4,
                    FirstName = "Ali",
                    LastName = "Valiyev",
                    Password = "Password",
                    Email = "Valijonov@gmail.com",
                });

        modelBuilder.Entity<UserContact>()
            .HasData(
                new UserContact
                {
                    Id = 1,
                    Phone = "+9989901233567",
                    Address = "Andijon Shahri",
                    UserId = 3
                },
                new UserContact
                {
                    Id = 2,
                    Phone = "+9989901234567",
                    Address = "Qarshi Shahri",
                    UserId = 4
                },
                new UserContact
                {
                    Id = 3,
                    Phone = "+9989901234567",
                    Address = "Toshkent Shahri",
                    UserId = 2
                });

        modelBuilder.Entity<Doctor>()
            .HasData(
                new Doctor
                {
                    Id = 1,
                    FirstName = "Umidjon",
                    LastName = "Maxammadsoliyev",
                    Password = "Password",
                    Email = "email@gmail.com",
                    Position = "Dentist"
                },
                new Doctor
                {
                    Id = 2,
                    FirstName = "Odiljon",
                    LastName = "Maxammadsoliyev",
                    Password = "Password",
                    Email = "email@gmail.com",
                    Position = "Dentist"
                },
                new Doctor
                {
                    Id = 3,
                    FirstName = "Valijon",
                    LastName = "Maxammadsoliyev",
                    Password = "Password",
                    Email = "email@gmail.com",
                    Position = "Dentist"
                });

        modelBuilder.Entity<Appointment>()
            .HasData(
                new Appointment
                {
                    Id = 1,
                    DateTime = DateTime.UtcNow,
                    UserId = 1,
                    DoctorId = 1
                },
                new Appointment
                {
                    Id = 2,
                    DateTime = DateTime.UtcNow,
                    UserId = 2,
                    DoctorId = 2
                },
                new Appointment
                {
                    Id = 3,
                    DateTime = DateTime.UtcNow,
                    UserId = 3,
                    DoctorId = 3
                });

        modelBuilder.Entity<Prescription>()
            .HasData(
                new Prescription
                {
                    Id = 1,
                    DoctorId = 1,
                    UserId = 1,
                    DateTime = DateTime.UtcNow
                },
                new Prescription
                {
                    Id = 2,
                    DoctorId = 3,
                    UserId = 2,
                    DateTime = DateTime.UtcNow
                });

        modelBuilder.Entity<PrescriptionItem>()
            .HasData(
                new PrescriptionItem
                {
                    Id = 1,
                    PrescriptionId = 1,
                    MedicineName = "Dori",
                    MedicineUsage = "Ichiladi",
                    Days = 11
                },
                new PrescriptionItem
                {
                    Id = 2,
                    PrescriptionId = 1,
                    MedicineName = "sdsds",
                    MedicineUsage = "sdsd",
                    Days = 11
                },
                new PrescriptionItem
                {
                    Id = 3,
                    PrescriptionId = 2,
                    MedicineName = "Dori",
                    MedicineUsage = "Ichiladi",
                    Days = 11
                },
                new PrescriptionItem
                {
                    Id = 4,
                    PrescriptionId = 2,
                    MedicineName = "DoriDarmon",
                    MedicineUsage = "Ichiladi",
                    Days = 11
                });
    }
}
