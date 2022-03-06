using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vesper.DAL;
using vesper.Models;

namespace vesper.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialsController : Controller
    {
        private readonly VesperDbContext db;
        public TestimonialsController(VesperDbContext _db)
        {
            db = _db;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Testimonials.ToListAsync());
        }
        public async Task<IActionResult> Details(int id)
        {
            return View(await db.Testimonials.FirstOrDefaultAsync(x=>x.Id == id));
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Testimonial testimonial)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await db.Testimonials.AddAsync(testimonial);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Testimonials");
        }


    }
}
