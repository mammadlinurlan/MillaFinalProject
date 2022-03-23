using FinalProjectNurlan.Models;
using FinalProjectNurlan.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Services
{
    public class LayoutService
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public LayoutService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Register(RegisterVM register)
        //{
        //    if (!ModelState.IsValid) return View();

        //    AppUser user = await _userManager.FindByNameAsync(register.Username);
        //    if (user == null)
        //    {
        //        user = new AppUser
        //        {
        //            UserName = register.Username,
        //            Fullname = register.Fullname,
        //            Email = register.Email
        //        };
        //        if (register.Username == null)
        //        {
        //            ModelState.AddModelError("Username", "Please fill this field");
        //            return View();

        //        }
        //        if (!register.TermsAndConditions)
        //        {
        //            ModelState.AddModelError("TermsAndConditions", "Please fill this box!");
        //            return View();
        //        }
        //        IdentityResult result = await _userManager.CreateAsync(user, register.Password);
        //        if (!result.Succeeded)
        //        {
        //            foreach (IdentityError error in result.Errors)
        //            {
        //                ModelState.AddModelError("", error.Description);
        //            }
        //            return View();
        //        }

        //    }
        //    else
        //    {
        //        ModelState.AddModelError("", "This username already taken");
        //        return View();
        //    }
        //    await _userManager.AddToRoleAsync(user, "Member");

        //    string token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        //    string link = Url.Action(nameof(VerifyEmail), "Account", new { email = user.Email, token }, Request.Scheme, Request.Host.ToString());
        //    MailMessage mail = new MailMessage();
        //    mail.From = new MailAddress("nurlanym@code.edu.az", "EduHome");
        //    mail.To.Add(new MailAddress(user.Email));

        //    mail.Subject = "Email Verification";
        //    string body = string.Empty;
        //    using (StreamReader reader = new StreamReader("wwwroot/assets/template/VerifyEmail.html"))
        //    {
        //        body = reader.ReadToEnd();
        //    }



        //    mail.Body = body.Replace("{{link}}", link);
        //    mail.IsBodyHtml = true;

        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Host = "smtp.gmail.com";
        //    smtp.Port = 587;
        //    smtp.EnableSsl = true;

        //    smtp.Credentials = new NetworkCredential("nurlanym@code.edu.az", "Leylus123");
        //    smtp.Send(mail);
        //    TempData["Verify"] = true;
        //    return RedirectToAction("Index", "Home");

        //}
    }
}
