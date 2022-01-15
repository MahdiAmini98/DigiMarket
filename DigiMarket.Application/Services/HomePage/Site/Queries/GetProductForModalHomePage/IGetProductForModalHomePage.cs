using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Services.Products.Site.Queries.GetProductForSite;
using DigiMarket.Common.Dto;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.HomePage.Site.Queries.GetProductForModalHomePage
{
   public interface IGetProductForModalHomePage
   {
       ResultDto<List<ProductForSiteDto>> Execute();
   }


   public class GetProductForModalHomePage : IGetProductForModalHomePage
   {
       private IDigiMarketContext _context;

       public GetProductForModalHomePage(IDigiMarketContext context)
       {
           _context = context;
       }
       public ResultDto<List<ProductForSiteDto>> Execute()
       {

         


            //productquery = productquery.Include(p => p.Category);

            var productquery =_context.Products.Include(p=>p.ProductImages)
               .Where(p => p.Category.CategoryId == 24 || p.Category.ParentCategory.CategoryId == 24 ||
                           p.Category.CategoryId == 28 || p.Category.ParentCategory.CategoryId == 28 ||
                           p.Category.CategoryId == 1024 || p.Category.ParentCategory.CategoryId == 1024 ||
                           p.Category.CategoryId == 25 || p.Category.ParentCategory.CategoryId == 25).Select(p =>
                   new ProductForSiteDto()
                   {
                       ImageSrc = p.ProductImages.FirstOrDefault().Src,
                       Name = p.ProductName,
                       Price = p.Price,
                       ProductId = p.ProductId,

                   }).ToList();


           return new ResultDto<List<ProductForSiteDto>>()
           {
               Data = productquery,
               Message = "عملیات موفقیت آمیز بود",
               IsSuccess = true
           };

       }
   }
}
