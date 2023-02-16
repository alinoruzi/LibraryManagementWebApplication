using LibraryManagement.DAL;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LibraryManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            IndexModel indexModel = new IndexModel();
            indexModel.CountOfBooks = BookRepository.Books.Count;
            indexModel.CountOfMembers = MemberRepository.Members.Count;
            indexModel.LastBorrowing = BookRepository.Books.MaxBy(x=>x.BorrowDateTime).BorrowDateTime;

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