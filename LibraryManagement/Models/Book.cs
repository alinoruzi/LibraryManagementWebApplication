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
        [DisplayName("عنوان")]
        public string Title { get; set; }
        [MaxLength(350)]
        [DisplayName("توضیحات")]
        public string Description { get; set; }
        [MaxLength(50)]
        [DisplayName("نویسنده")]
        public string Author { get; set; }
        public int Ganre { get; set; }
        public DateTime? BorrowDateTime { get; set; }
        public Member? Borrower { get; set; }
    }
}
