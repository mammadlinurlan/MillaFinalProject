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
            List<Category> categories = context.Categories.Include(c => c.Products).Include(c => c.SubCategories).Where(c => c.GenderId == 2).ToList();
            return View(categories);
        }

        public IActionResult Shop(int id)
        {
            ShopVM shopVM = new ShopVM
            {
                Brands = context.Brands.Include(b=>b.Products).ToList(),
                Category = context.Categories.Include(c => c.Products).Include(c => c.Gender).Include(c => c.SubCategories).ThenInclude(s => s.Products).FirstOrDefault(c => c.Id == id)
            };
          
            return View(shopVM);
        }
    }
}
