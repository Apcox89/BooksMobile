using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering; //Allows us to create Dynamic Lists
using Microsoft.EntityFrameworkCore; //Dependcy Injection
using BooksMobile.Models; //Allows us to code Views in our Controller based on the Models

/* Andrew Cox
   SD-733 Final
   3.10.20 */

namespace BooksMobile.Controllers
{
    public class TransCheckController : Controller
    {
        //pass the context from the model to get db Info:
        private readonly BooksMobileFactory _context;

        public TransCheckController(BooksMobileFactory context)
        {
            _context = context;
        }
        //GET: Books
        public async Task<IActionResult> Index()
        {
            //Make a call to the db for Controller
            var booksMobileFactory = _context.Books.Include(b => b.Patron);
            return View(await booksMobileFactory.ToListAsync());
          
        }

        //Serves as Get for CheckBookOut:
        public IActionResult Create([Bind("BookId, PatronId")] Book book, Patron patron)
        {
            //generate your dd lists variable
            var bookTitleList = new List<SelectListItem>();        

            //call to db + need if condition for checked out
            foreach (var b in _context.Books)
                if (b.CheckedOut == false)
                {
                    bookTitleList.Add(new SelectListItem
                    {
                        Text = b.BookTitle,
                        Value = b.BookId.ToString()
                    });
                }
            ViewBag.listOfBooks = bookTitleList;
            
            //make the list from Patron Id and pass to books.Patronid:
            ViewData["PatronIdList"] = new SelectList(_context.Patrons, "PatronId","LastName", book.PatronId);

            return View(); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        //Post of the Class Enrollees Create:
        public async Task<IActionResult> CheckBookOut( [Bind("BookId, PatronId")] Book book, Patron patron)
            
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();

                //local variables to request form elements:
                int bID = Int32.Parse(Request.Form["BookId"].ToString());
                int pID = Int32.Parse(Request.Form["PatronId"].ToString());

                var books = _context.Books.Where(b => b.BookId == bID).Single();
                var patrons = _context.Books.Where(p => p.PatronId == pID).Single();

                //DateTime update:

                //if the local variable id matches this object instace of BookId,
                //then update DateTime in the db:
                if (bID == book.BookId)
                {
                    var datecheckedout = DateTime.Today;
                    DateTime duedate = datecheckedout.AddDays(14);

                    var returnDate = _context.Books.Where(b => b.BookId == bID)
                        .Include(b => b.DateDue == duedate);
                }

                Book Books = (Book)book;                

                _context.Update(book);                
                await _context.SaveChangesAsync();

                return View(book);
            }

            return RedirectToAction("Index", "Books");

            //This code passes through but does not register to db, hmm.
        } 
    }
}