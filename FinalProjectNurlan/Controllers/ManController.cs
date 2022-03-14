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
    public class ManController : Controller
    {
        private readonly AppDbContext context;

        public ManController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Category> categories = context.Categories.Include(c=>c.Products).Include(c=>c.SubCategories).Where(c => c.GenderId == 1).ToList();
            return View(categories);
        }

        public IActionResult Shop(int id)
        {
            ShopVM shopVM = new ShopVM
            {
                Brands = context.Brands.Include(b => b.Products).ToList(),
                Category = context.Categories.Include(c => c.Products).Include(c => c.Gender).Include(c => c.SubCategories).ThenInclude(s => s.Products).FirstOrDefault(c => c.Id == id),
                Products = context.Products.Include(p=>p.Size).Include(p=>p.Color).Include(p => p.Category).Include(p => p.Brand).Include(p => p.SubCategory).Include(p => p.Gender).Where(p => p.CategoryId == id).ToList()
            };
          
            return View(shopVM);
        }
    }
}
