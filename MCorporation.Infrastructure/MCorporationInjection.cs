using MCorporation.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MCorporation.Infrastructure
{
    public static class MCorporationInjection
    {
        public static IServiceCollection AddInfrastruction(this IServiceCollection service, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            service.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });
            return service;
        }
    }
}
