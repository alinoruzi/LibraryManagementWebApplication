using LibraryManagement.DAL;
using LibraryManagement.Models;
using LibraryManagement.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LibraryManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookService _bookService;

        public HomeController(ILogger<HomeController> logger,IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            IndexModel indexModel = new IndexModel();
            indexModel.CountOfBooks = BookRepository.Books.Count;
            indexModel.CountOfMembers = MemberRepository.Members.Count;
            indexModel.CountOfBorrowedBook = _bookService.GetCountOfBorrowed();
            var lastBorrowing = _bookService.GetLastBorrowing();
            indexModel.LastBorrowing = (lastBorrowing == null ? "فاقد امانت" : lastBorrowing.ToString());

            return View(indexModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}