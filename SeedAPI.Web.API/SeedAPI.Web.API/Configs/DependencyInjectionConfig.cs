using Microsoft.Extensions.DependencyInjection;
using SeedAPI.Maps;
using SeedAPI.Models.Models;
using SeedAPI.Repositories;
using SeedAPI.Services;

namespace SeedAPI.Web.API.Configs
{
    public class DependencyInjectionConfig
    {
        public static void AddScope(IServiceCollection services)
        {
            services.AddScoped<IUserMapper, UserMapper>();

            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRepository<User>, Repository<User>>();
        }
    }
}