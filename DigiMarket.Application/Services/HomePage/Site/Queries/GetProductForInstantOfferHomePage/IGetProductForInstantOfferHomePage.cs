using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Services.Products.Site.Queries.GetProductForSite;
using DigiMarket.Common.Dto;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.HomePage.Site.Queries.GetProductForInstantOfferHomePage
{
  public  interface IGetProductForInstantOfferHomePage
  {
      ResultDto<List<ProductForSiteDto>> Execute();
  }

  //مربوط به قسمت ==> پیشنهاد لحظه ای ======>در صفحه اصلی سایت

    public class GetProductForInstantOfferHomePage : IGetProductForInstantOfferHomePage
  {
      private IDigiMarketContext _context;


      public GetProductForInstantOfferHomePage(IDigiMarketContext context)
      {
          _context = context;
      }
      public ResultDto<List<ProductForSiteDto>> Execute()
      {

          //var productList = _context.Products.ToList();
          //var random = new Random();
          //var randomNumber = random.Next(productList.Count);
          var count = _context.Products.Count();


          var products = _context.Products.Include(p=>p.ProductImages)
              .OrderBy(p=> Guid.NewGuid()).Take(count).Select(p=>new ProductForSiteDto()
              {
                  ImageSrc = p.ProductImages.FirstOrDefault().Src,
                  Name = p.ProductName,
                  Price = p.Price,
                  ProductId = p.ProductId,

              }).ToList();

          return new ResultDto<List<ProductForSiteDto>>()
          {
              Data = products,
              Message = "عملیات موفقیت آمیز بود",
              IsSuccess = true
          };
        }
  }

}
