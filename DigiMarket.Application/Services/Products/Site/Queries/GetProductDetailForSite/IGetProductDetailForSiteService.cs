using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.Products.Site.Queries.GetProductDetailForSite
{
   public interface IGetProductDetailForSiteService
   {
       ResultDto<ProductDetailDto> Execute(int Id);
   }


   public class GetProductDetailForSiteService : IGetProductDetailForSiteService
   {
       private IDigiMarketContext _context;

       public GetProductDetailForSiteService(IDigiMarketContext context)
       {
           _context = context;
       }
       public ResultDto<ProductDetailDto> Execute(int Id)
       {

           var product = _context.Products
               .Include(p => p.Category)
               .ThenInclude(p => p.ParentCategory)
               .Include(p => p.ProductFeatures)
               .Include(p => p.ProductImages).FirstOrDefault(p => p.ProductId == Id);

           if (product == null)
           {
               return new ResultDto<ProductDetailDto>()
               {
                   IsSuccess = false,
                   Message = "محصول مورد نظر موجود نیست"
               };
           }


           product.ViewCount++;
           _context.SaveChanges();

           Random random = new Random();

           return new ResultDto<ProductDetailDto>()
           {
               Data = new ProductDetailDto()
               {
                   ProductId = product.ProductId,
                   ProductName = product.ProductName,
                   Brand = product.Brand,
                   Category = $"{product.Category.CategoryName} - {product.Category.ParentCategory.CategoryName}",
                   Description = product.Description,
                   Price = product.Price,
                   Star = random.Next(1, 5),
                   Inventory = product.Inventory,
                   FeaturesList = product.ProductFeatures.Select(p => new ProductDetailFeaturesDto
                   {
                       DisplayName = p.DisPlayName,
                       Value = p.Value
                   }).ToList(),
                   ImagesList = product.ProductImages.Select(p => new ProductDetailImagesDto()
                   {
                       ProductId = p.ProductId,
                       Src = p.Src
                   }).ToList()
               },
               IsSuccess = true,
               Message = "عملیات موفقیت آمیز بود"
           };
       }
   }

   public class ProductDetailDto
   {
       public int ProductId { get; set; }
       public string ProductName { get; set; }
       public string Brand { get; set; }
       public string Category { get; set; }
       public string Description { get; set; }
       public int Price { get; set; }
       public int Star { get; set; }
       public int Inventory { get; set; }
       public List<ProductDetailFeaturesDto> FeaturesList { get; set; }
       public List<ProductDetailImagesDto> ImagesList { get; set; }
   }

   public class ProductDetailFeaturesDto
   {
       public string DisplayName { get; set; }
       public string Value { get; set; }
   }

   public class ProductDetailImagesDto
   {
       public int ProductId { get; set; }
       public string Src { get; set; }
       
   }
}
