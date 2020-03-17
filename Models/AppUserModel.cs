using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EurocomV2.Models
{
    public class AppUserModel : IdentityUser<int>
    {
        private string _FirstName;
        private string _LastName;

        public string FirstName
        {
            get { return this._FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return this._LastName; }
            set { _LastName = value; }
        }
    }
}
