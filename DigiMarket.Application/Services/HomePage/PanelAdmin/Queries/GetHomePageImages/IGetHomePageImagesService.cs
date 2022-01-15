using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Services.HomePage.Site.Queries.GetHomePageImages;
using DigiMarket.Common;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.HomePage.PanelAdmin.Queries.GetHomePageImages
{
  public  interface IGetHomePageImagesService
  {
      ResultDto<HomePageImagesForAdminDto> Execute(int page = 1, int pageSize = 20);
  }

  public class GetHomePageImagesService: IGetHomePageImagesService
  {
      private IDigiMarketContext _context;

      public GetHomePageImagesService(IDigiMarketContext context)
      {
          _context = context;
      }

      public ResultDto<HomePageImagesForAdminDto> Execute(int page = 1, int pageSize = 20)
      {


          int rowCount = 0;

            var result = _context.HomePageImages.OrderByDescending(p=>p.KeyId).ToPaged(page,pageSize,out rowCount).Select(p=> 
            new HomePageImagesDto()
            {
                
                
                ImageLocation = p.ImageLocation,
                Id = p.KeyId,
                Link = p.Link,
                Src = p.Src

            }).ToList();

          

          return new ResultDto<HomePageImagesForAdminDto>()
          {
              Data = new HomePageImagesForAdminDto()
              {
                  CurrentPage = page,
                  RowCount = rowCount,
                  Images = result,
                  PageSize = pageSize
              },
              IsSuccess = true,
              Message = "اطلاعات با موفقیت از دیتا بیس استخراج شد"
          };

      }


   
  }

  public class HomePageImagesForAdminDto
  {

      //تعداد کل صفحات را برگشت می دهد که در نوار صفحه بندی مشخص شود چند صفحه را نشان دهد.
      //مثلا اگر کلا دو صفحه داشتیم در نوار صغحه بندی در یوآی فقط دو صفحه را نشان می دهد
      public int RowCount { get; set; }
      public int CurrentPage { get; set; }
      //در هر صفحه چند محصول نشان بدهد؟
      public int PageSize { get; set; }
      public List<HomePageImagesDto> Images { get; set; }

  }
}
