using FinalProjectNurlan.DAL;
using FinalProjectNurlan.Models;
using FinalProjectNurlan.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Controllers
{
    public class CommentController : Controller
    {
        private readonly AppDbContext context;
        private readonly UserManager<AppUser> userManager;

        public CommentController(AppDbContext context, UserManager<AppUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }


        public async Task<IActionResult> AddComment(string Subject,string Message,int ProductId,short Star)
        {

            AppUser user = await userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (user==null)
            {
                return NotFound();
            }
            //if (Subject == null && Message==null)
            //{
            //    return Content("bothnull");
            //}
            //if (Subject==null)
            //{
            //    return Content("nullsubject");
            //}
            //if (Message == null)
            //{
            //    return Content("nullmessage");
            //}

            Product product = context.Products.FirstOrDefault(p => p.Id == ProductId);

            if (product.Comments == null)
            {
                product.Rating = 0;
            }

            if (product.Rating == null)
            {
                product.Rating = 0;

            }
            product.Rating += Star;
            if (!context.Products.Any(p=>p.Id==ProductId))
            {
                return NotFound();
            }
            Comment comment = new Comment
            {
                AppUserId = user.Id,
                CreatedTime = DateTime.Now,
                IsAccepted = true,
                Message = Message,
                ProductId = ProductId,
                Star = Star,
                Subject = Subject,

            };
            context.Comments.Add(comment);
            context.SaveChanges();


            ShopVM shopVM = new ShopVM
            {
                Comments = context.Comments.Where(c => c.ProductId == ProductId).ToList()
            };



            return PartialView("_commentPartialView",shopVM);
        }

        public IActionResult Startest()
        {
            Product product = context.Products.Include(p=>p.Comments).FirstOrDefault(p => p.Id == 1027);

            return Json(Math.Ceiling((decimal)product.Rating/product.Comments.Count));
        }
        public IActionResult GetPartial(int id)
        {
            Product product= context.Products.Include(p => p.Brand).Include(p => p.Comments).Include(p => p.Category).Include(p => p.SubCategory).Include(p => p.ProductSizeColors).ThenInclude(p => p.ProductImages).Include(p => p.ProductColors).Include(p => p.ProductSizeColors).ThenInclude(p => p.Size).Include(p => p.ProductSizeColors).ThenInclude(p => p.Color).FirstOrDefault(p => p.Id == id);

            if (context.Comments.Where(c => c.ProductId == product.Id) == null)
            {
                return Json(0); 
            }
            else
            {

                return Json(context.Comments.Include(c => c.Product).Include(p => p.AppUser).Where(c => c.ProductId == product.Id).Count());
            }

        }
    }
}
