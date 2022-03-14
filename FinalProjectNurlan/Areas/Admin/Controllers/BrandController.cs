using FinalProjectNurlan.DAL;
using FinalProjectNurlan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly AppDbContext context;

        public BrandController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index(int page=1)
        {
            ViewBag.CurrentPage = page;
            ViewBag.TotalPage = Math.Ceiling((decimal)context.Brands.Count() / 5);
            List<Brand> brands = context.Brands.Include(b=>b.Products).Skip((page-1)*5).Take(5).ToList();
            return View(brands);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Brand brand)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            context.Brands.Add(brand);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            Brand brand = context.Brands.Include(b => b.Products).FirstOrDefault(b => b.Id == id);
            if (brand==null)
            {
                return NotFound();
            }
            return View(brand);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(Brand brand)
        {
            Brand existed = context.Brands.Include(b => b.Products).FirstOrDefault(b => b.Id == brand.Id);
            if (existed == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return View(existed);
            }
            existed.Name = brand.Name;
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Brand brand = context.Brands.Include(b => b.Products).FirstOrDefault(b => b.Id == id);
            if (brand == null)
            {
                return NotFound();
            }
            context.Brands.Remove(brand);
            context.SaveChanges();
            return Json(new { status = 200 });
        }
    }
}
