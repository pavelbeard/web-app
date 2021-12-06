//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Run();

using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Http;
using Microsoft.Extensions.DependencyInjection;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using web_app.Interfaces;
using web_app.Mocks;
using Microsoft.AspNetCore.Mvc;

namespace TestWebApp
{   
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ITestAllCars, TMockCars>();
            services.AddTransient<ITestCarsCategory, TMockCategory>();
            services.AddMvc(option => { option.EnableEndpointRouting = false; new MvcOptions().EnableEndpointRouting = false; });
        }

        [Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}