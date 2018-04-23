﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catinc.Models.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using catinc.Models.Domain;

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
                .AddDbContext<MySqlDbContext>(options => options.UseMySql("Server=localhost;Database=cat_inc;Uid=root;Pwd=Pawnshop1976;"));
            
            // Add Identity services to the services container
            services.AddIdentity<MyIdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<MySqlDbContext>()
                .AddDefaultTokenProviders();
                
            // services.AddTransient<IIdentityUser, MyIdentityUser>();

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
