using PlatformService.DTOs;
using PlatformService.Models;
using System.Threading.Tasks;

namespace PlatformService.Services.Contracts
{
    public interface IUserService
    {
        Task<ReadUserDTO> CreateUserAsync(CreateUserDTO createUserDTO);
        Task<ReadUserDTO> UpdateUserAsync(UpdateUserDTO updateUserDTO);
        Task<ReadUserDTO> GetUserByIdAsync(int id);
        Task<int> DeleteUserAsync(int id);
    }
}
