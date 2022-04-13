using FinalProjectNurlan.DAL;
using FinalProjectNurlan.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectNurlan.Areas.Admin
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class CommentController : Controller
    {
        private readonly AppDbContext _context;
        public CommentController(AppDbContext context)
        {
            _context = context;
        }

        

        public IActionResult Index(int page = 1)
        {
            ViewBag.CurrentPage = page;
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Comments.Count() / 8);
            List<Comment> comments = _context.Comments.Include(c => c.AppUser).OrderByDescending(c=>c.Id).Skip((page - 1) * 8).Take(8).ToList();
            return View(comments);
        }

        public IActionResult CommentStatus(int id)
        {
            if (!_context.Comments.Any(c => c.Id == id))
            {
                return RedirectToAction("CourseComments", "Comment");
            }

            Comment comment = _context.Comments.FirstOrDefault(c => c.Id == id);
            comment.IsAccepted = comment.IsAccepted ? false : true;

        
            _context.SaveChanges();

            return RedirectToAction("Index", "Comment");



        }

    }
}
