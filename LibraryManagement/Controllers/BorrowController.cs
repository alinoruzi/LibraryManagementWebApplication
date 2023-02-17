using LibraryManagement.DAL;
using LibraryManagement.Models;
using LibraryManagement.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace LibraryManagement.Controllers
{
    public class BorrowController : Controller
    {
        private IBorrowService _borrowService;
        private IBookService _bookService;
        public BorrowController(IBorrowService borrowService, IBookService bookService)
        {
            _borrowService = borrowService;
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Index(int bookId) 
        {
            BorrowModel borrow = new BorrowModel();
            borrow.Book = _bookService.GetBookBy(bookId);
            borrow.Members = MemberRepository.Members;
            if (borrow.Book == null)
                return RedirectToAction("Index","Books");
            return View(borrow);
        }
        

        [HttpPost]
        public IActionResult Index(int bookId, int memberId)
        {
            _borrowService.BorrowBook(bookId, memberId);
            return RedirectToAction("Borrowed", "Books");
        }

        [HttpGet]
        public IActionResult Return(int bookId)
        {
            var book = _bookService.GetBookBy(bookId);
            if (book != null)
            {
                book.Borrower = null;
                book.BorrowDateTime = null;
            }
            return RedirectToAction("Borrowed", "Books");
        }

    }
}
