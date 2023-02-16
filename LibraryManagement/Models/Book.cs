using System;
using LibraryManagement.Models.Enums;

namespace LibraryManagement.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public Ganre Ganre { get; set; }
        public DateTime? BorrowDateTime { get; set; }
        public Member? Borrower { get; set; }
    }
}
