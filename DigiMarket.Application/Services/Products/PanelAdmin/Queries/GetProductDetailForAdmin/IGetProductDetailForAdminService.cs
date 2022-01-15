using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;
using DigiMarket.Domain.Entities.Prouduct;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.Products.Queries.GetProductDetailForAdmin
{
   public interface IGetProductDetailForAdminService
   {
       ResultDto<ProductDetailDto> Execute(int Id);
   }

   public class GetProductDetailForAdminService : IGetProductDetailForAdminService
   {
       private IDigiMarketContext _context;

       public GetProductDetailForAdminService(IDigiMarketContext context)
       {
           _context = context;
       }
       public ResultDto<ProductDetailDto> Execute(int Id)
       {
           var product = _context.Products.Include(p => p.Category)
               .ThenInclude(p => p.ParentCategory)
               .Include(p => p.ProductFeatures)
               .Include(p => p.ProductImages)
               .Where(p => p.ProductId == Id).FirstOrDefault();

           return new ResultDto<ProductDetailDto>()
           {
               Data = new ProductDetailDto()
               {
                   ProductId = product.ProductId,
                   Name = product.ProductName,
                   Category = GetCategory(product.Category),
                   Brand = product.Brand,
                   Description = product.Description,
                   Price = product.Price,
                   Inventory = product.Inventory,
                   Displayed = product.Displayed,
                   ProductDetailFeature = product.ProductFeatures.ToList().Select(p => new ProductDetailFeatureDto
                   {
                       Id = p.ProductFeaturesId,
                       DisplayName = p.DisPlayName,
                       Value = p.Value
                   }).ToList(),
                   ProductDetailImage = product.ProductImages.ToList().Select(p => new ProductDetailImageDto()
                   {
                       Id = p.ProductImageId,
                       Src = p.Src,
                   }).ToList(),
               },
               IsSuccess = true,
               Message = "عملیات با موفقیت انجام شد"

           };
       }
       

       

       private string GetCategory(Category category)
       {
          string result =   category.ParentCategory!=null ? $"{ category.ParentCategory.CategoryName} - " :"";
          return result += category.CategoryName;
       }
   }

   public class ProductDetailDto
   {
       public int ProductId { get; set; }
       public string Name { get; set; }
       public string Category { get; set; }
       public string Brand { get; set; }
       public string Description { get; set; }
       public int Price { get; set; }
       public int Inventory { get; set; }
       public bool Displayed { get; set; }
       public List<ProductDetailFeatureDto> ProductDetailFeature { get; set; }
       public List<ProductDetailImageDto> ProductDetailImage { get; set; }
   }

   public class ProductDetailFeatureDto
   {
       public int Id { get; set; }
       public string DisplayName { get; set; }
       public string Value { get; set; }
   }

   public class ProductDetailImageDto
   {
       public int Id { get; set; }
       public string Src { get; set; }

   }
}
