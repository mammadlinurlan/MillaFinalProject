using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Models
{
    public class ProductImage
    {
        public int Id { get; set; }

        public string Image { get; set; }
        public int ProductSizeColorId { get; set; }
        public ProductSizeColor ProductSizeColor { get; set; }

    }
}
