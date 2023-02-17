namespace LibraryManagement.Models
{
    public class IndexModel
    {
        public int CountOfBooks { get; set; }
        public int CountOfMembers { get; set; }
        public int CountOfBorrowedBook { get; set; }
        public int CountOfBorrowed { get; set; }
        public DateTime? LastBorrowing { get; set; }
    }
}
