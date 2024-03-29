﻿using FinalProjectNurlan.DAL;
using FinalProjectNurlan.Extensions;
using FinalProjectNurlan.Models;
using FinalProjectNurlan.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Controllers
{
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
            ContactVM vm = new ContactVM
            {
                Contact = context.Contact.FirstOrDefault(),
                Stores = context.Stores.ToList()
            };
            

            return View(vm);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        //public IActionResult Send(string name, string mail , string subject , string phone ,string message)
        //{


        //    ContactVM vm = new ContactVM
        //    {
        //        Contact = context.Contact.FirstOrDefault(),
        //        Stores = context.Stores.ToList()
        //    };

        //    if (!ModelState.IsValid)
        //    {
        //        return View(vm);
        //    }

        //    Questions questionnew = new Questions
        //    {
        //        IsAcces = false,
        //        Mail = mail,
        //        Message = message,
        //        Name = name,
        //        Phone = phone,
        //        Subject =  subject
        //    };

        //    context.Questions.Add(questionnew);
        //    context.SaveChanges();
        //    return Json(new {status=200 });
        //}

        public IActionResult Index(Questions question)
        {


            ContactVM vm = new ContactVM
            {
                Contact = context.Contact.FirstOrDefault(),
                Stores = context.Stores.ToList()
            };

            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            Questions questionnew = new Questions
            {
                IsAcces = false,
                Mail = question.Mail,
                Message = question.Message,
                Name = question.Name,
                Phone = question.Phone,
                Subject = question.Subject
            };

            context.Questions.Add(questionnew);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }



    }
}
