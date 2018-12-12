using Microsoft.Extensions.DependencyInjection;
using SeedAPI.Maps;
using SeedAPI.Models.Context;
using SeedAPI.Repositories;
using SeedAPI.Services;

namespace SeedAPI.Web.API.Configs
{
    public class DependencyInjectionConfig
    {
        public static void AddScope(IServiceCollection services)
        {
            services.AddScoped<IApplicationContext, ApplicationContext>();

            services.AddScoped<IUserMap, UserMap>();

            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}