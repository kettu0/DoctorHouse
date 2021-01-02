﻿// <auto-generated />
using System;
using DoctorHouse.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoctorHouse.Migrations
{
    [DbContext(typeof(DoctorHouseDbContext))]
    [Migration("20210102193636_PopulateSpecialistTable")]
    partial class PopulateSpecialistTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DoctorHouse.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int?>("SpecialistId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SpecialistId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("DoctorHouse.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<long>("NIP")
                        .HasColumnType("bigint");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<byte>("Rating")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Ul. Wielkiego Wybuchu 5",
                            CompanyName = "BigPips",
                            Description = "Robimy wszystko od ręki",
                            IsVerified = true,
                            NIP = 1234567890L,
                            PhoneNumber = 123432234L,
                            Rating = (byte)0
                        },
                        new
                        {
                            Id = 2,
                            Address = "Ul. Napoleona Pipa 7/10",
                            CompanyName = "The Pipis",
                            Description = "Piriririririr",
                            IsVerified = true,
                            NIP = 9807654321L,
                            PhoneNumber = 333222111L,
                            Rating = (byte)0
                        });
                });

            modelBuilder.Entity("DoctorHouse.Models.SpecialistCompanies", b =>
                {
                    b.Property<int>("SpecialistId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.HasKey("SpecialistId", "CompanyId");

                    b.HasIndex("CompanyId");

                    b.ToTable("SpecialistCompanies");
                });

            modelBuilder.Entity("DoctorHouse.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("DoctorHouse.Models.UserDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateOfRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfRegistration = new DateTime(2021, 1, 2, 20, 36, 35, 97, DateTimeKind.Local).AddTicks(4745),
                            EMail = "pipi@pip.pi",
                            FirstName = "Pipek",
                            LastName = "Pipowski",
                            PhoneNumber = 123456789L,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateOfRegistration = new DateTime(2021, 1, 2, 20, 36, 35, 101, DateTimeKind.Local).AddTicks(396),
                            EMail = "piri666@pip.pir",
                            FirstName = "Pirek",
                            LastName = "Pir",
                            PhoneNumber = 666777111L,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            DateOfRegistration = new DateTime(2021, 1, 2, 20, 36, 35, 102, DateTimeKind.Local).AddTicks(591),
                            EMail = "jank@gmail0.com",
                            FirstName = "Jan",
                            LastName = "Kowalski",
                            PhoneNumber = 444234089L,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            DateOfRegistration = new DateTime(2021, 1, 2, 20, 36, 35, 102, DateTimeKind.Local).AddTicks(613),
                            EMail = "alojzyKA@gmail.pl",
                            FirstName = "Alojzy",
                            LastName = "Kwiatek",
                            PhoneNumber = 654354676L,
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            DateOfRegistration = new DateTime(2021, 1, 2, 20, 36, 35, 102, DateTimeKind.Local).AddTicks(617),
                            EMail = "halinka@onet.com",
                            FirstName = "Halina",
                            LastName = "Kluczkowska",
                            PhoneNumber = 967545234L,
                            UserId = 5
                        });
                });

            modelBuilder.Entity("DoctorHouse.Models.Customer", b =>
                {
                    b.HasBaseType("DoctorHouse.Models.User");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.HasDiscriminator().HasValue("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsAdmin = false,
                            Password = "Pipi666",
                            Username = "Pipi",
                            Address = "ul. Pipiego 2"
                        },
                        new
                        {
                            Id = 2,
                            IsAdmin = false,
                            Password = "123456",
                            Username = "Piri",
                            Address = "os. Pipowo 5/4"
                        });
                });

            modelBuilder.Entity("DoctorHouse.Models.Specialist", b =>
                {
                    b.HasBaseType("DoctorHouse.Models.User");

                    b.Property<int?>("Area")
                        .HasColumnType("int");

                    b.Property<string>("SpecialistType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Specialist");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            IsAdmin = true,
                            Password = "elelele",
                            Username = "ElectricWizard",
                            Area = 5,
                            SpecialistType = "Electrician"
                        },
                        new
                        {
                            Id = 4,
                            IsAdmin = false,
                            Password = "66666666",
                            Username = "FlowerPower",
                            Area = 3,
                            SpecialistType = "Gardener"
                        },
                        new
                        {
                            Id = 5,
                            IsAdmin = false,
                            Password = "0%6hasfa",
                            Username = "ZlotaRączka",
                            Area = 1,
                            SpecialistType = "Plumber"
                        });
                });

            modelBuilder.Entity("DoctorHouse.Models.Appointment", b =>
                {
                    b.HasOne("DoctorHouse.Models.Company", "Company")
                        .WithMany("Appointments")
                        .HasForeignKey("CompanyId");

                    b.HasOne("DoctorHouse.Models.Customer", "Customer")
                        .WithMany("Appointments")
                        .HasForeignKey("CustomerId");

                    b.HasOne("DoctorHouse.Models.Specialist", "Specialist")
                        .WithMany("Appointments")
                        .HasForeignKey("SpecialistId");

                    b.Navigation("Company");

                    b.Navigation("Customer");

                    b.Navigation("Specialist");
                });

            modelBuilder.Entity("DoctorHouse.Models.SpecialistCompanies", b =>
                {
                    b.HasOne("DoctorHouse.Models.Company", "Company")
                        .WithMany("Specialists")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorHouse.Models.Specialist", "Specialist")
                        .WithMany("Companies")
                        .HasForeignKey("SpecialistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Specialist");
                });

            modelBuilder.Entity("DoctorHouse.Models.UserDetails", b =>
                {
                    b.HasOne("DoctorHouse.Models.User", "User")
                        .WithOne("Details")
                        .HasForeignKey("DoctorHouse.Models.UserDetails", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DoctorHouse.Models.Company", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Specialists");
                });

            modelBuilder.Entity("DoctorHouse.Models.User", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("DoctorHouse.Models.Customer", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("DoctorHouse.Models.Specialist", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Companies");
                });
#pragma warning restore 612, 618
        }
    }
}
