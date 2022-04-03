using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectNurlan.DAL;
using FinalProjectNurlan.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectNurlan.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin,Admin")]

    public class OrderController : Controller
    {
        private readonly AppDbContext context;
        private readonly UserManager<AppUser> _userManager;

        public OrderController(AppDbContext context,UserManager<AppUser> userManager)
        {
            this.context = context;
            _userManager = userManager;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.Status = context.Statuses.Include(s => s.Orders).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.TotalPage = Math.Ceiling((decimal)context.Orders.Count() / 5);
            List<Order> orders = context.Orders.OrderByDescending(p => p.Id).Include(b => b.OrderItems).ThenInclude(o=>o.ProductSizeColor).Include(p=>p.AppUser).Skip((page - 1) * 5).Take(5).ToList();
            return View(orders);
        }

        public IActionResult Edit(int id)
        {

            ViewBag.Status = context.Statuses.Include(s => s.Orders).ThenInclude(o=>o.OrderItems).ToList();

            Order order = context.Orders.Include(o=>o.Status).Include(o => o.OrderItems).ThenInclude(o => o.ProductSizeColor).ThenInclude(p => p.Size).Include(o => o.OrderItems).ThenInclude(o => o.ProductSizeColor).ThenInclude(p => p.Color).Include(o => o.AppUser).FirstOrDefault(o => o.Id == id);
            if (order==null)
            {
                return NotFound();
            }

            return View(order);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(Order order)
        {
            ViewBag.Status = context.Statuses.Include(s => s.Orders).ThenInclude(o=>o.OrderItems).ToList();

            Order exist = context.Orders.Include(o => o.Status).Include(o => o.OrderItems).ThenInclude(o => o.ProductSizeColor).ThenInclude(p => p.Size).Include(o => o.OrderItems).ThenInclude(o => o.ProductSizeColor).ThenInclude(p => p.Color).Include(o => o.AppUser).FirstOrDefault(o => o.Id == order.Id);



            //if (!ModelState.IsValid)
            //{
            //    return View(exist);
            //}


            exist.MessageToUser = order.MessageToUser;
            exist.StatusId = order.StatusId;


    if (exist.StatusId==2)
            {
                foreach (OrderItem item in exist.OrderItems)
                {
                    ProductSizeColor product = context.ProductSizeColors.FirstOrDefault(p => p.Id == item.ProductSizeColor.Id);
                    product.TotalSold += item.Count;
                    product.TotalStock -= item.Count;

                }
            }


            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
