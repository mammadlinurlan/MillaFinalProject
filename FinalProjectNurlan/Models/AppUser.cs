﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Models
{
    public class AppUser:IdentityUser
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }

        public bool IsAdmin { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Zip { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public List<BasketItem> BasketItems { get; set; }
    }
}
