using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Sliders.Site.Queries.GetSliderByIdForClickCount
{
  public  interface IGetSliderByIdForClickCount
  {
      ResultDto<SliderDto> Execute(int id);
  }


  public class GetSliderByIdForClickCount : IGetSliderByIdForClickCount
  {
      private IDigiMarketContext _context;

      public GetSliderByIdForClickCount(IDigiMarketContext context)
      {
          _context = context;
      }
      public ResultDto<SliderDto> Execute(int id)
      {
          var slider = _context.Sliders.Find(id);
          slider.ClickCount++;
          _context.SaveChanges();

          return new ResultDto<SliderDto>()
          {
              Data = new SliderDto()
              {
                  Link = slider.Link,
                  SliderId = slider.KeyId
              },
              IsSuccess = true,
              Message = "اسلایدر آپدیت شد"
          };

      }
  }


  public class SliderDto
  {
      public int SliderId { get; set; }
      public string Link { get; set; }
  }
}
