using FinalProjectNurlan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.ViewModels
{
    public class BasketItemVM
    {
        public ProductSizeColor ProductSizeColor { get; set; }
        public double? Price { get; set; }
        public int Count { get; set; }
    }
}
