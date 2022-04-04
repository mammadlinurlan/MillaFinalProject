using FinalProjectNurlan.DAL;
using FinalProjectNurlan.Models;
using FinalProjectNurlan.Extensions;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class SettingsController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _env;
        public SettingsController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            Settings setting = _context.Settings.FirstOrDefault();
            return View(setting);
        }

        public IActionResult Edit(int id)
        {
            Settings settings = _context.Settings.FirstOrDefault(s => s.Id == id);
            return View(settings);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Settings setting)
        {


            //if (!ModelState.IsValid)
            //{
            //    return View(setting);
            //}

            Settings exist = _context.Settings.FirstOrDefault(s => s.Id == setting.Id);

            if (setting.HeaderLogoImageFile != null)
            {
                if (!setting.HeaderLogoImageFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("HeaderLogoImageFile", "Image size must be less than 2mb");
                    return View(setting);
                }
                if (!setting.HeaderLogoImageFile.IsImage())
                {
                    ModelState.AddModelError("HeaderLogoImageFile", "Select an image file! ");
                    return View(setting);
                }
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images/video", exist.HeaderLogoImage);
                exist.HeaderLogoImage = setting.HeaderLogoImageFile.SaveImg(_env.WebRootPath, "assets/images/video");
            }






            if (setting.FooterLogoImageFile != null)
            {
                if (!setting.FooterLogoImageFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("FooterLogoImageFile", "Image size must be less than 2mb");
                    return View(setting);
                }
                if (!setting.FooterLogoImageFile.IsImage())
                {
                    ModelState.AddModelError("FooterLogoImageFile", "Select an image file! ");
                    return View(setting);
                }
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images/video", exist.FooterLogoImage);
                exist.FooterLogoImage = setting.FooterLogoImageFile.SaveImg(_env.WebRootPath, "assets/images/video");
            }

            exist.BasketIcon = setting.BasketIcon;
            exist.FbIcon = setting.FbIcon;

            exist.Phone = setting.Phone;
            exist.SearchIcon = setting.SearchIcon;
            exist.FooterDesc = setting.FooterDesc;
            exist.Copyright = setting.Copyright;
            exist.YtLink = setting.YtLink;
            exist.YoutubeIcon = setting.YoutubeIcon;
            exist.WishlistIcon = setting.WishlistIcon;
            exist.LittleWishlist = setting.LittleWishlist;
            exist.InstaIcon = setting.InstaIcon;
            exist.PinterestLink = setting.PinterestLink;
            exist.TwitLink = setting.TwitLink;
            exist.FbLink = setting.FbLink;
            exist.InstaLink = setting.InstaLink;
            exist.TwitIcon = setting.TwitIcon;
            exist.PinterestIcon = setting.PinterestIcon;

            exist.HomePageDeliveryIcon = setting.HomePageDeliveryIcon;
            exist.HomePagePaymentIcon = setting.HomePagePaymentIcon;
            exist.HomePageSupportIcon = setting.HomePageSupportIcon;
            exist.HomePageRefundIcon = setting.HomePageRefundIcon;
            exist.UserIcon = setting.PinterestIcon;



            _context.SaveChanges();
            return RedirectToAction(nameof(Index));






        }
    }
}
