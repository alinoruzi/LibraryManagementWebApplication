using LibraryManagement.Models;

namespace LibraryManagement.Services
{
    public interface IMemberService
    {
        public void Add(Book book);
        public void Remove(Book book);
        public Book Get(int id);
        public void Update(Book book);
        public void Delete(int id);
    }
}
