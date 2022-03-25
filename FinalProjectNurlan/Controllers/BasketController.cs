using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectNurlan.DAL;
using FinalProjectNurlan.Models;
using FinalProjectNurlan.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace FinalProjectNurlan.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext context;
        private readonly UserManager<AppUser> userManager;

        public BasketController(AppDbContext context, UserManager<AppUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public async Task<IActionResult> SetBasket(int sizeId, int colorId, int productId, int quantity)
        {
            ProductSizeColor product = await context.ProductSizeColors.Include(p => p.Product).FirstOrDefaultAsync(p => p.SizeId == sizeId && p.ColorId == colorId && p.ProductId == productId);


            //&& User.IsInRole("Member")

            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await userManager.FindByNameAsync(User.Identity.Name);
                BasketItem basketItem = context.BasketItems.FirstOrDefault(i => i.ProductSizeColorId == product.Id && i.AppUserId == user.Id);
                if (basketItem == null)
                {
                    basketItem = new BasketItem
                    {
                        ProductSizeColorId = product.Id,
                        AppUserId = user.Id,
                        Count = quantity

                    };
                    context.BasketItems.Add(basketItem);
                }
                else
                {
                    basketItem.Count += quantity;
                }
                context.SaveChanges();

            }
            else
            {
                string basket = HttpContext.Request.Cookies["Basket"];

                if (basket == null)
                {

                    List<BasketCookieItemVM> basketCookieItems = new List<BasketCookieItemVM>();
                    basketCookieItems.Add(new BasketCookieItemVM
                    {
                        Count = quantity,
                        Id = product.Id
                    });

                    string basketStr = JsonConvert.SerializeObject(basketCookieItems);
                    HttpContext.Response.Cookies.Append("Basket", basketStr);
                }
                else
                {
                    List<BasketCookieItemVM> basketCookieItems = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);
                    BasketCookieItemVM cookieItem = basketCookieItems.FirstOrDefault(p => p.Id == product.Id);
                    if (cookieItem == null)
                    {
                        cookieItem = new BasketCookieItemVM
                        {
                            Id = product.Id,
                            Count = quantity
                        };
                        basketCookieItems.Add(cookieItem);
                    }
                    else
                    {
                        cookieItem.Count += quantity;

                    }
                    string basketStr = JsonConvert.SerializeObject(basketCookieItems);
                    HttpContext.Response.Cookies.Append("Basket", basketStr);
                }
            }
            return PartialView("_basketProductPartialView");
        }

        public IActionResult GetPartial()
        {
            return PartialView("_basketProductPartialView");
        }

        public async Task<IActionResult> ForTotalCount()
        {

            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await userManager.FindByNameAsync(User.Identity.Name);
                List<BasketItem> item = context.BasketItems.Where(b => b.AppUserId == user.Id).ToList();
                return Json(item.Count);
            }
            else
            {
                string basket = HttpContext.Request.Cookies["Basket"];
                List<BasketCookieItemVM> basketCookieItems = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);
                return Json(basketCookieItems.Count);
            }
            //return Content("okay");
        }

        public async Task<IActionResult> GetTotalPrice()
        {
            BasketVM basketVM = new BasketVM
            {
                TotalPrice = 0
            };


            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await userManager.FindByNameAsync(User.Identity.Name);
                List<BasketItem> item = context.BasketItems.Where(b => b.AppUserId == user.Id).ToList();
                foreach (var i in item)
                {
                    basketVM.TotalPrice += i.Count * i.ProductSizeColor.Product.Discount == null ? i.ProductSizeColor.Product.Price : i.ProductSizeColor.Product.Price - (i.ProductSizeColor.Product.Price * i.ProductSizeColor.Product.Discount / 100);
                }
                return Json(basketVM.TotalPrice);
            }
            //else
            //{
            //string basket = HttpContext.Request.Cookies["Basket"];
            //List<BasketCookieItemVM> basketCookieItems = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);
            //foreach (var i in basketCookieItems)
            //{
            //    basketVM.TotalPrice += i.Count * i. i..Product.Discount == null ? i.ProductSizeColor.Product.Price : i.ProductSizeColor.Product.Price - (i.ProductSizeColor.Product.Price * i.ProductSizeColor.Product.Discount / 100);
            //}
            //    return Json(basketCookieItems.Count);
            //}
            return Content("okay");
        }


        public async Task<IActionResult> Remove()
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await userManager.FindByNameAsync(User.Identity.Name);
                List<BasketItem> item = context.BasketItems.Where(b => b.AppUserId == user.Id).ToList();
                user.BasketItems.RemoveAll(p => item.Any(i => i.Id == p.Id));
                context.SaveChanges();
            }

            return Content("okay");
        }
    }
}
