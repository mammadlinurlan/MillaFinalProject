using FinalProjectNurlan.DAL;
using FinalProjectNurlan.Models;
using FinalProjectNurlan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext context;

        public HomeController(AppDbContext context)
        {
            this.context = context;
        }
        
        public IActionResult Index()
        {
            HomeVM home = new HomeVM
            {
                Sliders = context.Sliders.ToList(),
                Brands = context.Brands.Include(b => b.Products).ToList(),
               
   
                ProductColors = context.ProductColors.Include(p => p.Product).ThenInclude(p => p.Comments).Include(p=>p.Product).ThenInclude(p=>p.Category).ThenInclude(c=>c.Gender).Include(p=>p.Product).ThenInclude(p=>p.ProductSizeColors).OrderBy(pc=>pc.Product.Name).ToList(),
                ProductColors2 = context.ProductColors.Include(p => p.Product).ThenInclude(p => p.Comments).ToList(),
                Product = context.Products.Include(p=>p.ProductSizeColors).Include(p=>p.Gender).FirstOrDefault(p=>p.DealOfTheDay==true),
                Settings = context.Settings.FirstOrDefault()
                
            };

            return View(home);
        }

        public IActionResult Subscribe(string email)
        {
            Subscriber subscriber = context.Subscribers.FirstOrDefault(c => c.Email.Trim().ToLower() == email.Trim().ToLower());
            if (subscriber==null)
            {

                Subscriber news = new Subscriber
                {
                    Email = email
                };
                context.Subscribers.Add(news);
                context.SaveChanges();
                return Json(new { status=200});

            }
            else
            {
                return Json(new { status = 500 });

            }



        }
      
    }
}
