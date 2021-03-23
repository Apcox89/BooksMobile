using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; //context class historical references as Factory

namespace BooksMobile.Models
{
    public class BooksMobileFactory : DbContext
    {
        public BooksMobileFactory(DbContextOptions<BooksMobileFactory> options) : base(options) 
        { }

        public DbSet<Patron> Patrons { get; set; }

        public DbSet<Book> Books { get; set; }
    }
}
