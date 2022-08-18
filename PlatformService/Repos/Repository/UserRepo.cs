using Microsoft.EntityFrameworkCore;
using PlatformService.Data;
using PlatformService.Models;
using PlatformService.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Repos.Repository
{
    public class UserRepo : IUserRepo
    {
        private AppDBContext _context;

        public UserRepo(AppDBContext context)
        {
            _context = context;
        }
        public async Task<User> CreateUserAsync(User user)
        {
            await _context.Users.AddAsync(user); 

            await _context.SaveChangesAsync(); 

            return user;
        }

        public async Task<int> DeleteUserAsync(int id)
        {
            var user = await _context.Users.Where(w => w.id == id).FirstOrDefaultAsync();

            if (user == null)
                return 0;

            _context.Users.Remove(user);

            return await _context.SaveChangesAsync();
        }

        public async Task<User> GetUserAsync(int id)
        {
            return await _context.Users.Where(s => s.id == id)
                                 .FirstOrDefaultAsync();
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            _context.Users.Update(user);

            await _context.SaveChangesAsync();

            return user;
        }
    }
}
