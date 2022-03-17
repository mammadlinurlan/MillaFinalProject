using FinalProjectNurlan.DAL;
using FinalProjectNurlan.Extensions;
using FinalProjectNurlan.Models;
using FinalProjectNurlan.ViewModels;
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
        public IActionResult Index(int page = 1)
        {
            ViewBag.CurrentPage = page;
            ViewBag.TotalPage = Math.Ceiling((decimal)context.ProductSizeColors.Count() / 10);
            List<ProductSizeColor> products = context.ProductSizeColors.Include(p => p.Product).ThenInclude(p => p.SubCategory).ThenInclude(p => p.Category).ThenInclude(c => c.Gender).Include(c => c.Color).Include(p => p.Size).Skip((page - 1) * 10).Take(10).ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            ViewBag.Genders = context.Genders.ToList();
            ViewBag.Categories = context.Categories.Include(c => c.Gender).Include(c => c.SubCategories).ToList();
            ViewBag.Subcategories = context.SubCategories.Include(s => s.Category).ThenInclude(c => c.Gender).ToList();
            ViewBag.Brands = context.Brands.Include(c => c.Products).ToList();
            ViewBag.Colors = context.Colors.ToList();
            ViewBag.Sizes = context.Sizes.ToList();
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(ProdCreateVM prodVM)
        {
            ViewBag.Genders = context.Genders.Include(g => g.Categories).ThenInclude(c => c.SubCategories).ToList();
            ViewBag.Categories = context.Categories.Include(c => c.Gender).Include(c => c.SubCategories).ToList();
            ViewBag.Subcategories = context.SubCategories.Include(s => s.Category).ThenInclude(c => c.Gender).ToList();
            ViewBag.Brands = context.Brands.Include(c => c.Products).ToList();
            ViewBag.Colors = context.Colors.Include(s => s.ProductSizeColors).ToList();
            ViewBag.Sizes = context.Sizes.Include(s => s.ProductSizeColors).ToList();
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (prodVM.Product.GenderId == 0)
            {
                ModelState.AddModelError("", "Select a gender");
                return View();
            }
            if (prodVM.Product.CategoryId == 0)
            {
                ModelState.AddModelError("", "Select a category");
                return View();
            }
            if (prodVM.Product.SubCategoryId == 0)
            {
                ModelState.AddModelError("", "Select a subcategory!");
                return View();
            }
            if (prodVM.Product.BrandId == 0)
            {
                ModelState.AddModelError("", "Select a brand");
                return View();
            }
            if (prodVM.ProductSizeColor.ColorId == 0)
            {
                ModelState.AddModelError("", "Select a color");
                return View();
            }
            if (prodVM.ProductSizeColor.SizeId == 0)
            {
                ModelState.AddModelError("", "Select a Size");
                return View();
            }
            if (prodVM.ProductSizeColor.MainImageFile == null)
            {
                ModelState.AddModelError("", "Select a main image!");
                return View();
            }
            if (!prodVM.ProductSizeColor.MainImageFile.IsImage())
            {
                ModelState.AddModelError("", "Choose only image file!");
                return View();
            }
            if (!prodVM.ProductSizeColor.MainImageFile.IsSizeOkay(2))
            {
                ModelState.AddModelError("", "Image size must be less than 2MB");
                return View();
            }
            if (prodVM.ProductSizeColor.ImageFiles == null)
            {
                ModelState.AddModelError("", "Other images cannot be null");
                return View();
            }
            if (prodVM.ProductSizeColor.ImageFiles.Count < 3)
            {
                ModelState.AddModelError("", "You cant select less than 3 images!");
                return View();
            }
            if (prodVM.ProductSizeColor.ImageFiles.Count() > 3)
            {
                ModelState.AddModelError("", "You can choose only 3 images");
                return View();
            }
            ProductSizeColor productSizeColor = new ProductSizeColor();

            productSizeColor.ProductImages = new List<ProductImage>();

            prodVM.Product.ProductColors = new List<ProductColor>();

            //prodVM.Product.Clrs = new List<int>();

            foreach (var item in prodVM.ProductSizeColor.ImageFiles)
            {
                if (!item.IsImage())
                {
                    ModelState.AddModelError("", "Choose only image file!");
                    return View();
                }
                if (!item.IsSizeOkay(2))
                {
                    ModelState.AddModelError("", "Image size must be less than 2MB");
                    return View();
                }

                ProductImage productImage = new ProductImage
                {
                    Image = item.SaveImg(env.WebRootPath, "assets/images/products"),
                    ProductSizeColor = productSizeColor
                };
                productSizeColor.ProductImages.Add(productImage);
            }

            productSizeColor.SizeId = prodVM.ProductSizeColor.SizeId;
            productSizeColor.ColorId = prodVM.ProductSizeColor.ColorId;
            productSizeColor.TotalStock = prodVM.ProductSizeColor.TotalStock;
            productSizeColor.TotalSold = 0;
            productSizeColor.MainImage = prodVM.ProductSizeColor.MainImageFile.SaveImg(env.WebRootPath, "assets/images/products");

            productSizeColor.ProductId = prodVM.Product.Id;
            prodVM.Product.ProductSizeColors = new List<ProductSizeColor>();

            prodVM.Product.ProductSizeColors.Add(productSizeColor);
            prodVM.Product.CreatedDate = DateTime.Now;

            ProductColor productColor = new ProductColor
            {
                ColorId = prodVM.ProductSizeColor.ColorId,
                ProductId = prodVM.Product.Id
            };

            prodVM.Product.ProductColors.Add(productColor);
            //prodVM.Product.Clrs.Add(productSizeColor.ColorId);
            context.Products.Add(prodVM.Product);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult AddColorSize(int id)
        {
            ViewBag.Genders = context.Genders.Include(g => g.Categories).ThenInclude(c => c.SubCategories).ToList();
            ViewBag.Categories = context.Categories.Include(c => c.Gender).Include(c => c.SubCategories).ToList();
            ViewBag.Subcategories = context.SubCategories.Include(s => s.Category).ThenInclude(c => c.Gender).ToList();
            ViewBag.Brands = context.Brands.Include(c => c.Products).ToList();
            ViewBag.Colors = context.Colors.Include(s => s.ProductSizeColors).ToList();
            ViewBag.Sizes = context.Sizes.Include(s => s.ProductSizeColors).ToList();
            //Product prod = context.Products.Include(p => p.ProductSizeColors).FirstOrDefault(p => p.Id == id);

            ProdCreateVM prodCreateVM = new ProdCreateVM
            {

                Product = context.Products.Include(p=>p.ProductColors).Include(p => p.ProductSizeColors).FirstOrDefault(p => p.Id == id),
                ProductSizeColor = new ProductSizeColor()

            };
            //prodCreateVM.ProductSizeColor.ProductId = 33;

            return View(prodCreateVM);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult AddColorSize(ProdCreateVM prodVM)
        {
            ViewBag.Genders = context.Genders.Include(g => g.Categories).ThenInclude(c => c.SubCategories).ToList();
            ViewBag.Categories = context.Categories.Include(c => c.Gender).Include(c => c.SubCategories).ToList();
            ViewBag.Subcategories = context.SubCategories.Include(s => s.Category).ThenInclude(c => c.Gender).ToList();
            ViewBag.Brands = context.Brands.Include(c => c.Products).ToList();
            ViewBag.Colors = context.Colors.Include(s => s.ProductSizeColors).ToList();
            ViewBag.Sizes = context.Sizes.Include(s => s.ProductSizeColors).ToList();
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            Product existed = context.Products.Include(p=>p.ProductSizeColors).Include(p=>p.ProductColors).FirstOrDefault(p => p.Id == prodVM.Product.Id);

            


            if (prodVM.ProductSizeColor.SizeId == 0)
            {
                ModelState.AddModelError("", "Select a Size");
                return View();
            }
            if (prodVM.ProductSizeColor.ColorId == 0)
            {
                ModelState.AddModelError("", "Select a color");
                return View();
            }
            if (prodVM.ProductSizeColor.MainImageFile == null)
            {
                ModelState.AddModelError("", "Select a main image!");
                return View();
            }
            if (!prodVM.ProductSizeColor.MainImageFile.IsImage())
            {
                ModelState.AddModelError("", "Choose only image file!");
                return View();
            }
            if (!prodVM.ProductSizeColor.MainImageFile.IsSizeOkay(2))
            {
                ModelState.AddModelError("", "Image size must be less than 2MB");
                return View();
            }
            if (prodVM.ProductSizeColor.ImageFiles == null)
            {
                ModelState.AddModelError("", "Other images cannot be null");
                return View();
            }
            if (prodVM.ProductSizeColor.ImageFiles.Count < 3)
            {
                ModelState.AddModelError("", "You cant select less than 3 images!");
                return View();
            }
            if (prodVM.ProductSizeColor.ImageFiles.Count() > 3)
            {
                ModelState.AddModelError("", "You can choose only 3 images");
                return View();
            }

            ProductSizeColor productSizeColor = new ProductSizeColor();

            productSizeColor.ProductImages = new List<ProductImage>();

            foreach (var item in prodVM.ProductSizeColor.ImageFiles)
            {
                if (!item.IsImage())
                {
                    ModelState.AddModelError("", "Choose only image file!");
                    return View();
                }
                if (!item.IsSizeOkay(2))
                {
                    ModelState.AddModelError("", "Image size must be less than 2MB");
                    return View();
                }

                ProductImage productImage = new ProductImage
                {
                    Image = item.SaveImg(env.WebRootPath, "assets/images/products"),
                    ProductSizeColor = productSizeColor
                };
                productSizeColor.ProductImages.Add(productImage);
            }


            productSizeColor.SizeId = prodVM.ProductSizeColor.SizeId;
            productSizeColor.ColorId = prodVM.ProductSizeColor.ColorId;
            productSizeColor.TotalStock = prodVM.ProductSizeColor.TotalStock;
            productSizeColor.TotalSold = 0;
            productSizeColor.MainImage = prodVM.ProductSizeColor.MainImageFile.SaveImg(env.WebRootPath, "assets/images/products");

            productSizeColor.Product = existed;

            productSizeColor.Product.Id = existed.Id;

            if (!existed.ProductColors.Any(p=>p.ColorId == prodVM.ProductSizeColor.ColorId))
            {
                ProductColor productColor1 = new ProductColor();


                productColor1.ProductId = existed.Id;
                productColor1.ColorId = prodVM.ProductSizeColor.ColorId;

                existed.ProductColors.Add(productColor1);

            }




            if (existed.ProductSizeColors.Any(p=>p.ColorId == prodVM.ProductSizeColor.ColorId && p.SizeId == prodVM.ProductSizeColor.SizeId))
            {

                Color color = existed.ProductSizeColors.FirstOrDefault(p => p.ColorId == prodVM.ProductSizeColor.ColorId).Color;
                Size size = existed.ProductSizeColors.FirstOrDefault(p => p.SizeId == prodVM.ProductSizeColor.SizeId).Size;
                string existColor = color.Name;

                ModelState.AddModelError("", $"{existed.Name} product already has option with COLOR : {existColor} SIZE : {size.Name} ");
                return View();
            }


            existed.ProductSizeColors.Add(productSizeColor);
            //existed.Clrs.Add(productSizeColor.ColorId);
            //existed.CreatedDate = DateTime.Now;
            //context.Products.Add(prodVM.Product);

            //return Json(existed.ProductSizeColors.FirstOrDefault().ColorId);

            context.SaveChanges();


            return RedirectToAction(nameof(Index));



            //return Json(existed.Name);
        }

        public IActionResult Test()
        {
            Product pro = context.Products.Include(p => p.Brand).Include(p=>p.ProductColors).Include(p => p.ProductSizeColors).FirstOrDefault(p => p.Id == 1024);
           
            return Json(pro.ProductColors.Where(p=>p.ColorId != 4).Count());
        }

        public IActionResult Delete(int id)
        {
            ProductSizeColor product = context.ProductSizeColors.Include(p=>p.Color).Include(p=>p.Product).FirstOrDefault(p => p.Id == id);
            if (product==null)
            {
                return NotFound();
            }
            Product pro = context.Products.Include(p=>p.ProductSizeColors).Include(p=>p.ProductColors).FirstOrDefault(p => p.Id == product.ProductId);
            if (pro.ProductSizeColors.Where(p=>p.ColorId == product.ColorId).Count() == 1)
            {
                ProductColor productColor = context.ProductColors.FirstOrDefault(p => p.ProductId == pro.Id && p.ColorId == product.ColorId);

                context.ProductColors.Remove(productColor);
            }

            context.ProductSizeColors.Remove(product);
           
            context.SaveChanges();
            return Json(new { status = 200 });
            

        }
    }
}
