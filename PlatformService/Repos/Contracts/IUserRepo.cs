using PlatformService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlatformService.Repos.Contracts
{
    public interface IUserRepo
    {
        Task<User> CreateUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task<User> GetUserAsync(int id);
        Task<int> DeleteUserAsync(int id);
    }
}
