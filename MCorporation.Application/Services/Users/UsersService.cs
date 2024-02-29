using MCorporation.Domain.Entities.Models;
using MCorporation.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace MCorporation.Application.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext _context;

        public UsersService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> CreateUser(User user)
        {
            var newUser = new User
            {
                FullName = user.FullName,
                Login = user.Login,
                Password = user.Password,
                Role = user.Role,
            };
            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();
            return "Created";
            
        }

        










        public async Task<string> DeleteUser(int id)
        {
            var user = _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (user != null)
            {
                _context.Users.Remove(user.Result);
                await _context.SaveChangesAsync();
                return "Deleted";
            }
            return "User not found";
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
            
        }

        public async Task<User> GetUserById(int id)
        {
           var res = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            return res;
        }

        public async Task<string> UpdateUser(int id, User user)
        {
            var u = _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (u.Result != null)
            {
                u.Result.FullName=user.FullName;
                u.Result.Login=user.Login;
                u.Result.Password=user.Password;
                u.Result.Role=user.Role;



                await _context.SaveChangesAsync();
                return "Updated";
            }
            return "User not found";
        }
    }
}
