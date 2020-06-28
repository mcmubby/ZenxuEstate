using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace zenxu.Models.Account
{
    public class RegisterModel
    {
        [Required]
        [DisplayName("Fullname")]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email Address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}