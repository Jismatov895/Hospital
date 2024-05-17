﻿// <auto-generated />
using System;
using Hospital.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hospital.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240517043853_SeedData1")]
    partial class SeedData1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Hospital.Domain.Entities.Appointment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("DoctorId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("UserId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Hospital.Domain.Entities.Doctor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Hospital.Domain.Entities.Prescription", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("DoctorId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("UserId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("Hospital.Domain.Entities.PrescriptionItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Days")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("MedicineName")
                        .HasColumnType("text");

                    b.Property<string>("MedicineUsage")
                        .HasColumnType("text");

                    b.Property<long>("PrescriptionId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("PrescriptionItems");
                });

            modelBuilder.Entity("Hospital.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2024, 5, 17, 4, 38, 52, 809, DateTimeKind.Utc).AddTicks(6319),
                            Email = "Valijonov@gmail.com",
                            FirstName = "Ali",
                            IsDeleted = false,
                            LastName = "Valiyev",
                            Password = "Password"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2024, 5, 17, 4, 38, 52, 809, DateTimeKind.Utc).AddTicks(6326),
                            Email = "Valijonov@gmail.com",
                            FirstName = "Ali",
                            IsDeleted = false,
                            LastName = "Valiyev",
                            Password = "Password"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2024, 5, 17, 4, 38, 52, 809, DateTimeKind.Utc).AddTicks(6329),
                            Email = "Valijonov@gmail.com",
                            FirstName = "Ali",
                            IsDeleted = false,
                            LastName = "Valiyev",
                            Password = "Password"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2024, 5, 17, 4, 38, 52, 809, DateTimeKind.Utc).AddTicks(6330),
                            Email = "Valijonov@gmail.com",
                            FirstName = "Ali",
                            IsDeleted = false,
                            LastName = "Valiyev",
                            Password = "Password"
                        });
                });

            modelBuilder.Entity("Hospital.Domain.Entities.UserContact", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserContacts");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Address = "Andijon Shahri",
                            CreatedAt = new DateTime(2024, 5, 17, 4, 38, 52, 809, DateTimeKind.Utc).AddTicks(6562),
                            IsDeleted = false,
                            Phone = "+9989901233567",
                            UserId = 3L
                        },
                        new
                        {
                            Id = 2L,
                            Address = "Qarshi Shahri",
                            CreatedAt = new DateTime(2024, 5, 17, 4, 38, 52, 809, DateTimeKind.Utc).AddTicks(6567),
                            IsDeleted = false,
                            Phone = "+9989901234567",
                            UserId = 4L
                        },
                        new
                        {
                            Id = 3L,
                            Address = "Toshkent Shahri",
                            CreatedAt = new DateTime(2024, 5, 17, 4, 38, 52, 809, DateTimeKind.Utc).AddTicks(6582),
                            IsDeleted = false,
                            Phone = "+9989901234567",
                            UserId = 2L
                        });
                });

            modelBuilder.Entity("Hospital.Domain.Entities.Appointment", b =>
                {
                    b.HasOne("Hospital.Domain.Entities.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.Domain.Entities.User", "User")
                        .WithMany("Appointments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hospital.Domain.Entities.Prescription", b =>
                {
                    b.HasOne("Hospital.Domain.Entities.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.Domain.Entities.User", "User")
                        .WithMany("Prescriptions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hospital.Domain.Entities.PrescriptionItem", b =>
                {
                    b.HasOne("Hospital.Domain.Entities.Prescription", "Prescription")
                        .WithMany("Items")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("Hospital.Domain.Entities.UserContact", b =>
                {
                    b.HasOne("Hospital.Domain.Entities.User", "User")
                        .WithOne("Contact")
                        .HasForeignKey("Hospital.Domain.Entities.UserContact", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hospital.Domain.Entities.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("Hospital.Domain.Entities.Prescription", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Hospital.Domain.Entities.User", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Contact");

                    b.Navigation("Prescriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
