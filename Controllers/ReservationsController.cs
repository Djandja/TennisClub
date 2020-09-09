using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TennisClub.Data.Context;
using TennisClub.Helpers.UserHelper;
using TennisClub.Models;

namespace TennisClub.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserHelper _helper;

        public ReservationsController(ApplicationDbContext context, IUserHelper helper)
        {
            _context = context;
            _helper = helper;
        }

        // GET: Reservations
        public async Task<IActionResult> ReservationsIndex()
        {
            var applicationDbContext = _context.Reservations.Include(r => r.User);
            return View(await applicationDbContext.ToListAsync());
        }


        // GET: Reservations/Create
        public IActionResult AddOrEditReservation(int id =0)
        {
            if (id == 0)
            {
                AddCourtsToReservationsViewModel();
                AddStartTimesToReservationsViewModel();
                AddEndTimesToReservationsViewModel();
                var vm = new Reservations();
              
                return View(vm);
            }
            
           
            else
                return View(_context.Reservations.Find(id));

        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEditReservation([Bind("ReservationID,Subject,Description,StartDateReservation,StartTime,EndTime,Amount,Court,UserID")] Reservations reservations)
        {
            
            if (ModelState.IsValid)
            {

                if (reservations.ReservationID == 0)
                {
                    reservations.UserID = _helper.GetLoggedInUser().Id;
                    _context.Add(reservations);
                }
                   
                else
                    _context.Update(reservations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ReservationsIndex));
            }
            //ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", reservations.UserID);
            return View(reservations);
        }

 
        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservations = await _context.Reservations
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.ReservationID == id);
            if (reservations == null)
            {
                return NotFound();
            }

            return View(reservations);
        }

        public void AddCourtsToReservationsViewModel()
        {
            //RegisterViewModel.Roles = new List<SelectListItem>
            Reservations.Courts = new List<SelectListItem>
            {
                new SelectListItem{Text = "I", Value = "I"},
                new SelectListItem{Text = "II", Value = "II"},
                new SelectListItem{Text = "III", Value = "III"},
                new SelectListItem{Text = "IV", Value = "IV"}

            };
        }

        public void AddStartTimesToReservationsViewModel()
        {
            //RegisterViewModel.Roles = new List<SelectListItem>
            Reservations.StartTimes = new List<SelectListItem>
            {
                new SelectListItem{Text = "8:00", Value = "8:00"},
                new SelectListItem{Text = "9:00", Value = "9:00"},
                new SelectListItem{Text = "10:00", Value = "10:00"},
                new SelectListItem{Text = "11:00", Value = "11:00"},
                new SelectListItem{Text = "12:00", Value = "12:00"},
                new SelectListItem{Text = "13:00", Value = "13:00"},
                new SelectListItem{Text = "14:00", Value = "14:00"},
                new SelectListItem{Text = "15:00", Value = "15:00"},
                new SelectListItem{Text = "16:00", Value = "16:00"},
                new SelectListItem{Text = "17:00", Value = "17:00"},
                new SelectListItem{Text = "18:00", Value = "18:00"},
                new SelectListItem{Text = "19:00", Value = "19:00"},
                new SelectListItem{Text = "20:00", Value = "20:00"},
                new SelectListItem{Text = "21:00", Value = "21:00"}

            };
        }

        public void AddEndTimesToReservationsViewModel()
        {
            //RegisterViewModel.Roles = new List<SelectListItem>
            Reservations.EndTimes = new List<SelectListItem>
            {
                new SelectListItem{Text = "8:00", Value = "8:00"},
                new SelectListItem{Text = "9:00", Value = "9:00"},
                new SelectListItem{Text = "10:00", Value = "10:00"},
                new SelectListItem{Text = "11:00", Value = "11:00"},
                new SelectListItem{Text = "12:00", Value = "12:00"},
                new SelectListItem{Text = "13:00", Value = "13:00"},
                new SelectListItem{Text = "14:00", Value = "14:00"},
                new SelectListItem{Text = "15:00", Value = "15:00"},
                new SelectListItem{Text = "16:00", Value = "16:00"},
                new SelectListItem{Text = "17:00", Value = "17:00"},
                new SelectListItem{Text = "18:00", Value = "18:00"},
                new SelectListItem{Text = "19:00", Value = "19:00"},
                new SelectListItem{Text = "20:00", Value = "20:00"},
                new SelectListItem{Text = "21:00", Value = "21:00"}

            };
        }



    }
}
