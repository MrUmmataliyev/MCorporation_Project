using MCorporation.Domain.Entities.ForToken;


namespace MCorporation.Application.Services.Auth
{
    public interface IAuthService
    {
        Task<string> GenerateToken(string login, string password);
    }
}
