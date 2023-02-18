using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Member
    {
        [Required]
        public int Id { get; set; }
        [MaxLength(35)]
        public string FirstName { get; set; }
        [MaxLength(40)]
        public string LastName { get; set; }
        [StringLength(10)]
        public string NationalCode { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime RegistrationDateTime { get; set; }
    }
}
