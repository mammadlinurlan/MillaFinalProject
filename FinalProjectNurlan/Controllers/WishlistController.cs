using FinalProjectNurlan.DAL;
using FinalProjectNurlan.Models;
using FinalProjectNurlan.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Controllers
{
    public class WishlistController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<AppUser> _userManager;

        public WishlistController(AppDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager)
        {
            _context = context;
            _httpContext = httpContextAccessor;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            string wishlists = HttpContext.Request.Cookies["Wishlists"];

            if (User.Identity.IsAuthenticated && User.IsInRole("Member"))
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                WishlistVM wishlistVM = new WishlistVM
                {
                    WishlistItems = _context.WishlistItems.Include(w=>w.ProductColor).ThenInclude(c=>c.Product).ThenInclude(p=>p.ProductSizeColors).Include(p=>p.ProductColor).ThenInclude(p=>p.Product).ThenInclude(p=>p.Gender).Where(c=>c.AppUserId == user.Id).ToList()
                };
                return View(wishlistVM);

            }
            //else
            //{
            //    List<WishlistCookieItemVM> wishlistCookieItems = JsonConvert.DeserializeObject<List<WishlistCookieItemVM>>(wishlists);

            //}
            return View();

        }

        public async Task<IActionResult> Test()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            List<WishlistItem> list = _context.WishlistItems.Where(w => w.AppUserId == user.Id).ToList();
            return Json(list.Count);


        }

        public async Task<IActionResult> SetWishlist(int id)
        {

            ProductColor product = _context.ProductColors.FirstOrDefault(p => p.Id == id);

          
          
            if (User.Identity.IsAuthenticated  && User.IsInRole("Member"))
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                WishlistItem wishlistItem = _context.WishlistItems.FirstOrDefault(i => i.ProductColorId == product.Id && i.AppUserId == user.Id);
                if (wishlistItem == null)
                {
                    wishlistItem = new WishlistItem
                    {
                        ProductColorId = product.Id,
                        AppUserId = user.Id,

                    };
                    _context.WishlistItems.Add(wishlistItem);


                
                }
               
                _context.SaveChanges();




            }
            else
            {
                string wishlists = HttpContext.Request.Cookies["Wishlists"];

                if (wishlists == null)
                {

                    List<WishlistCookieItemVM> wishlistCookieItems = new List<WishlistCookieItemVM>();
                    wishlistCookieItems.Add(new WishlistCookieItemVM
                    {
                       
                        Id = product.Id
                    });

                    string wishlistStr = JsonConvert.SerializeObject(wishlistCookieItems);
                    HttpContext.Response.Cookies.Append("Wishlists", wishlistStr);
                }
                else
                {
                    List<WishlistCookieItemVM> wishlistCookieItems = JsonConvert.DeserializeObject<List<WishlistCookieItemVM>>(wishlists);
                    WishlistCookieItemVM cookieItem = wishlistCookieItems.FirstOrDefault(p => p.Id == product.Id);
                    if (cookieItem == null)
                    {
                        cookieItem = new WishlistCookieItemVM
                        {
                            Id = product.Id
                        };
                        wishlistCookieItems.Add(cookieItem);
                    }
                   
                    string wishlistStr = JsonConvert.SerializeObject(wishlistCookieItems);
                    HttpContext.Response.Cookies.Append("Wishlists", wishlistStr);
                }



            }



            return RedirectToAction("Index", "Home");
        }

    }
}
