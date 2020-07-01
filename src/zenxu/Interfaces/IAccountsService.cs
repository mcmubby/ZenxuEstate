using System.Threading.Tasks;
using zenxu.Models.Account;
using Zenxu.Data.Entities;

namespace zenxu.Interfaces
{
    public interface IAccountsService
    {
        Task<ApplicationUser> CreateUserAsync(RegisterModel model);

    }
}