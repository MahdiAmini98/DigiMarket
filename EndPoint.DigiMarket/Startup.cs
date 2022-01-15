using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Interfaces.FacadPatterns;
using DigiMarket.Application.Interfaces.FacadPatterns.CommonFacad.Site;
using DigiMarket.Application.Interfaces.FacadPatterns.FinancesFacad.Site;
using DigiMarket.Application.Interfaces.FacadPatterns.HomePage.PanelAdmin;
using DigiMarket.Application.Interfaces.FacadPatterns.HomePage.Site;
using DigiMarket.Application.Interfaces.FacadPatterns.OrderFacad.PanelAdmin;
using DigiMarket.Application.Interfaces.FacadPatterns.OrderFacad.Site;
using DigiMarket.Application.Interfaces.FacadPatterns.ProductFacad.PanelAdmin;
using DigiMarket.Application.Interfaces.FacadPatterns.ProductFacad.Site;
using DigiMarket.Application.Interfaces.FacadPatterns.SliderFacad.PanelAdmin;
using DigiMarket.Application.Interfaces.FacadPatterns.SliderFacad.Site;
using DigiMarket.Application.Services.Carts;
using DigiMarket.Application.Services.Common.Site.FacadPattern;
using DigiMarket.Application.Services.Common.Site.Queries.GetMenuItem;
using DigiMarket.Application.Services.Finances.Site.FacadPattern;
using DigiMarket.Application.Services.HomePage.PanelAdmin.FacadPattern;
using DigiMarket.Application.Services.HomePage.Site.FacadPattern;
using DigiMarket.Application.Services.Orders.PanelAdmin.FacadPattern;
using DigiMarket.Application.Services.Orders.Site.FacadPattern;
using DigiMarket.Application.Services.Products.PanelAdmin.FasadPattern;
using DigiMarket.Application.Services.Products.Site.FasadPattern;
using DigiMarket.Application.Services.Sliders.PanelAdmin.FacadPattern;
using DigiMarket.Application.Services.Sliders.Site.FacadPattern;
using DigiMarket.Application.Services.Users.Command.CreateUser;
using DigiMarket.Application.Services.Users.Command.EditUser;
using DigiMarket.Application.Services.Users.Command.LoginUser;
using DigiMarket.Application.Services.Users.Command.RemoveUser;
using DigiMarket.Application.Services.Users.Command.StatusChangeUser;
using DigiMarket.Application.Services.Users.Queries.GetRoles;
using DigiMarket.Application.Services.Users.Queries.GetUsers;
using DigiMarket.Common.Roles;
using DigiMarket.Domain.Entities.Users;
using DigiMarket.Persistence.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using DigiMarket.Application.Interfaces.FacadPatterns.FinancesFacad.PanelAdmin;
using DigiMarket.Application.Services.Finances.PanelAdmin.FacadPattern;

namespace EndPoint.DigiMarket
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

            services.AddControllersWithViews();


            #region Service Authorization


            // ما در برنامه خود نقش های مختلفی داریم
            //   می توانیمم برای اجبار کردن لاگین کاربران استفاده کنیم  Authorization و همینطور از اتریبیوت
            // Authorization استفاده می کنیم در کنترلر ها کدام نقش ها میتواننند  Authorization حال ما با استفاده از دستورات پایین میتوانیم مشخص کنیم زمانی که از اتریبیتوت

            services.AddAuthorization(options =>
            {
                options.AddPolicy(UserRoles.Admin, policy => policy.RequireRole(UserRoles.Admin));
                options.AddPolicy(UserRoles.Operator, policy => policy.RequireRole(UserRoles.Operator));
                options.AddPolicy(UserRoles.Customer, policy => policy.RequireRole(UserRoles.Customer));
            });
                

            #endregion

            #region Service Authentication

            services.AddAuthentication(options =>
            {

                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;


            }).AddCookie(options =>
            {
                options.LoginPath = new PathString("/Authentication/Signin");
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5.0);
                options.AccessDeniedPath = new PathString("/Authentication/AccessDenied");


            });

            #endregion

            #region Services

            #region User Services
            services.AddScoped<ILoginUserService, LoginUserService>();
            services.AddScoped<IEditUserService, EditUserService>();
            services.AddScoped<IChangeUserService, ChangeUserService>();
            services.AddScoped<IRemoveUserService, RemoveUserService>();
            services.AddScoped<IGetRolesService, GetRolesService>();
            services.AddScoped<ICreateUserService, CreateUserService>();
            services.AddScoped<IDigiMarketContext, DigiMarketContext>();
            services.AddScoped<IGetUsersService, GetUsersService>();

            #endregion

            #region Facad Inject

            //Order
            services.AddScoped<IOrderFacad_Site, OrderFacad_Site>();
            services.AddScoped<IOrderFacad_Admin, OrderFacad_Admin>();


            //Finances
            services.AddScoped<IFinancesFacad_Site, FinancesFacad_Site>();
            services.AddScoped<IFinancesFacad_Admin, FinancesFacad_Admin>();


            //HomePage
            services.AddScoped<IHomeFacad_Admin, HomeFacad_Admin>();
            services.AddScoped<IHomeFacad_Site, HomeFacad_Site>();


            //Slider
            services.AddScoped<ISliderFacad_Admin, SliderFacad_Admin>();
            services.AddScoped<ISliderFacad_Site, SliderFacad_Site>();

            //Product
            services.AddScoped<IProductFacad_Admin, ProductFacad_Admin>();
            services.AddScoped<IProductFasad_Site, ProductFasad_Site>();
            //Common
            services.AddScoped<ICommonFacad_Site , CommonFacad_Site>();
            #endregion

            #region Cart

            services.AddScoped<ICartService, CartService>();

            #endregion

            #endregion

            #region DB Context

            services.AddEntityFrameworkSqlServer().AddDbContext<DigiMarketContext>(options =>
                options.UseSqlServer("Data Source=.; Initial Catalog=DigiMarket_DB; Integrated Security=true;"));

            #endregion 
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
            });

            //Areas-Routing
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

        }
    }

   
}
