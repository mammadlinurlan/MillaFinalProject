﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.ViewModels
{
    public class BasketVM
    {
        public List<BasketItemVM> BasketItems { get; set; }
        public double? TotalPrice { get; set; }
        public int Count { get; set; }
    }
}
