using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace PlatformService.Services.Contracts
{
    public interface IImageProcessorService
    {
        Task<string> SaveImage(IFormFile file);
    }
}
