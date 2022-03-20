using FinalProjectNurlan.DAL;
using FinalProjectNurlan.Models;
using FinalProjectNurlan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Controllers
{
    public class WomanController : Controller
    {
        private readonly AppDbContext context;

        public WomanController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Category> categories = context.Categories.Include(c => c.Products).ThenInclude(p => p.ProductSizeColors).Include(c => c.SubCategories).Where(c => c.GenderId == 2).ToList();

            return View(categories);
        }

        public IActionResult Shop(int id)
        {
            if (context.Categories.FirstOrDefault(c => c.Id == id) == null)
            {
                return NotFound();
            }
            if (context.Categories.FirstOrDefault(c => c.Id == id).GenderId != 2)
            {
                return NotFound();
            }



            //List<ProductSizeColor> prod = context.ProductSizeColors.GroupBy(p=>p.ProductId).ToList();

            ShopVM shopVM = new ShopVM
            {
                Brands = context.Brands.Include(b => b.Products).ToList(),
                Category = context.Categories.Include(c => c.Products).Include(c => c.Gender).Include(c => c.SubCategories).ThenInclude(s => s.Products).FirstOrDefault(c => c.Id == id),
                Products = context.Products.Include(p => p.ProductColors).Include(p => p.Category).Include(p => p.ProductSizeColors).ThenInclude(p => p.Color).Include(p => p.ProductSizeColors).ThenInclude(p => p.Size).Include(p => p.Brand).Include(p => p.SubCategory).Include(p => p.Gender).Where(p => p.CategoryId == id && p.ProductSizeColors.Count > 0).ToList(),
                ProductSizeColors = context.ProductSizeColors.Include(p => p.Color).Include(p => p.Size).Include(p => p.Product).ThenInclude(p => p.SubCategory).Include(p => p.ProductImages).Where(p => p.Product.CategoryId == id).ToList(),
                ProductColors = context.ProductColors.Where(p => p.Product.CategoryId == id && p.Product.GenderId == 2).ToList()

            };


            ViewBag.Colors = context.Colors.ToList();
            return View(shopVM);
        }

        public IActionResult Details(int id)
        {
            if (context.ProductSizeColors.FirstOrDefault(p => p.Id == id) == null)
            {
                return NotFound();
            }
         
            ProductSizeColor product = context.ProductSizeColors.Include(p => p.Color).Include(p => p.Size).Include(p => p.ProductImages).Include(p => p.Product).ThenInclude(p => p.SubCategory).ThenInclude(s => s.Category).Include(p => p.Product).ThenInclude(p => p.Brand).Include(p => p.Product).ThenInclude(p => p.Gender).Include(p => p.Product).ThenInclude(p => p.ProductSizeColors).ThenInclude(p => p.Size).FirstOrDefault(p => p.Id == id);
            if (product.Product.GenderId != 2)
            {
                return NotFound();
            }

            ProductSizeColor forcolor = context.ProductSizeColors.Include(p => p.Color).Include(p => p.Size).Include(p => p.ProductImages).Include(p => p.Product).ThenInclude(p => p.SubCategory).ThenInclude(s => s.Category).Include(p => p.Product).ThenInclude(p => p.Brand).Include(p => p.Product).ThenInclude(p => p.Gender).Include(p => p.Product).ThenInclude(p => p.ProductSizeColors).ThenInclude(p => p.Size).Include(p => p.Product).ThenInclude(p => p.ProductColors).FirstOrDefault(p => p.Id == id);

            ShopVM shopVM = new ShopVM
            {
                ProductSizeColor = context.ProductSizeColors.Include(p => p.Color).Include(p => p.Size).Include(p => p.ProductImages).Include(p => p.Product).ThenInclude(p => p.SubCategory).ThenInclude(s => s.Category).Include(p => p.Product).ThenInclude(p => p.Brand).Include(p => p.Product).ThenInclude(p => p.Gender).Include(p => p.Product).ThenInclude(p => p.ProductSizeColors).ThenInclude(p => p.Size).Include(p => p.Product).ThenInclude(p => p.ProductColors).FirstOrDefault(p => p.Id == id),
                Products = context.Products.Include(p => p.Brand).Include(p => p.Category).Include(p => p.SubCategory).Include(p => p.ProductSizeColors).ThenInclude(p => p.ProductImages).Include(p => p.ProductColors).Include(p => p.ProductSizeColors).ThenInclude(p => p.Size).Include(p => p.ProductSizeColors).ThenInclude(p => p.Color).Where(p => p.CategoryId == product.Product.CategoryId && p.Id != product.ProductId).ToList(),
                Product = context.Products.Include(p => p.Brand).Include(p => p.Category).Include(p => p.SubCategory).Include(p => p.ProductSizeColors).ThenInclude(p => p.ProductImages).Include(p => p.ProductColors).Include(p => p.ProductSizeColors).ThenInclude(p => p.Size).Include(p => p.ProductSizeColors).ThenInclude(p => p.Color).FirstOrDefault(p => p.Id == id),
                ProductColors = context.ProductColors.Where(p => p.Product.CategoryId == product.Product.CategoryId && p.ProductId != forcolor.ProductId).ToList()

            };



            return View(shopVM);
        }

        public IActionResult ChangeColor(int id)
        {
            if (context.ProductSizeColors.FirstOrDefault(p => p.Id == id) == null)
            {
                return NotFound();
            }
            ProductSizeColor product = context.ProductSizeColors.Include(p => p.Color).Include(p => p.Size).Include(p => p.ProductImages).Include(p => p.Product).ThenInclude(p => p.SubCategory).ThenInclude(s => s.Category).Include(p => p.Product).ThenInclude(p => p.Brand).Include(p => p.Product).ThenInclude(p => p.Gender).Include(p => p.Product).ThenInclude(p => p.ProductSizeColors).ThenInclude(p => p.Size).FirstOrDefault(p => p.Id == id);

            ProductSizeColor forcolor = context.ProductSizeColors.Include(p => p.Color).Include(p => p.Size).Include(p => p.ProductImages).Include(p => p.Product).ThenInclude(p => p.SubCategory).ThenInclude(s => s.Category).Include(p => p.Product).ThenInclude(p => p.Brand).Include(p => p.Product).ThenInclude(p => p.Gender).Include(p => p.Product).ThenInclude(p => p.ProductSizeColors).ThenInclude(p => p.Size).Include(p => p.Product).ThenInclude(p => p.ProductColors).FirstOrDefault(p => p.Id == id);

            ShopVM shopVM = new ShopVM
            {
                ProductSizeColor = context.ProductSizeColors.Include(p => p.Color).Include(p => p.Size).Include(p => p.ProductImages).Include(p => p.Product).ThenInclude(p => p.SubCategory).ThenInclude(s => s.Category).Include(p => p.Product).ThenInclude(p => p.Brand).Include(p => p.Product).ThenInclude(p => p.Gender).Include(p => p.Product).ThenInclude(p => p.ProductSizeColors).ThenInclude(p => p.Size).Include(p => p.Product).ThenInclude(p => p.ProductColors).FirstOrDefault(p => p.Id == id),
                Products = context.Products.Include(p => p.Brand).Include(p => p.Category).Include(p => p.SubCategory).Include(p => p.ProductSizeColors).ThenInclude(p => p.ProductImages).Include(p => p.ProductColors).Include(p => p.ProductSizeColors).ThenInclude(p => p.Size).Include(p => p.ProductSizeColors).ThenInclude(p => p.Color).Where(p => p.CategoryId == product.Product.CategoryId && p.Id != product.ProductId).ToList(),
                Product = context.Products.Include(p => p.Brand).Include(p => p.Category).Include(p => p.SubCategory).Include(p => p.ProductSizeColors).ThenInclude(p => p.ProductImages).Include(p => p.ProductColors).Include(p => p.ProductSizeColors).ThenInclude(p => p.Size).Include(p => p.ProductSizeColors).ThenInclude(p => p.Color).FirstOrDefault(p => p.Id == id),
                ProductColors = context.ProductColors.Where(p => p.Product.CategoryId == product.Product.CategoryId && p.ProductId != forcolor.ProductId).ToList()

            };

            return PartialView("_productDetailPartialView", shopVM);

        }
    }
}
