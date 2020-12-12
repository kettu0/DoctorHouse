﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorHouse.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Description { get; set; }
    }
}
