using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;
using DigiMarket.Domain.Entities.Home_Page_Images;

namespace DigiMarket.Application.Services.HomePage.Site.Queries.GetHomePageImages
{
  public  interface IGetHomePageImagesService
  {
      ResultDto<List<HomePageImagesDto>> Execute();
  }


  public class GetHomePageImagesService : IGetHomePageImagesService
  {
      private IDigiMarketContext _context;

      public GetHomePageImagesService(IDigiMarketContext context)
      {
          _context = context;
      }
      public ResultDto<List<HomePageImagesDto>> Execute()
      {

          var images = _context.HomePageImages.OrderByDescending(p => p.KeyId).Select(p => new HomePageImagesDto()
          {
              Link = p.Link,
              Id = p.KeyId,
              ImageLocation = p.ImageLocation,
              Src = p.Src

          }).ToList();



          return new ResultDto<List<HomePageImagesDto>>()
          {
              Data = images,
              IsSuccess = true,
              Message = "لیست عکس های صفحه اصلی سایت با موقیت استخراج شد"
          };
      }
  }



  public class HomePageImagesDto
  {

      public int Id { get; set; }
      public string Link { get; set; }
      public string Src { get; set; }
      public ImageLocation ImageLocation { get; set; }
  }
}
