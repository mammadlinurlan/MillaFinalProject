using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Models
{
    public class ProductSizeColor
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public Product Product { get; set; }
        
        public int ColorId { get; set; }
        
        public Color Color { get; set; }
        
        public int SizeId { get; set; }
        public Size Size { get; set; }

        public string MainImage { get; set; }

        public List<ProductImage> ProductImages { get; set; }

        [NotMapped]
        public IFormFile MainImageFile { get; set; }

        [NotMapped]
        public List<IFormFile> ImageFiles { get; set; }


        [Required]
        public int TotalStock { get; set; }
        public int TotalSold { get; set; }

        [NotMapped]
        public List<Color> Colors { get; set; }

        [NotMapped]
        public List<Size> Sizes { get; set; }


    }
}
