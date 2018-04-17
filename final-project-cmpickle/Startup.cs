using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using final_project_cmpickle.Services;
using final_project_cmpickle.Models.Database;
using final_project_cmpickle.Models.MemberSystem;
using final_project_cmpickle.Repositories;
using final_project_cmpickle.Models.Domain;

namespace final_project_cmpickle
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
            // Add Entity Framework services to the services container.
            services.AddEntityFrameworkMySql()
                .AddDbContext<MySqlDbContext>(options => options.UseMySql("Server=67.205.183.11;Database=cmpickle;Uid=cmpickle;Pwd=Photog42;"));
                // .AddDbContext<MySqlDbContext>(options => options.UseMySql("Server=localhost;Database=cmpickle;Uid=root;Pwd=Pawnshop1976;"));

            // Add Identity services to the services container
            services.AddIdentity<MyIdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<MySqlDbContext>()
                .AddDefaultTokenProviders();
            
            // Add application services
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<IUserRepository<MyIdentityUser>, UserRepository>();
            services.AddTransient<IUserManager<MyIdentityUser>, MyIdentityUserManager<MyIdentityUser>>();
            services.AddTransient<ISignInManager<MyIdentityUser>, MySignInManager<MyIdentityUser>>();
            services.AddTransient<IIdentityUser, MyIdentityUser>();
            services.AddTransient<IVendorRepository<Vendor>, VendorRepository>();
            services.AddTransient<IProductRepository<Product>, ProductRepository>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
