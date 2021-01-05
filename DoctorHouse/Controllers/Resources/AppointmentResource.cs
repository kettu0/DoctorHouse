﻿using Castle.MicroKernel.SubSystems.Conversion;
using DoctorHouse.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorHouse.Controllers.Resources
{
    public class AppointmentResource
    {
        public int Id { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string Status { get; set; }

        public string Description { get; set; }

        public KeyValuePairResource Customer { get; set; }

        public KeyValuePairResource Specialist { get; set; }

        public KeyValuePairResource Company { get; set; }
    }
}
