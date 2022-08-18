using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {
        }
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }
        
        public virtual DbSet<User> Users { get; set; }
    }
}
