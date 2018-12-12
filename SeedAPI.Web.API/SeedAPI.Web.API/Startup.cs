using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SeedAPI.Web.API.Configs;

namespace SeedAPI.Web.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        private IConfigurationRoot configurationRoot;
        private readonly IConfiguration configuration;
        private readonly IHostingEnvironment env;

        public Startup(IHostingEnvironment env, IConfiguration configuration)
        {
            this.configuration = configuration;
            this.env = env;
            var builder = new ConfigurationBuilder().SetBasePath(env.ContentRootPath)
                .AddJsonFile("config.json", true, false)
                .AddXmlFile("config.xml", true)
                .AddEnvironmentVariables();
            configurationRoot = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            DependencyInjectionConfig.AddScope(services);
            JwtTokenConfig.AddAuthentication(services, configuration);
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}