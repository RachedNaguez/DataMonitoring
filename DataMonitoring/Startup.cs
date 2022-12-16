using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DataMonitoring.Data;
using DataMonitoring.Filters;
using DataMonitoring.Models;
using System;
using DataMonitoring.Hubs;
using DataMonitoring.SubscribeTableDependencies;
using DataMonitoring.MiddlewareExtensions;

namespace DataMonitoring
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
            services.AddSingleton<IAuthorizationPolicyProvider, PermissionPolicyProvider>();
            services.AddScoped<IAuthorizationHandler, PermissionAuthorizationHandler>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();
            ///
            services.AddDbContext<ProductContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ProductContext") ?? throw new InvalidOperationException("Connection string 'ProductContext' not found.")));
            services.AddDbContext<CustomersContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("CustomersContext") ?? throw new InvalidOperationException("Connection string 'CustomersContext' not found.")));
            ///


            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();

            services.Configure<SecurityStampValidatorOptions>(options =>
            {
                options.ValidationInterval = TimeSpan.Zero;
            });

            services.AddControllersWithViews();
            services.AddSignalR();
            // DI
            services.AddSingleton<DashboardHub>();
            services.AddSingleton<SubscribeProductTableDependency>();
            services.AddSingleton<SubscribeSaleTableDependency>();
            services.AddSingleton<SubscribeCustomerTableDependency>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            


            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                    name: "default",
                    "{controller=Dashboard}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                ///
                endpoints.MapHub<DashboardHub>("/dashboardHub");
               
            });
            app.UseSqlTableDependency<SubscribeProductTableDependency>(Configuration.GetConnectionString("DefaultConnection"));
            app.UseSqlTableDependency<SubscribeSaleTableDependency>(Configuration.GetConnectionString("DefaultConnection"));
            app.UseSqlTableDependency<SubscribeCustomerTableDependency>(Configuration.GetConnectionString("DefaultConnection"));


        }
    }
}
