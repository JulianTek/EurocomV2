﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace EurocomV2.Models
{
    public class PatientViewModel : UserViewModel
    {
        public StatusGraphViewModel statusViewModel { get; set; }
        public string DateOfBirth { get; set; }
        public string securityCode { get; set; }
    }
}
