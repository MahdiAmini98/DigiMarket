using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Domain.Entities.Carts;
using DigiMarket.Domain.Entities.Finances;
using DigiMarket.Domain.Entities.Home_Page_Images;
using DigiMarket.Domain.Entities.Orders;
using DigiMarket.Domain.Entities.Prouduct;
using DigiMarket.Domain.Entities.Slider;
using DigiMarket.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Persistence.Context
{
 public class DigiMarketContext:DbContext , IDigiMarketContext
    {


     public DigiMarketContext(DbContextOptions options) :base(options)
     {
         
     }


     public DbSet<User> Users { get; set; }
     public DbSet<Role> Roles { get; set; }
     public DbSet<UserRole> UserRoles { get; set; }
     public DbSet<Category> Categories { get; set; }
     public DbSet<Product> Products { get; set; }
     public DbSet<ProductImage> ProductImages { get; set; }
     public DbSet<ProductFeatures> ProductFeatures{ get; set; }
     public DbSet<Slider> Sliders { get; set; }
     public DbSet<HomePageImages> HomePageImages { get; set; }
     public DbSet<Cart> Carts { get; set; }
     public DbSet<CartItem> CartItems { get; set; }
     public DbSet<RequestPay> RequestPays { get; set; }
     public DbSet<Order> Orders { get; set; }
     public DbSet<OrderDetail> OrderDetails { get; set; }


     #region On Model Creating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region seed for roles

            modelBuilder.Entity<Role>().HasData(new Role()
            {
                RoleId = 1,
                RoleTittle = nameof(Common.Roles.UserRoles.Admin)
            });
            modelBuilder.Entity<Role>().HasData(new Role
            {
                RoleId = 2,
                RoleTittle = nameof(Common.Roles.UserRoles.Operator)
            });
            modelBuilder.Entity<Role>().HasData(new Role()
            {
                RoleId = 3,
                RoleTittle = nameof(Common.Roles.UserRoles.Customer)
            });

            #endregion

            #region Uniq Email
            //جهت جلوگیری از ثبت نام  ایمیل تکراری

            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();

            #endregion


            #region CasCade Eror From Order Table

            modelBuilder.Entity<Order>()
                .HasOne(p => p.User)
                .WithMany(p => p.Orders)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(p => p.RequestPay)
                .WithMany(p => p.Orders)
                .OnDelete(DeleteBehavior.NoAction);

            #endregion
            #region Has Query Filter

            // با این خط کد کاربرانی که حذف میشوند در برنامه نمایش داده نمی شوند
            modelBuilder.Entity<User>().HasQueryFilter(u => !u.IsRemoved);
         
            modelBuilder.Entity<Category>().HasKey(c => c.CategoryId);
            modelBuilder.Entity<Category>().HasQueryFilter(u => !u.IsRemoved);

            modelBuilder.Entity<Product>().HasKey(p => p.ProductId);
            modelBuilder.Entity<Product>().HasQueryFilter(p => !p.IsRemoved);

            modelBuilder.Entity<ProductFeatures>().HasKey(p => p.ProductFeaturesId);
            modelBuilder.Entity<ProductFeatures>().HasQueryFilter(p => !p.IsRemoved);

            modelBuilder.Entity<ProductImage>().HasKey(p => p.ProductImageId);
            modelBuilder.Entity<ProductImage>().HasQueryFilter(p => !p.IsRemoved);

            modelBuilder.Entity<Slider>().HasQueryFilter(p => !p.IsRemoved);

            modelBuilder.Entity<HomePageImages>().HasQueryFilter(p => !p.IsRemoved);

            modelBuilder.Entity<Cart>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<CartItem>().HasQueryFilter(p => !p.IsRemoved);

            modelBuilder.Entity<RequestPay>().HasQueryFilter(p => !p.IsRemoved);

            modelBuilder.Entity<Order>().HasQueryFilter(p => !p.IsRemoved);
            modelBuilder.Entity<OrderDetail>().HasQueryFilter(p => !p.IsRemoved);




            #endregion
            base.OnModelCreating(modelBuilder);
        }


        #endregion
    }
}
