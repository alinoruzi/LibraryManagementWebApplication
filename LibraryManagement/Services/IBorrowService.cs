namespace LibraryManagement.Services
{
    public interface IBorrowService
    {
        public void BorrowBook(int bookId, int memberId);
        public void ReturnBook(int bookId);
    }
}
