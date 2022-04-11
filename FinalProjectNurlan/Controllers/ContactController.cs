using FinalProjectNurlan.DAL;
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

    
    }
}
