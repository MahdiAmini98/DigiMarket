using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;
using DigiMarket.Domain.Entities.Carts;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.Carts
{
   public interface ICartService
   {
       ResultDto AddToCart(int productId, Guid browserId);
       ResultDto RemoveFromCart(int productId, Guid browserId);
       ResultDto<CartDto> GetMyCart(Guid browserId, int? userId);

       //سرویس های اضافه یا کم کردن محصول در صفحه سبد خرید با کمک دکمه مثبت و منفی

       ResultDto AddToCountProduct(int cartItemId);
       ResultDto LowToCountProduct(int cartItemId);
   }


   public class CartService : ICartService
   {
       private IDigiMarketContext _context;

       public CartService(IDigiMarketContext context)
       {
           _context = context;
       }
       public ResultDto AddToCart(int productId, Guid browserId)
       {

           var cart = _context.Carts.Where(p => p.BrowserId == browserId && p.Finished == false).FirstOrDefault();
           if (cart == null)
           {
               Cart newCart = new Cart()
               {
                   Finished = false,
                   BrowserId = browserId,
               };
               _context.Carts.Add(newCart);
               _context.SaveChanges();
               cart = newCart;
           }


           var product = _context.Products.Find(productId);

           var cartItem = _context.CartItems.Where(p => p.ProductId == productId && p.CartId == cart.KeyId).FirstOrDefault();
           if (cartItem != null)
           {
               cartItem.Count++;
           }
           else
           {
               CartItem newCartItem = new CartItem()
               {
                   Cart = cart,
                   Count = 1,
                   Price = product.Price,
                   Product = product,

               };
               _context.CartItems.Add(newCartItem);
               _context.SaveChanges();
           }

           return new ResultDto()
           {
               IsSuccess = true,
               Message = $"محصول  {product.ProductImages} با موفقیت به سبد خرید شما اضافه شد ",
           };
        }

       public ResultDto RemoveFromCart(int productId, Guid browserId)
       {
           var cartitem = _context.CartItems.Where(p => p.Cart.BrowserId == browserId).FirstOrDefault();
           if (cartitem != null)
           {
               cartitem.IsRemoved = true;
               cartitem.RemoveTime = DateTime.Now;
               _context.SaveChanges();
               return new ResultDto
               {
                   IsSuccess = true,
                   Message = "محصول از سبد خرید شما حذف شد"
               };

           }
           else
           {
               return new ResultDto
               {
                   IsSuccess = false,
                   Message = "محصول یافت نشد"
               };
           }

        }

       public ResultDto<CartDto> GetMyCart(Guid browserId ,int? userId)
       {
           try
           {
               var cart = _context.Carts
                   .Include(p => p.Items)
                   .ThenInclude(p => p.Product)
                   .ThenInclude(p => p.ProductImages)
                   .Where(p => p.BrowserId == browserId && p.Finished == false)
                   .OrderByDescending(p => p.KeyId)
                   .FirstOrDefault();


               if (cart == null)
               {
                   return new ResultDto<CartDto>()
                   {
                       Data = new CartDto()
                       {
                           CartItem = new List<CartItemDto>()
                       },
                       IsSuccess = false,
                   };
               }

               if (userId != null)
               {
                   var user = _context.Users.Find(userId);
                   cart.Users = user;
                   _context.SaveChanges();
               }



               return new ResultDto<CartDto>()
               {
                   Data = new CartDto()
                   {
                       CartId = cart.KeyId,
                       ProductCount = cart.Items.Count(),
                       SumPrice = cart.Items.Sum(p => p.Price * p.Count),
                       CartItem = cart.Items.Select(p => new CartItemDto
                       {
                           Count = p.Count,
                           Price = p.Price,
                           ProductName = p.Product.ProductName,
                           Id = p.KeyId,
                           Image = p.Product?.ProductImages?.FirstOrDefault()?.Src ?? "",
                       }).ToList(),
                   },
                   IsSuccess = true,
               };
           }
           catch (Exception ex)
           {

               throw;
           }


        }

        public ResultDto AddToCountProduct(int cartItemId)
       {
           var cartItem = _context.CartItems.Find(cartItemId);
           cartItem.Count++;
           _context.SaveChanges();

           return new ResultDto()
           {
               IsSuccess = true,
               Message = "تعداد محصول مورد نظر در سبد خرید یکی اضافه شد"
           };
       }

       public ResultDto LowToCountProduct(int cartItemId)
       {
           var cartItem = _context.CartItems.Find(cartItemId);

           if (cartItem.Count <= 1)
           {

               return new ResultDto()
               {
                   IsSuccess = false,
                   Message = "تعداد محصول مورد نظر در سبد خرید  نمی تواند صفر شود"
               };
           }

            cartItem.Count--;
           _context.SaveChanges();

         
           return new ResultDto()
           {
               IsSuccess = true,
               Message = "تعداد محصول مورد نظر در سبد خرید یکی کم شد"
           };
           
        }
   }

   public class CartDto
   {
       public int CartId { get; set; }
       public List<CartItemDto> CartItem { get; set; }
       //تعداد محصولات متمایز  (محصولاتی که از یک نوع نیستند و باهم تفاوت دارند مثلا لب تاپ اپل و لپ تاب سامسونگ) درسبد خرید
       public int ProductCount { get; set; }
       //جمع کل قیمت همه محصولات موجود در سبد خرید
       public int SumPrice { get; set; }
   }
   public class CartItemDto
   {
       public int Id { get; set; }
       public string ProductName { get; set; }
       public string Image { get; set; }
       public int Price { get; set; }
       public int Count { get; set; }


   }
}
