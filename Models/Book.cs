using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    //model for the database 
    public class Book
    {
        //primary key
        [Key]
        [Required]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorFname { get; set; }
        public string AuthorMiddle { get; set; }
        [Required]
        public string AuthorLname { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        //regex standardization for ISBN
        [RegularExpression(@"/d{3}-\d{10}", ErrorMessage = "ISBN entered incorrectly, must be in ###-########## format")]
        public string ISBN { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Pages { get; set; }
    }
}
