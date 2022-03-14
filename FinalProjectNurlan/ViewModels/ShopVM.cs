using FinalProjectNurlan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.ViewModels
{
    public class ShopVM
    {
        public Category Category { get; set; }
        public List<Brand> Brands { get; set; }

        public List<Product> Products { get; set; }
    }
}
