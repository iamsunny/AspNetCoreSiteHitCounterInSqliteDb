using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HitCounter.Models;
using Microsoft.AspNetCore.Mvc;

namespace HitCounter.Controllers
{

    public class HomeController : Controller
    {
        private readonly AppStateContext _context;

        public HomeController(AppStateContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var appState = _context.AppStates.FirstOrDefault(x => x.Id == 1);
            var hitCount = ++appState.HitCount;
            _context.SaveChanges();
            ViewData["HitCount"] = hitCount;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
