using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Sliders.Site.Queries.GetSlider
{
  public interface IGetSliderService
  {
      ResultDto<List<SliderDto>> Execute();
  }



  public class GetSliderService : IGetSliderService
  {
      private IDigiMarketContext _context;

      public GetSliderService(IDigiMarketContext context)
      {
          _context = context;
      }
      public ResultDto<List<SliderDto>> Execute()
      {
          var sliders = _context.Sliders.OrderByDescending(p => p.KeyId).Select(p => new SliderDto()
          {
              Id = p.KeyId,
              Link = p.Link,
              Src = p.Src,
              ClickCount = p.ClickCount
          }).ToList();

          
          return new ResultDto<List<SliderDto>>()
          {
              Data = sliders.ToList(),
              IsSuccess = true,
              Message = " عملیات با موفقیت انجام شد"
          };
      }
  }

  public class SliderDto
  {
      public int Id { get; set; }
      public string Link { get; set; }
      public string Src { get; set; }
      public int ClickCount { get; set; }
  }
}
