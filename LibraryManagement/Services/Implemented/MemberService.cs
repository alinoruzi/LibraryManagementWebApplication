using LibraryManagement.DAL;
using LibraryManagement.Models;

namespace LibraryManagement.Services.Implemented
{
    public class MemberService : IMemberService
    {
        public void Add(Member member)
        {
            MemberRepository.Members.Add(member);
        }

        public void Delete(int id)
        {
            MemberRepository.Members.RemoveAll(x => x.Id == id);
        }

        public Member Get(int id) => MemberRepository.Members.FirstOrDefault(x => x.Id == id);

        public void Update(Member member)
        {
            var selected = MemberRepository.Members.First(x=> x.Id == member.Id);
            selected.FirstName = member.FirstName;
            selected.LastName = member.LastName;
            selected.Email = member.Email;
            selected.NationalCode = member.NationalCode;
        }
    }
}
