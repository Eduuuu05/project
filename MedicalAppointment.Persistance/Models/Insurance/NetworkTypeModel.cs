﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointment.Persistance.Models.Insurance
{
    public class NetworkTypeModel
    {
        public int NetworkTypeId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
