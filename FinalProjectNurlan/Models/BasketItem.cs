﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Models
{
    public class BasketItem
    {
        public int Id { get; set; }

        public int ProductSizeColorId { get; set; }
        public ProductSizeColor ProductSizeColor { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int Count { get; set; }
    }
}
