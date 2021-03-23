using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BooksMobile.Models;

/* Andrew Cox
   SD-733 Final
   3.10.20 */

namespace BooksMobile.Controllers
{
    public class PatronsController : Controller
    {
        private readonly BooksMobileFactory _context;

        public PatronsController(BooksMobileFactory context)
        {
            _context = context;
        }

        // GET: Patrons
        public async Task<IActionResult> Index()
        {
            return View(await _context.Patrons.ToListAsync());
        }

        // GET: Patrons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patron = await _context.Patrons
                .FirstOrDefaultAsync(m => m.PatronId == id);
            if (patron == null)
            {
                return NotFound();
            }

            return View(patron);
        }

        // GET: Patrons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Patrons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PatronId,FirstName,LastName,PhoneNumber")] Patron patron)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patron);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patron);
        }

        // GET: Patrons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patron = await _context.Patrons.FindAsync(id);
            if (patron == null)
            {
                return NotFound();
            }
            return View(patron);
        }

        // POST: Patrons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PatronId,FirstName,LastName,PhoneNumber")] Patron patron)
        {
            if (id != patron.PatronId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patron);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatronExists(patron.PatronId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(patron);
        }

        // GET: Patrons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patron = await _context.Patrons
                .FirstOrDefaultAsync(m => m.PatronId == id);
            if (patron == null)
            {
                return NotFound();
            }

            return View(patron);
        }

        // POST: Patrons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var patron = await _context.Patrons.FindAsync(id);
            _context.Patrons.Remove(patron);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatronExists(int id)
        {
            return _context.Patrons.Any(e => e.PatronId == id);
        }
    }
}
