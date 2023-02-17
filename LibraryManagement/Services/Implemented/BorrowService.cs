using LibraryManagement.DAL;

namespace LibraryManagement.Services.Implemented
{
    public class BorrowService : IBorrowService
    {
        public void BorrowBook(int bookId, int memberId)
        {
            var book = BookRepository.Books.First(x => x.Id == bookId);
            book.Borrower = MemberRepository.Members.First(x => x.Id == memberId);
            book.BorrowDateTime = DateTime.Now;
        }

        public void ReturnBook(int bookId)
        {
            var book = BookRepository.Books.First(x => x.Id == bookId);
            book.Borrower = null;
            book.BorrowDateTime = null;
        }
    }
}
