using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catinc.Models.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using catinc.Models.Domain;
using catinc.Repositories;
using catinc.Models.MemberSystem;
using catinc.Services;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;

namespace catinc
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
            services.AddEntityFrameworkMySql()
                // .AddDbContext<MySqlDbContext>(options => options.UseMySql("Server=localhost;Database=cat_inc;Uid=root;Pwd=Pawnshop1976;"));
                .AddDbContext<MySqlDbContext>(options => options.UseMySql("Server=67.205.183.11;Database=cmpickle;Uid=cmpickle;Pwd=Photog42;"));
            
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

            services.AddMvc(options =>
            {
                options.OutputFormatters.Clear();
                options.OutputFormatters.Add(new JsonOutputFormatter(new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                }, ArrayPool<char>.Shared));
            });
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
