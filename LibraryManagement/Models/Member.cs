namespace LibraryManagement.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDateTime { get; set; }
        public DateTime ExpireDateTime { get; set; }
    }
}
