using MCorporation.Domain.Entities.Models;

namespace MCorporation.Application.Services.Users
{
    public class UsersService : IUsersService
    {
        public async Task<string> CreateUser(User user)
        {
            return "Ishlayapti";
        }

        public async Task<string> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<string> UpdateUser(int id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
