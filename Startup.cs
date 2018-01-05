using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using kostiSrmApi.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Microsoft.EntityFrameworkCore;

// https://pioneercode.com/post/authentication-in-a-asp-dot-net-core-api-part-1-identity-access-denied
// https://damienbod.com/2016/01/11/asp-net-5-with-postgresql-and-entity-framework-7/

// https://docs.microsoft.com/ko-kr/aspnet/core/data/ef-mvc/migrations
// https://docs.microsoft.com/en-us/aspnet/core/publishing/linuxproduction?tabs=aspnetcore2x
// https://blog.elmah.io/appsettings-in-aspnetcore/

// Secure Web Api in asp.net core
// http://www.blinkingcaret.com/2017/09/06/secure-web-api-in-asp-net-core/

// To Login
// https://medium.com/@lugrugzo/asp-net-core-2-0-webapi-jwt-authentication-with-identity-mysql-3698eeba6ff8


// to migration
/*
1. dotnet ef migrations add InitialCreate (ef migrations remov)
2. dotnet ef database update (dotnet ef database drop)
*/

namespace kostiSrmApi
{
    public class Startup
    {
        
        public IConfigurationRoot Configuration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile("appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var appSettings = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettings);

            var connection = appSettings["ConnectionStrings:DataAccessPostgreSqlProvider"];
            services.AddDbContext<kostiSrmContext>(options => options.UseNpgsql(connection));

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
