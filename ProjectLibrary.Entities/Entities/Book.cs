﻿using System.ComponentModel.DataAnnotations;

namespace ProjectLibrary.Server.Entities
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
        public string Genre { get; set; }

        [Required]
        public int TotalCopies { get; set; }

        [Required]
        public int AvailableCopies { get; set; }

        
        public ICollection<BorrowedBook> BorrowedBooks { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
