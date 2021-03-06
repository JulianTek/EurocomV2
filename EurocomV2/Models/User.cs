﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EurocomV2.Models
{
    public class User : IdentityUser
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string Lastname { get; set; }

        [NotMapped]
        [Display(Name = "Username")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Username required")]
        public string UserName { get; set; }

        [NotMapped]
        public string Email { get; set; }

        [NotMapped]
        [Required]
        [DataType(DataType.Password, ErrorMessage = "Incorrent or Missing password")]
        public string Password { get; set; }

        [NotMapped]
        public string PhoneNumber { get; set; }

        [NotMapped]
        public bool Agreement { get; set; }

        [NotMapped]
        public string Role { get; set; }
    }
}
