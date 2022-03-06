using Microsoft.AspNetCore.Mvc;
using phantom.DAL;
using phantom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace phantom.Controllers
{
    public class BlogsController : Controller
    {
        private readonly AppDbContext db;

        public BlogsController(AppDbContext actualDb)
        {
            db = actualDb;
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(string title, string subtitle, string image, string text)
        {
            Blog newBlog = new Blog(title, subtitle, text, image);

            await db.blogs.AddAsync(newBlog);
            await db.SaveChangesAsync();

            return View();
        }
    }
}
