using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EurocomV2.Models
{
    public class LoginViewModel
    {
        private string _Email;
        private string _Password;
        private bool _Remember;

        [Required]
        [EmailAddress]
        public string Email
        {
            get { return this._Email; }
            set { _Email = value; }
        }

        [Required]
        [DataType(DataType.Password)]
        public string Password
        {
            get { return this._Password; }
            set { _Password = value; }
        }

        [Display(Name = "Remember Me")]
        public bool Remember
        {
            get { return this._Remember; }
            set { _Remember = value; }
        }
    }
}
