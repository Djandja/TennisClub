using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TennisClub.Data.Context;
using TennisClub.Models.TurnirsViewModel;

namespace TennisClub.Controllers
{
    public class TurnirsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TurnirsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Turnirs
        public async Task<IActionResult> TurnirsIndex()
        {
            var applicationDbContext = _context.Turnirs.Include(t => t.User);
            return View(await applicationDbContext.ToListAsync());
        }

        
        // GET: Turnirs/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            //ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id");
            if(id==0)
            return View(new Turnirs());
            else
                return View(_context.Turnirs.Find(id));
        }

        // POST: Turnirs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("TurnirID,TurnirsTitle,StartDate,EndDate,NumberOfParticipants,NumberOfRegistered,UserID")] Turnirs turnirs)
        {
            if (ModelState.IsValid)
            {
                if (turnirs.TurnirID == 0)
                    _context.Add(turnirs);
                else
                    //turnirs.NumberOfParticipants = turnirs.NumberOfParticipants + 1;
                    _context.Update(turnirs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(TurnirsIndex));
            }
            //ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", turnirs.UserID);
            return View(turnirs);
        }

        
        // GET: Turnirs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var turnirs = await _context.Turnirs.FindAsync(id);
            _context.Turnirs.Remove(turnirs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult click(Turnirs turnirs, string button)
        {
            if(button== "first")
            turnirs.NumberOfParticipants++;

            return RedirectToAction("TurnirsIndex");
        }


        // GET: Turnirs/Apply to turnir
        public IActionResult ApplyToTurnir(int id = 0)
        {
            //ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id");
            //if (id == 0)
            //    return View(new Turnirs());
            //else
                return View(_context.Turnirs.Find(id));
        }

        // POST: Turnirs/Apply to turnir
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ApplyToTurnir([Bind("TurnirID,TurnirsTitle,StartDate,EndDate,NumberOfParticipants,NumberOfRegistered,UserID")] Turnirs turnirs)
        {
            if (ModelState.IsValid)
            {
                //if (turnirs.TurnirID == 0)
                //    _context.Add(turnirs);
                //else
                turnirs.NumberOfRegistered = turnirs.NumberOfRegistered + 1;
                _context.Update(turnirs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(TurnirsIndex));
            }
            //ViewData["UserID"] = new SelectList(_context.Users, "Id", "Id", turnirs.UserID);
            return View(turnirs);
        }

    }
}
