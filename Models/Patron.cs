using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BooksMobile.Models
{
    public class Patron
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]      
        public int PatronId { get; set; } 

        [Required]
        public String FirstName { get; set; }

        [Required]
        public String LastName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public String PhoneNumber { get; set; }

       //Books pass to Patron class
       
    }
}
