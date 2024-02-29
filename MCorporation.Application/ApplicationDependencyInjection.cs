using MCorporation.Application.Services.Auth;

using MCorporation.Application.Services.Users;
using Microsoft.Extensions.DependencyInjection;

namespace MCorporation.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUsersService, UsersService>();

            return services;
        }
    }
}
