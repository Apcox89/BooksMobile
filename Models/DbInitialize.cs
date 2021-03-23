using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BooksMobile.Models
{
    public static class DbInitialize
    {
        public static void Initialize(BooksMobileFactory context)
        {
            //checks db initialized accordingly
            context.Database.EnsureCreated();

            //checks if duplicate library patron
            if (context.Patrons.Any())
            { return; }

            //values to seed to model attributes to generate db
            context.Patrons.Add(new Patron()
            {
                PatronId = 1001,
                FirstName = "Baker",
                LastName = "Junefield",
                PhoneNumber = "555-555-1212"
            });

            context.Patrons.Add(new Patron()
            {
                PatronId = 1002,
                FirstName = "Russell",
                LastName = "Wilsonian",
                PhoneNumber = "555-555-1213"
            });

            context.Patrons.Add(new Patron()
            {
                PatronId = 1003,
                FirstName = "Ryan",
                LastName = "Tannemount",
                PhoneNumber = "123-555-9876"
            });

            context.Books.Add(new Book()
            {
                BookTitle = "Bootstrap for ASP.NET MVC",
                Author = "Pieter van der Westhuizen",
                YearPublished = 2016,
                CallNumber = "Pvd 708.123",
                CheckedOut = true,
                DateDue = new DateTime(12/12/2019),
                BookId = 1200,
                PatronId = 1003
            });

            context.Books.Add(new Book()
            {
                BookTitle = "Expert Android Studio",
                Author = "Murat Yenar",
                YearPublished = 2016,
                CallNumber = "Yem 712.50",
                CheckedOut = false,
                DateDue = new DateTime(12 / 31 / 3000),
                BookId = 1210
            });

            context.Books.Add(new Book()
            {
                BookTitle = "Believe It, Be It",
                Author = "Ali Vincent",
                YearPublished = 2010,
                CallNumber = "Val 312",
                CheckedOut = false,
                DateDue = new DateTime(12 / 31 / 3000),
                BookId = 1220
            });

            context.Books.Add(new Book()
            {
                BookTitle = "Winning and Losing",
                Author = "John Affleck",
                YearPublished = 2016,
                CallNumber = "Aff 502.50",
                CheckedOut = true,
                DateDue = new DateTime(12 / 11 / 2019),
                BookId = 1230,
                PatronId = 1001
            });

            context.Books.Add(new Book()
            {
                BookTitle = "How to Get Along with Difficult People",
                Author = "Florence Littauer",
                YearPublished = 2009,
                CallNumber = "Lit 458.9",
                CheckedOut = true,
                DateDue = new DateTime(11 / 29 / 2019),
                BookId = 1240,
                PatronId = 1002
            });

            context.Books.Add(new Book()
            {
                BookTitle = "Difficult People - For in One Bundle",
                Author = "Robert E. Baines Jr",
                YearPublished = 2016,
                CallNumber = "SOC 232",
                CheckedOut = false,
                DateDue = new DateTime(12 / 31 / 3000),
                BookId = 1250,
            });

            context.Books.Add(new Book()
            {
                BookTitle = "MVC Nightmares",
                Author = "William E. Gates",
                YearPublished = 2018,
                CallNumber = "PSY 120",
                CheckedOut = true,
                DateDue = new DateTime(12 / 11 / 2019),
                BookId = 1260,
                PatronId = 1002
            });        

            context.SaveChanges();
        }
    }
}
