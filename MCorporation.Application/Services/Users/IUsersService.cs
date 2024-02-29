using MCorporation.Domain.Entities.Models;

namespace MCorporation.Application.Services.Users
{
    public interface IUsersService
    {
        Task<User> GetAllUsers();
        Task<User> GetUserById();
        Task<string> DeleteUser();
        Task<string> UpdateUser();
        Task<string> CreateUser();
    }
}
