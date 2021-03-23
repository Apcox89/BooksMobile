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
    public class BooksController : Controller
    {
        private readonly BooksMobileFactory _context;

        public BooksController(BooksMobileFactory context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            var booksMobileFactory = _context.Books.Include(b => b.Patron);          

         return View(await booksMobileFactory.ToListAsync());          
           
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .Include(b => b.Patron)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            //this code returns data from the Patron model, which we want to not display and also to modify:
           ViewData["PatronId"] = new SelectList(_context.Patrons, "PatronId", "FirstName");
            return View();

            //create actions on items in notes to enact with server
        }

        // POST: Books/Create        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookTitle,Author,YearPublished,CallNumber,CheckedOut,PatronId,DateDue,BookId")] Book book)
        {
            //Set default values in the _context.Add(book) condition, then verify:            
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();

                //set local variable to request a part of the 'create.cshtml' form
                //to aggregate the if condition to part of the db

                String BookTitle = Request.Form["BookTitle"];

                //for each to iterate over a condition within the context to set values:
                foreach (var b in _context.Books)
                    if (b.BookTitle != "")//if the book title has a value input on the form
                {
                        //then enter these values in that row of the db's new Book item.
                        b.CheckedOut = false;
                        b.PatronId = 0;
                        b.DateDue = Convert.ToDateTime("12 / 31 / 3000");
                        b.BookId = 1270;
                } //Testing values these should rather be form receieved and db genereated
                  //rather than hard coded. Verification test:
                  //^^This code runs with the program but does net fetch the correct result                

                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PatronId"] = new SelectList(_context.Patrons, "PatronId", "FirstName", book.PatronId);
            return View(book);
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["PatronId"] = new SelectList(_context.Patrons, "PatronId", "FirstName", book.PatronId);
            return View(book);
        }

        // POST: Books/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookTitle,Author,YearPublished,CallNumber,CheckedOut,PatronId,DateDue,BookId")] Book book)
        {
            if (id != book.BookId)
            {
                return NotFound();
            }
       

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookId))
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
            ViewData["PatronId"] = new SelectList(_context.Patrons, "PatronId", "FirstName", book.PatronId);
            return View(book);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .Include(b => b.Patron)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Books.FindAsync(id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.BookId == id);
        }
    }
}
