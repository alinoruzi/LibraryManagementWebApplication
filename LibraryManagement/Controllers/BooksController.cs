using LibraryManagement.DAL;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View(BookRepository.Books);
        }
    }
}
