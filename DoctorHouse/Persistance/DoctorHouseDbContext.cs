﻿using DoctorHouse.Models;
using Microsoft.EntityFrameworkCore;


namespace DoctorHouse.Persistance
{
    public class DoctorHouseDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Specialist> Specialists { get; set; }
        public DbSet<SpecialistCompanies> SpecialistCompanies { get; set; }
        public DbSet<Appointment> Appointment { get; set; }

        public DoctorHouseDbContext(DbContextOptions<DoctorHouseDbContext> options)
        : base(options)
        {

        }
        public DoctorHouseDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one-to-one - REQUIRED
            modelBuilder.Entity<User>()
            .HasOne(u => u.UserDetails)
            .WithOne(ud => ud.User)
            .HasForeignKey<UserDetails>(ud => ud.UserId);

            //one-to-one - optional relationship
            modelBuilder.Entity<User>().ToTable("Users");

            //many-to-many
            modelBuilder.Entity<SpecialistCompanies>()
            .HasKey(x => new { x.SpecialistId, x.CompanyId });

            //zero-to-many
            modelBuilder.Entity<Specialist>()
                .HasMany(s => s.Appointments)
                .WithOne(a => a.Specialist)
                .IsRequired(false);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Appointments)
                .WithOne(a => a.Customer)
                .IsRequired(false);

            modelBuilder.Entity<Company>()
                .HasMany(com => com.Appointments)
                .WithOne(a => a.Company)
                .IsRequired(false);
        }
    }
}
