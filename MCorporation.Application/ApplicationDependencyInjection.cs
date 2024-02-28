using MCorporation.Application.Services.Auth;
using MCorporation.Application.Services.Users;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MCorporation.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplication(IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUsersService, UsersService>();
            return services;
        }
    }
}
