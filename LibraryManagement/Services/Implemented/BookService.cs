using LibraryManagement.DAL;
using LibraryManagement.Models;

namespace LibraryManagement.Services.Implemented
{
    public class BookService : IBookService
    {
        public void Add(Book book)
        {
            BookRepository.Books.Add(book);
        }

        public void Delete(int id)
        {
            BookRepository.Books.RemoveAll(x=>x.Id==id);
        }

        public Book? GetBookBy(int id) => BookRepository.Books.FirstOrDefault(x => x.Id == id);
       

        public void Update(int id, string title, string author, int ganre, string description)
        {
            var selected = BookRepository.Books.First(x => x.Id == id);
            selected.Title = title;
            selected.Description = description;
            selected.Author = author;
            selected.Ganre = ganre;
        }
    }
}
