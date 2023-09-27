using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Model.Classes;
using Model.Data;
using MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC
{
    // Microsoft.VisualStudio.Web.CodeGeneration.Design v. 5.0
    // Microsoft.AspNetCore.Identity.UI 5.0.17
    // If you want to use or scaffold them with Visual Studio:
    // dotnet tool install -g dotnet-aspnet-codegenerator --version 5.0.0

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
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddScoped<HobbyContext, HobbyContext>();
            services.AddScoped<MessageContext, MessageContext>();
            services.AddScoped<IdentityContext, IdentityContext>();

            // Default for controllers is scoped!
            //services.AddScoped(typeof(MVCDbContext));
            services.AddScoped<IEmailSender, MailKitEmailSender>();

            // Add your custom password validator before adding Identity otherwise you will have both of them!
            services.AddScoped<IPasswordValidator<User>, CustomPasswordValidator<User>>();

            services.AddDbContext<MVCDbContext>(options =>
                options.UseSqlServer(
                    "Server=LAPTOP-AT94SBBO\\SQLEXPRESS;Database=MVCProjectTemplateDb;Trusted_Connection=True;"
                    //Configuration.GetConnectionString("DefaultConnection")
                    ));

            services.AddIdentity<User, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<MVCDbContext>()
                .AddDefaultTokenProviders();

            // Add custom binders at the beginning!
            //services.AddControllers(options =>
            //{
            //    options.ModelBinderProviders.Insert(0, new MessageEntityBinderProvider());
            //});


            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 5;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;

                // Log in required.
                options.SignIn.RequireConfirmedAccount = false; // default
                options.SignIn.RequireConfirmedEmail = false; // default
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            services.Configure<MailKitEmailSenderOptions>(options =>
            {
                options.HostAddress = Configuration["ExternalProviders:MailKit:SMTP:Address"];
                options.HostPort = Convert.ToInt32(Configuration["ExternalProviders:MailKit:SMTP:Port"]);
                options.HostUsername = Configuration["ExternalProviders:MailKit:SMTP:Account"];
                options.HostPassword = Configuration["ExternalProviders:MailKit:SMTP:Password"];
                options.SenderEmail = Configuration["ExternalProviders:MailKit:SMTP:SenderEmail"];
                options.SenderName = Configuration["ExternalProviders:MailKit:SMTP:SenderName"];
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }

    }
}
