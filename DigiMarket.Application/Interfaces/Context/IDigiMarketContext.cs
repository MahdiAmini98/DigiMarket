using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DigiMarket.Domain.Entities.Carts;
using DigiMarket.Domain.Entities.Finances;
using DigiMarket.Domain.Entities.Home_Page_Images;
using DigiMarket.Domain.Entities.Orders;
using DigiMarket.Domain.Entities.Prouduct;
using DigiMarket.Domain.Entities.Slider;
using DigiMarket.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Interfaces.Context
{
  public  interface IDigiMarketContext
    {

         public DbSet<User> Users { get; set; }
         public DbSet<Role> Roles { get; set; }
         public  DbSet<UserRole> UserRoles { get; set; }
         public DbSet<Category> Categories { get; set; }
         public DbSet<Product> Products { get; set; }
         public DbSet<ProductImage> ProductImages { get; set; }
         public DbSet<ProductFeatures> ProductFeatures { get; set; }
         public DbSet<Slider> Sliders { get; set; }
         public DbSet<HomePageImages> HomePageImages { get; set; }
         public DbSet<Cart> Carts { get; set; }
         public DbSet<CartItem> CartItems { get; set; }
         public DbSet<RequestPay> RequestPays { get; set; }
         public DbSet<Order> Orders { get; set; }
         public DbSet<OrderDetail> OrderDetails { get; set; }


         int SaveChanges(bool acceptAllChangesOnSuccess);
         int SaveChanges();
         Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
         Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
