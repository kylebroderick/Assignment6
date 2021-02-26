using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
        public class Book
        {
            [Key]
            public int BookId { get; set; }

            [Required]
            public string Title { get; set; }

            [Required]
            public string Author { get; set; }

            [Required]
            public string Publisher { get; set; }

            [RegularExpression(@"^\d{9}[\d|X]$", ErrorMessage = "Invalid ISBN")]
            [Required]
            public string ISBN { get; set; }

            [Required]
            public string Category { get; set; }

            [Required]
            public double Price { get; set; }

            [Required]
            public int Pages { get; set; }
        }
}