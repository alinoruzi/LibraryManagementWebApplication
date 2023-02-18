using LibraryManagement.DAL;
using LibraryManagement.Models;
using static System.Reflection.Metadata.BlobBuilder;

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

        public int GenerateId()
        {
            if (BookRepository.Books.Count == 0)
            {
                return 1;
            }
            else return BookRepository.Books.Last().Id + 1;
        }

        public DateTime? GetLastBorrowing()
        {
            if (BookRepository.Books.Any(x=>x.BorrowDateTime!=null))
            {
                return BookRepository.Books.Max(x => x.BorrowDateTime);
            }
            return null;
        }

        public int GetCountOfBorrowed() => BookRepository.Books.Count(x => x.Borrower != null);
    }
}
