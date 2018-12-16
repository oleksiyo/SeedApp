using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SeedAPI.Maps;
using SeedAPI.Models.Context;
using SeedAPI.Repositories;

namespace SeedAPI.Web.API.Configs
{
    public class DBContextConfig
    {
        static string connection = @"Server=(localdb)\MSSQLLocalDB;Database=Seed;User ID=ByggUser;Password=ByggPassword";

        public static void Initialize(IServiceCollection services, IConfiguration configuration)
        {
            //IUserMaper service = svp.GetService(typeof(IUserMaper)) as IUserMaper;
            //new DBInitializeConfig(service).DataTest();

            //var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            //var context = new ApplicationContext(optionsBuilder.Options);

            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Seed;User ID=ByggUser;Password=ByggPassword"));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}