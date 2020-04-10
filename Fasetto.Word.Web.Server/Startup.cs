using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

namespace Fasetto.Word.Web.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            IocContainer.Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add applicationDbContext to Dependency Injection
            services.AddDbContext<ApplicationDbContext>(options => 
                options.UseSqlServer(IocContainer.Configuration.GetConnectionString("DefaultConnection")));

            // AddIdentity adds cookie based authentication
            // Adds scoped classes for things like UserManager, SignInManager, PasswordHashers etc...
            // NOTE: Automatically adds the validated user from a cookie to the HTTPContext.User
            // 
            services.AddIdentity<ApplicationUser, IdentityRole>()
                // Adds UserStore and RoleStore from this context
                // That are consumed by the UserManager and RoleManager
                .AddEntityFrameworkStores<ApplicationDbContext>()
                // Adds a provider that generates unique keys and hashes for things like
                // Forgot password links, phone number verification codes etc...
                .AddDefaultTokenProviders();

            // Add JWT Authentication for api clients
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = IocContainer.Configuration["Jwt:Issuer"],
                    ValidAudience = IocContainer.Configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(IocContainer.Configuration["Jwt:SecretKey"])),
                };
            });

            // Change password policy
            services.Configure<IdentityOptions>(options =>
            {
                // Make really weak passwords possible
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;

                // Make sure users have unique emails
                options.User.RequireUniqueEmail = true;
            });

            // Change login URL and cookie info
            services.ConfigureApplicationCookie(options =>
            {
                // redirect to /login
                options.LoginPath = "/login";

                // Change cookie timeout to expire in 15 seconds
                options.ExpireTimeSpan = TimeSpan.FromSeconds(15);
            });

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            // Store instance of the DI service provider so our application can access it anywhere
            IocContainer.Provider = serviceProvider as ServiceProvider;

            // Setup Identity
            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{moreInfo?}");

                endpoints.MapControllerRoute(
                    name: "aboutPage",
                    pattern: "more", 
                    defaults: new { controller = "About", action = "TellMeMore" });
            });
        }
    }
}
