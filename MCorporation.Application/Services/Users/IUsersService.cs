using MCorporation.Domain.Entities.Models;

namespace MCorporation.Application.Services.Users
{
    public interface IUsersService
    {
        Task<User> GetAllUsers();
        Task<User> GetUserById( int id);
        Task<string> DeleteUser( int id);
        Task<string> UpdateUser(int id, User user);
        Task<string> CreateUser(User user);
    }
}
