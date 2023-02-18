using LibraryManagement.Models;

namespace LibraryManagement.Services
{
    public interface IBookService
    {
        public void Add(Book book);
        public Book GetBookBy(int id);
        public void Update(int id, string title, string author, int ganre, string description);
        public void Delete(int id);
        public int GenerateId();
        public DateTime? GetLastBorrowing();
        public int GetCountOfBorrowed();
    }
}
