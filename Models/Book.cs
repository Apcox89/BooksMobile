using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BooksMobile.Models
{
    public class Book
    {
        public String BookTitle { get; set; }

        public String Author { get; set; }

        public int YearPublished { get; set; }

        public String CallNumber { get; set; }

        public Boolean CheckedOut { get; set; }

        //[ForeignKey("Patron")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
    
        public int? PatronId { get; set; }
        //testing conditions in get/set methods: this crashes books page:
        /*{ get
            {
                if (this.CheckedOut == true)
                {
                    this.PatronId = PatronId;
                }
                else{ this.PatronId = 0; }
                return this.PatronId;
            }
            set
            { this.PatronId = value; }
        } */

        // if not checkedout datetime = default value 12/31/3000, else return DateDue
        public DateTime DateDue { get; set; }
        //this Code also crashed Books page:
       /* { get
            {
                if (this.CheckedOut == false)
                {
                    this.DateDue = Convert.ToDateTime("12 / 31 / 3000");
                }                
                return this.DateDue;
            }        
          set 
          { this.DateDue = value; } 
        }   */  
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookId { get; set; }

        public Patron Patron { get; set; }
    }
}
