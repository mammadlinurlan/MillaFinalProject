using FinalProjectNurlan.DAL;
using FinalProjectNurlan.Models;
using FinalProjectNurlan.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<AppUser> _userManager;

        public OrderController(AppDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager)
        {
            _context = context;
            _httpContext = httpContextAccessor;
            _userManager = userManager;
        }


        [Authorize]
        public async Task<IActionResult> Checkout()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            CheckoutVM checkout = new CheckoutVM
            {
                Address = user.Address,
                City = user.City,
                Country = user.Country,
                Email = user.Email,
                Firstname = user.Firstname,
                Phone = user.Phone,
                Surname = user.Surname,
                Zip = user.Zip,
                 BasketItems = _context.BasketItems.Include(p=>p.ProductSizeColor).ThenInclude(p=>p.Product).ThenInclude(p=>p.Gender).Include(p=>p.ProductSizeColor).ThenInclude(p=>p.Size).Include(p=>p.ProductSizeColor).ThenInclude(p=>p.Color).Where(b=>b.AppUserId == user.Id).ToList()
            };

            return View(checkout);
        }

    }
}
