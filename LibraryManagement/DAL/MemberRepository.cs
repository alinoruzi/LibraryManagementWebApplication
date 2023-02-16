using LibraryManagement.Models;

namespace LibraryManagement.DAL
{
    public static class MemberRepository
    {
        public static List<Member> Members { get; set; }

        static MemberRepository()
        {
            Members = new List<Member>();
        }
    }
}
