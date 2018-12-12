using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SeedAPI.Models.Context;
using SeedAPI.ViewModels;

namespace SeedAPI.Web.API.Configs
{
    public class DBContextConfig
    {
        public static void Initialize(IConfiguration configuration, IHostingEnvironment env, IServiceProvider svp)
        {
            var optionsBuilder = new DbContextOptionsBuilder();

            if (env.IsDevelopment()) optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            else if (env.IsStaging()) optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            else if (env.IsProduction()) optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            var context = new ApplicationContext(optionsBuilder.Options);

            if (context.Database.EnsureCreated())
            {
                IUserMap service = svp.GetService(typeof(IUserMap)) as IUserMap;
                new DBInitializeConfig(service).DataTest();
            }
        }
        public static void Initialize(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }

    public class DBInitializeConfig
    {
        private IUserMap userMap;

        public DBInitializeConfig(IUserMap _userMap)
        {
            userMap = _userMap;
        }

        public void DataTest()
        {
            Users();
        }

        private void Users()
        {
            userMap.Create(new UserViewModel() { id = 1, name = "Pablo" });
            userMap.Create(new UserViewModel() { id = 2, name = "Diego" });
        }
    }
}