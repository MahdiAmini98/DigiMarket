 using System;
using System.Collections.Generic;
 using System.Diagnostics;
 using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common;
using DigiMarket.Common.Dto;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.Products.Site.Queries.GetProductForSite
{
   public interface IGetProductForSiteService
   {
       ResultDto<ResultProductForSiteDtoDto> Execute(Ordering ordering, string? searchKey ,int? catId,int page, int pageSize);
    }

    public class GetProductForSiteService : IGetProductForSiteService
    {
        private IDigiMarketContext _context;

        public GetProductForSiteService(IDigiMarketContext context)
        {
            _context = context;
        }
        public ResultDto<ResultProductForSiteDtoDto> Execute(Ordering ordering, string? searchKey , int? catId,int page , int pageSize)
        {
            int totalRow = 0;

            var productquery = _context.Products.Include(p => p.ProductImages)
                .AsQueryable();

            if (catId != null)
            {
                productquery = productquery.Where(p => p.CategoryId == catId || p.Category.ParentId==catId).AsQueryable();
            }




            if (!string.IsNullOrWhiteSpace(searchKey))
            {
                productquery = productquery.Where(p =>
                    p.ProductName.Contains(searchKey) || p.Brand.Contains(searchKey) ||
                    p.Category.CategoryName.Contains(searchKey) || p.Description.Contains(searchKey)).AsQueryable();
            }



            switch (ordering)
            {
                case Ordering.Mostvisited:
                    productquery = productquery.OrderByDescending(p => p.ViewCount).AsQueryable();
                    break;
                case Ordering.Bestselling:
                    break;
                case Ordering.MostPopular:
                    break;
                case Ordering.Newest:
                    productquery = productquery.OrderByDescending(p => p.ProductId).AsQueryable();

                    break;
                case Ordering.Cheapest:
                    productquery = productquery.OrderBy(p => p.Price).AsQueryable();
                    break;
                case Ordering.Mostexpensive:
                    productquery = productquery.OrderByDescending(p => p.Price).AsQueryable();

                    break;
                case Ordering.Notorder:
                    productquery = productquery.OrderByDescending(p => p.ProductId).AsQueryable();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(ordering), ordering, null);
            }

             

            var product=productquery.ToPaged(page,  pageSize, out totalRow);

            Random random = new Random();
            return new ResultDto<ResultProductForSiteDtoDto>()
            {

                Data = new ResultProductForSiteDtoDto()
                {
                    TotalRow = totalRow,
                    Products = product.Select(p => new ProductForSiteDto
                    {
                        ProductId = p.ProductId,
                        Star = random.Next(1, 5),
                        Name = p.ProductName,
                        Price = p.Price,
                        ImageSrc = p.ProductImages.FirstOrDefault().Src
                    }).ToList(),
                },
                IsSuccess = true,
                Message = "عملیات موفقیت امیز بود"

            };
        }

       
    }

    public class ResultProductForSiteDtoDto
   {
       public List<ProductForSiteDto> Products { get; set; }
       public int TotalRow { get; set; }
   }
   public class ProductForSiteDto
   {
       public int ProductId { get; set; }
       public string Name { get; set; }
       public string ImageSrc { get; set; }
       public int Star { get; set; }
       public int Price { get; set; }
   }


   public enum Ordering
   {

        //پر بازدید ترین
       Mostvisited,

        //پر فروش ترین
        Bestselling,

        //محبوب ترین
        MostPopular,

        //جدیدترین
        Newest,
        
        //ارزان ترین
        Cheapest,

        //گران ترین
        Mostexpensive,

        //مرتب سازی نشده باشد
        //مرتب سازی نمی کند
        Notorder


    }
}
