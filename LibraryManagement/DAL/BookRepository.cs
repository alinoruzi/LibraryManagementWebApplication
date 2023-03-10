using LibraryManagement.Models;

namespace LibraryManagement.DAL
{
    public static class BookRepository
    {
        public static List<Book> Books { get; set; }


        static BookRepository()
        {
            Books = new List<Book>();
            Books.Add(new Book()
            {
                Id = 1,
                Title= "اثر مرکب",
                Description= "این کتاب مشهور دستورالعمل‌ لازم برای موفقیت و دستیابی به اهداف و آرزو‌ها را ارائه می‌کند. ",
                Author= "دارن هاردی",
                Ganre = 1,
                BorrowDateTime=null,
                Borrower=null,
            });
            Books.Add(new Book()
            {
                Id = 2,
                Title = "کتاب صبح روز هفتم",
                Description = "مورچه‌های بال‌دار از حاشیه‌ی تصویر او می‌گریزند. او با سایه‌ی كوچكش، بی‌آن‌كه هیچ طرحی از چهره‌اش پیدا باشد، هم‌چنان در متن خاكستری کتاب ایستاده ‌است.",
                Author = "محمود ساطع",
                Ganre = 4,
                BorrowDateTime = DateTime.Parse("14/12/2022"),
                Borrower = MemberRepository.Members.FirstOrDefault(x => x.Id == 1),
            });
            Books.Add(new Book()
            {
                Id = 3,
                Title = "سیستم های عامل",
                Description = "این کتاب مرجعی مناسب جهت سیستم های عامل در هشت فصل و 600 صفحه می باشد.",
                Author = "تننباوم",
                Ganre = 5,
                BorrowDateTime = null,
                Borrower = null,
            });
        }
    }


}
