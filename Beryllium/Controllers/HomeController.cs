using Beryllium.DAL;
using Beryllium.ViewModel;
using Beryllium.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            HomeViewModel beryllium = new HomeViewModel
            {
                sliders = _db.Sliders.ToList(),
                Projects = _db.Projects.ToList(),
                News = _db.News.Take(3).ToList(),
                Testimonials = _db.Testimonials.ToList(),
                Offers = _db.Offers.ToList(),
            };
            return View(beryllium);
        }
    }
}
