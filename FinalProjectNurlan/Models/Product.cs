using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 120)]
        public string Name { get; set; }

        [Required]

        public double Price { get; set; }

        [StringLength(maximumLength: 160)]

        public string Description { get; set; }

        public Gender Gender { get; set; }

        public int GenderId { get; set; }
        public short? Rating { get; set; } 

        public double? Discount { get; set; }

        [Required]
        [StringLength(maximumLength: 120)]
        public string Subtitle { get; set; }

        public int TotalSold { get; set; }

        [Required]
        public int TotalStock { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        public string MainImage { get; set; }

        public List<ProductImage> ProductImages { get; set; }

        [NotMapped]
        public IFormFile MainImageFile { get; set; }

        [NotMapped]
        public List<IFormFile> ImageFiles { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int SubCategoryId { get; set; }

        public SubCategory SubCategory { get; set; }
        

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int SizeId { get; set; }

        public Size Size { get; set; }

        public int ColorId { get; set; }
        public Color Color { get; set; }
    }
}
