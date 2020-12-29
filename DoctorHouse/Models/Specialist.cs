﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorHouse.Models
{
    public class Specialist : User
    {
        [Required]
        public string SpecialistType { get; set; }
        public int? Area { get; set; }

        [Required]
        public ICollection<SpecialistCompanies> SpecialistCompanies { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

    }
}
