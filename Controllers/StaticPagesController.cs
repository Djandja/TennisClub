using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TennisClub.Controllers
{
    public class StaticPagesController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult TennisSchool()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult Turnirs()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
