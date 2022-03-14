using FinalProjectNurlan.DAL;
using FinalProjectNurlan.Extensions;
using FinalProjectNurlan.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext context;
        private readonly IWebHostEnvironment env;

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            this.context = context;
            this.env = env;
        }
        public IActionResult Index(int page=1)
        {
            ViewBag.CurrentPage = page;
            ViewBag.TotalPage = Math.Ceiling((decimal)context.Products.Count() / 10);
            List<Product> products = context.Products.Include(p=>p.Gender).Include(c => c.Category).Include(p=>p.SubCategory).Skip((page-1)*10).Take(10).ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            ViewBag.Genders = context.Genders.ToList();
            ViewBag.Categories = context.Categories.Include(c => c.Gender).Include(c => c.SubCategories).ToList();
            ViewBag.Subcategories = context.SubCategories.Include(s=>s.Category).ThenInclude(c=>c.Gender).ToList();
            ViewBag.Brands = context.Brands.Include(c => c.Products).ToList();
            ViewBag.Colors = context.Colors.ToList();
            ViewBag.Sizes = context.Sizes.ToList();
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Product product)
        {
            ViewBag.Genders = context.Genders.Include(g=>g.Categories).ThenInclude(c=>c.SubCategories).ToList();
            ViewBag.Categories = context.Categories.Include(c => c.Gender).Include(c => c.SubCategories).ToList();
            ViewBag.Subcategories = context.SubCategories.Include(s => s.Category).ThenInclude(c => c.Gender).ToList();
            ViewBag.Brands = context.Brands.Include(c => c.Products).ToList();
            ViewBag.Colors = context.Colors.ToList();
            ViewBag.Sizes = context.Sizes.ToList();
            product.ProductImages = new List<ProductImage>();

           
                if (!ModelState.IsValid)
                {
                    return View();
                }
                if (product.GenderId == 0)
                {
                    ModelState.AddModelError("GenderId", "Select a gender");
                    return View();
                }
                if (product.CategoryId == 0)
                {
                    ModelState.AddModelError("CategoryId", "Select a category");
                    return View();
                }
                if (product.SubCategoryId == 0)
                {
                    ModelState.AddModelError("SubCategoryId", "Select a subcategory!");
                    return View();
                }
            //if (product.GenderId != 15) 
            //{
            //    return Content(product.Category.Name);
            //}

            //|| product.GenderId != product.SubCategory.Category.GenderId)




            if (product.BrandId == 0)
                {
                    ModelState.AddModelError("BrandId", "Select a brand");
                    return View();
                }
                if (product.ColorId == 0)
                {
                    ModelState.AddModelError("ColorId", "Select a color");
                    return View();
                }
                if (product.SizeId == 0)
                {
                    ModelState.AddModelError("SizeId", "Select a size");
                    return View();
                }
            //if (product.Category.GenderId != product.SubCategory.Category.GenderId)
            //{
            //    ModelState.AddModelError("", $"You cant add {product.SubCategory.Category.Gender.Name} subcategory to {product.Category.Gender.Name} category!");
            //}
            if (product.MainImageFile == null)
                {
                    ModelState.AddModelError("MainImageFile", "Main image cannot be null!");
                    return View();
                }
                if (!product.MainImageFile.IsImage())
                {
                    ModelState.AddModelError("MainImageFile", "Choose only image file!");
                    return View();
                }
                if (!product.MainImageFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("MainImageFile", "Image size must be less than 2MB");
                    return View();
                }
                if (product.ImageFiles == null)
                {
                    ModelState.AddModelError("ImageFiles", "Other images cannot be null");
                    return View();
                }
                if (product.ImageFiles.Count < 3)
                {
                    ModelState.AddModelError("ImageFiles", "You cant select less than 3 images!");
                    return View();
                }
                if (product.ImageFiles.Count() > 3)
                {
                    ModelState.AddModelError("ImageFiles", "You can choose only 3 images");
                    return View();
                }
                foreach (var item in product.ImageFiles)
                {
                    if (!item.IsImage())
                    {
                        ModelState.AddModelError("ImageFiles", "Choose only image file!");
                        return View();
                    }
                    if (!item.IsSizeOkay(2))
                    {
                        ModelState.AddModelError("ImageFiles", "Image size must be less than 2MB");
                        return View();
                    }

                    ProductImage productImage = new ProductImage
                    {
                        Image = item.SaveImg(env.WebRootPath, "assets/images/products"),
                        Product = product
                    };
                    product.ProductImages.Add(productImage);
                }
                product.MainImage = product.MainImageFile.SaveImg(env.WebRootPath, "assets/images/products");

                product.TotalSold = 0;
                product.CreatedDate = DateTime.Now;
                context.Products.Add(product);
            context.SaveChanges();
            //return Content(product.Category.Name);
            return RedirectToAction(nameof(Index));











        }
    }
}
