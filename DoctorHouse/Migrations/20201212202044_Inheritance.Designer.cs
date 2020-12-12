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
    [Migration("20201212202044_Inheritance")]
    partial class Inheritance
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DoctorHouse.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("DoctorHouse.Models.Customer", b =>
                {
                    b.HasBaseType("DoctorHouse.Models.User");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.HasDiscriminator().HasValue("Customer");
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
                });

            modelBuilder.Entity("DoctorHouse.Models.UserDetails", b =>
                {
                    b.HasOne("DoctorHouse.Models.User", "User")
                        .WithOne("UserDetails")
                        .HasForeignKey("DoctorHouse.Models.UserDetails", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DoctorHouse.Models.User", b =>
                {
                    b.Navigation("UserDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
