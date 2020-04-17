using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HardwareEFCore.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HardwareEFCore
{
    public class Startup
    {
        IConfiguration Configuration;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public Startup(IHostingEnvironment env)
        {
            Configuration = new ConfigurationBuilder().SetBasePath(env.ContentRootPath).AddJsonFile("appsettings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<HardwareDbContext>(options => options.UseSqlServer(Configuration["Data:HardwareDB:ConnectionString"]));

            services.AddTransient<IDriveRepository, EFDriveRepository>();
            services.AddTransient<IComputerRepository, EFComputerRepository>();
            services.AddTransient<IBuildOrderRepository, EFBuildOrderRepository>();

            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseStatusCodePages();
            //app.UseMvcWithDefaultRoute();

            app.UseSession();

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: null,
                    template: "Computer/Page{pageId}",
                    defaults: new { controller = "Computer", action = "List" }
                    );

                routes.MapRoute(
                    name: null,
                    template: "Drive/{driveInterface}/Page{pageId:int}",
                    defaults: new { controller = "Drive", action = "List" }
                    );

                routes.MapRoute(
                   name: null,
                   template: "Drive/{driveInterface}",
                   defaults: new { controller = "Drive", action = "List", pageId = 1 }
               );

                routes.MapRoute(
                    name: null,
                    template: "",
                    defaults: new { controller = "Computer", action = "List", pageId = 1 }
                );

                routes.MapRoute(name: null, template: "{controller=Computer}/{action=List}/{id?}");
            });
        }
    }
}
