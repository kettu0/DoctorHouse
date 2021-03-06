﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DoctorHouse.Controllers.Resources
{
    public class SaveUserDetailsResource
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string EMail { get; set; }

        [Required]
        [Range(100000000, 999999999)]
        public Int64 PhoneNumber { get; set; }
        public int UserId { get; set; }
    }
}
