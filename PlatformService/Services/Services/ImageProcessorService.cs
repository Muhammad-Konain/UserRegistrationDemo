using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using PlatformService.Services.Contracts;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PlatformService.Services.Services
{
    public class ImageProcessorService : IImageProcessorService
    {
        public async Task<string> SaveImage(IFormFile file)
        {
            string filePath = string.Empty;
            if (file != null && file.Length > 0)
            {

                filePath = Path.Combine(Directory.GetCurrentDirectory(), @"Docs\", file.FileName);
                if( File.Exists(filePath))
                    filePath=Path.Combine(Directory.GetCurrentDirectory(), @"Docs\", DateTime.Now.Ticks + file.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            return filePath;
        }
    }
}
