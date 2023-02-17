using LibraryManagement.DAL;
using LibraryManagement.Models;
using LibraryManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class BooksController : Controller
    {
        private IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            return View(BookRepository.Books);
        }

        [HttpGet]
        public IActionResult Delete(int bookId)
        {
            if (_bookService.GetBookBy(bookId) != null)
            {
                _bookService.Delete(bookId);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Borrowed()
        {
            var borrowedBooks = BookRepository.Books.Where(x => x.Borrower is not null).ToList();
            if (borrowedBooks is null)
            {
                return RedirectToAction("Index","Home");
            }
            return View(borrowedBooks);
        }

        [HttpGet]
        public IActionResult Add() => View(GanreRepository.Ganres);

        [HttpPost]
        public IActionResult Add(string title, string author, int ganre, string description)
        {
            Book book = new Book();
            book.Id = BookRepository.GenerateId();
            book.Title = title;
            book.Author = author;
            book.Description = description;
            book.Ganre = ganre;
            book.Borrower = null;
            book.BorrowDateTime = null;
            
            _bookService.Add(book);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int bookId)
        {
            Book? book = BookRepository.Books.FirstOrDefault(x=>x.Id== bookId);
            if (book is null)
                return RedirectToAction("Index");
            EditBookModel editBookModel = new EditBookModel();
            editBookModel.Book = book;
            editBookModel.Ganres = GanreRepository.Ganres;
            return View(editBookModel);
        }

        [HttpPost]
        public IActionResult Edit(int id, string title, string author, int ganre, string description)
        {
            _bookService.Update(id, title, author, ganre, description);
            return RedirectToAction("Index");
        }
    }
}
