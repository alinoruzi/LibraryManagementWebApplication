using LibraryManagement.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagement.DAL
{
    public static class MemberRepository
    {
        public static List<Member> Members { get; set; }

        static MemberRepository()
        {
            Members = new List<Member>();

            Members.Add(new Member
            {
                Id = 1,
                FirstName= "علی",
                LastName= "نوروزی",
                NationalCode= "1111111111",
                Email= "ali@ali.ali",
                RegistrationDateTime= DateTime.Now,
            });

            Members.Add(new Member
            {
                Id = 2,
                FirstName = "فرهاد",
                LastName = "نعیمی",
                NationalCode = "2222222222",
                Email = "farhad@fr.fr",
                RegistrationDateTime = DateTime.Now,
            });
        }

        public static int GenerateId()
        {
            if (Members.Count == 0)
            {
                return 1;
            }
            else return Members.Last().Id + 1;
        }
    }
}
