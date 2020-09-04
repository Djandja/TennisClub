using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TennisClub.Data.Context;
using TennisClub.Models;


namespace TennisClub.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public ReservationsController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult NewReservations()
        {
            return View();
        }

        public JsonResult GetReservations()
        {

            var reservations = _context.Reservations.ToList();
            return new JsonResult(new { Data = reservations});


        }

        [HttpPost]
        public JsonResult SaveReservation(Reservations e)
        {
            var status = false;
            
                if (e.ReservationID > 0)
                {
                    //Update the reservation
                    var v = _context.Reservations.Where(a => a.ReservationID == e.ReservationID).FirstOrDefault();
                    if (v != null)
                    {
                        v.Subject = e.Subject;
                        v.Start = e.Start;
                        v.End = e.End;
                        v.Description = e.Description;
                        v.IsFullDay = e.IsFullDay;
                        v.ThemeColor = e.ThemeColor;
                    }
                }
                else
                {
                _context.Reservations.Add(e);
                }
            _context.SaveChanges();
                status = true;

            return new JsonResult(new { Data = new { status = status } });
        }

        [HttpPost]
        public JsonResult DeleteReservation(int reservationID)
        {
            var status = false;
            
                var v = _context.Reservations.Where(a => a.ReservationID == reservationID).FirstOrDefault();
                if (v != null)
                {
                _context.Reservations.Remove(v);
                _context.SaveChanges();
                    status = true;
                }

            return new JsonResult(new { Data = new { status = status } });
        }
    }
}
