using LibraryManagement.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagement.DAL
{
    public static class GanreRepository
    {
        public static List<Ganre> Ganres { get; set; }

        static GanreRepository()
        {
            Ganres = new List<Ganre>();
            Ganres.Add(new Ganre()
            {
                Id= 1,
                Name = "علمی",
                Description="ژانر ویژه کتب علمی",
            });
            Ganres.Add(new Ganre()
            {
                Id = 2,
                Name = "آشپزی",
                Description = "ژانر ویژه کتب آشپزی",
            });
            Ganres.Add(new Ganre()
            {
                Id = 3,
                Name = "تاریخی",
                Description = "ژانر ویژه کتب تاریخی",
            });
            Ganres.Add(new Ganre()
            {
                Id = 4,
                Name = "رمان",
                Description = "ژانر ویژه کتب رمان",
            });
            Ganres.Add(new Ganre()
            {
                Id = 5,
                Name = "آموزشی",
                Description = "ژانر ویژه کتب آموزشی",
            });
        }
    }
}
