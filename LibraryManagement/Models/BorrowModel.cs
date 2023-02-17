namespace LibraryManagement.Models
{
    public class BorrowModel
    {
        public Book? Book { get; set; }
        public List<Member> Members { get; set; }
    }
}
