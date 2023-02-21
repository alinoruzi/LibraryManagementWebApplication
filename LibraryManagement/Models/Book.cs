using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Book
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        [Display(Name = "عنوان")]
        public string Title { get; set; }
        [MaxLength(350)]
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        [MaxLength(50)]
        [Display(Name ="نویسنده")]
        public string Author { get; set; }
        public int Ganre { get; set; }
        public DateTime? BorrowDateTime { get; set; }
        public Member? Borrower { get; set; }
    }
}
