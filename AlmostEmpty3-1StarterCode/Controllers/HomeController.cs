using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlmostEmpty3_1StarterCode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Dynamic objecs used for holding data similar to public class { get: set:}
            // ViewBag.Title = "Home";
            // Same as above but it is a data structure, an array of indexes by name.
            ViewData["Title"] = "Home";
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }
    }
}
