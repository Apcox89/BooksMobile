using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering; //Allows us to create Dynamic Lists
using Microsoft.EntityFrameworkCore; //Dependcy Injection
using BooksMobile.Models;

/* Andrew Cox
   SD-733 Final
   3.10.20 */

namespace BooksMobile.Controllers
{
    public class ExampartbController : Controller
    {
        private readonly BooksMobileFactory _context;

        public ExampartbController(BooksMobileFactory context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var booksMobileFactory = _context.Books.Include(b => b.Patron);
            return View(await booksMobileFactory.ToListAsync());
        }

        //GET:
        public IActionResult SearchAuthor()
        {
            var authorList = new List<SelectListItem>();

            foreach (var b in _context.Books)
                authorList.Add(new SelectListItem
                {
                    Text = b.Author,
                    Value = b.BookId.ToString()
                });
            ViewBag.listOfAuthors = authorList;

            return View();           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        //POST:
        public IActionResult ListAuthorBooks()
        {
            String selectedId = Request.Form["BookId"];
            ViewBag.message = selectedId;
            int sid = Int32.Parse(selectedId);

            var books = _context.Books
                .Where(b => b.BookId == sid)
                .SingleOrDefault();

            ViewBag.bId = selectedId;
            ViewBag.books = books;

            return View();
        }

        //GET:
        public IActionResult Cout()
        {
            var booksList = new List<SelectListItem>();

            foreach (var b in _context.Books)
                if (b.CheckedOut == true)
                {
                    booksList.Add(new SelectListItem
                    {
                        Text = b.BookTitle,
                        Value = b.BookId.ToString()
                    });
                    ViewBag.listOfBooks = booksList;
                }

            return View();
        
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        //POST:
        public IActionResult Calcfine()
        {
            String selectedId = Request.Form["BookId"];
            ViewBag.message = selectedId;
            int sid = Int32.Parse(selectedId);

            var books = _context.Books
            .Where(b => b.BookId == sid)
            .SingleOrDefault();

            ViewBag.books = books;

            return View();
        }

    }
}