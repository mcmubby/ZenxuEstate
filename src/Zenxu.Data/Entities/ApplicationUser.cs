using Microsoft.AspNetCore.Identity;

namespace Zenxu.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}