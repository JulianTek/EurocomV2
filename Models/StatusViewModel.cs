﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EurocomV2.Models
{
    public class StatusViewModel
    {
        [Required]
        public int userID { get; set; }
    }
}
