using FinalProjectNurlan.DAL;
using FinalProjectNurlan.Models;
using FinalProjectNurlan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext context;

        public BlogController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            BlogVM vM = new BlogVM
            {
                Blogs = context.Blogs.Include(c => c.Comments).Include(b => b.BlogTags).ThenInclude(b => b.Tag).ToList(),
                Tags = context.Tags.Include(c => c.BlogTags).ThenInclude(c => c.Blog).ToList()
            } ;
            return View(vM);
        }

        public IActionResult Details(int id)
        {
            Blog blog = context.Blogs.Include(c => c.Comments).Include(b => b.BlogTags).ThenInclude(b => b.Tag).FirstOrDefault(c => c.Id == id);

            if (blog==null)
            {
                return NotFound();
            }

          

            BlogVM vM = new BlogVM
            {
                Blogs = context.Blogs.Include(c => c.Comments).Include(b => b.BlogTags).ThenInclude(b => b.Tag).ToList(),
                Tags = context.Tags.Include(c => c.BlogTags).ThenInclude(c => c.Blog).ToList(),
                Blog = context.Blogs.Include(c => c.Comments).Include(b => b.BlogTags).ThenInclude(b => b.Tag).FirstOrDefault(c => c.Id == id)
        };
            return View(vM);
        }
    }
}
