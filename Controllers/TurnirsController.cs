using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TennisClub.Controllers
{
    public class TurnirsController : Controller
    {
        public IActionResult Turnirs()
        {
            return View();
        }
    }
}
