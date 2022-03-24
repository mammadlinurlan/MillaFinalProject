using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.ViewModels
{
    public class UserEditVM
    {
        public string Username { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Fullname { get; set; }

        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        public bool TermsAndConditions { get; set; }
        public string Country { get; set; }

        public string City { get; set; }

        public string Zip { get; set; }

        public string Address { get; set; }


        public string Phone { get; set; }
    }
}
