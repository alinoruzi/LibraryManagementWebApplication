using LibraryManagement.Models;

namespace LibraryManagement.Services
{
    public interface IMemberService
    {
        public void Add(Member member);
        public Member Get(int id);
        public void Update(Member member);
        public void Delete(int id);
    }
}
