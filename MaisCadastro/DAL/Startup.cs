using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaisCadastros.UI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MaisCadastros.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connString = Configuration
                   .GetConnectionString("Asp_Net_MVC_CS");

            services
                .AddDbContext<DalStandard.MaisCadastrosContext>
                    (options => options.UseSqlServer(connString));

            services
                .AddIdentity<DAL.ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<DalStandard.MaisCadastrosContext>()
                .AddDefaultTokenProviders();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            // Dependency Injection of our Repository
            services.AddScoped(typeof(DalStandard.Repositories.IRepository<>), typeof(DalStandard.Repositories.GenericRepository<>));

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
