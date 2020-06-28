using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace zenxu.Models.Account
{
    public class LoginModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email Address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}