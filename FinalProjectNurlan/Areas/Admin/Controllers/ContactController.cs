using FinalProjectNurlan.DAL;
using FinalProjectNurlan.Extensions;
using FinalProjectNurlan.Models;
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
    [Authorize(Roles ="SuperAdmin,Admin")]
    public class ContactController : Controller
    {
        private readonly AppDbContext context;
        private readonly IWebHostEnvironment env;

        public ContactController(AppDbContext context, IWebHostEnvironment env)
        {
            this.context = context;
            this.env = env;
        }
        public IActionResult Index()
        {
            Contact contact = context.Contact.FirstOrDefault();
            return View(contact);
        }

        public IActionResult Edit(int id)
        {
            Contact contact = context.Contact.FirstOrDefault(c=>c.Id == id);

            return View(contact);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(Contact contact)
        {
            Contact exist = context.Contact.FirstOrDefault(c => c.Id == contact.Id);
            if (!ModelState.IsValid)
            {
                return View(contact);

            }

            if (contact.BannerFile!=null)
            {
                if (!contact.BannerFile.IsImage())
                {
                    ModelState.AddModelError("BannerFile", "Select only image file!");
                    return View(exist);
                }
                if (!contact.BannerFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("BannerFile", "Image size must be less than 2mb!");
                    return View(exist);
                }
                Helpers.Helper.DeleteImg(env.WebRootPath, "assets/images", exist.BannerImage);
                exist.BannerImage = contact.BannerFile.SaveImg(env.WebRootPath, "assets/images");
            }

            exist.BannerDesc = contact.BannerDesc;
            exist.BannerTitle = contact.BannerTitle;
            exist.CloseTime = contact.CloseTime;
            exist.ContactInformation = contact.ContactInformation;
            exist.LocationIcon = contact.LocationIcon;
            exist.OfficeLocation = contact.OfficeLocation;
            exist.OpenTime = contact.OpenTime;
            exist.Phone = contact.Phone;
            exist.PhoneIcon = contact.PhoneIcon;
            exist.Mail = contact.Mail;
            exist.MailIcon = contact.MailIcon;
            exist.OclockIcon = contact.OclockIcon;
            context.SaveChanges();
            return RedirectToAction(nameof(Index));


        }

        public IActionResult Stores()
        {
            List<Store> stores = context.Stores.ToList();

            return View(stores);
        }

        public IActionResult Createstore()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Createstore(Store store)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (store.ImageFile == null)
            {
                ModelState.AddModelError("ImageFile", "Image cannot be null");
                return View();
            }

            if (!store.ImageFile.IsSizeOkay(2))
            {
                ModelState.AddModelError("ImageFile", "Image size cannot be bigger than 2MB");
                return View();

            }
            if (!store.ImageFile.IsImage())
            {
                ModelState.AddModelError("ImageFile", "Select only image files!");
                return View();

            }

          store.StoreImage =   store.ImageFile.SaveImg(env.WebRootPath, "assets/images/stores");

            context.Stores.Add(store);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
