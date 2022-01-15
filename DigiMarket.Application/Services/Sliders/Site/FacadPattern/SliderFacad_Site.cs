using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Interfaces.FacadPatterns.SliderFacad.Site;
using DigiMarket.Application.Services.Sliders.Site.Queries.GetSlider;
using DigiMarket.Application.Services.Sliders.Site.Queries.GetSliderByIdForClickCount;

namespace DigiMarket.Application.Services.Sliders.Site.FacadPattern
{
 public  class SliderFacad_Site: ISliderFacad_Site
 {
     private IDigiMarketContext _context;

     public SliderFacad_Site(IDigiMarketContext context)
     {
         _context = context;
     }



     private GetSliderService _getSliderService;

     public GetSliderService GetSliderService
     {
         get
         {
             return _getSliderService = _getSliderService ?? new GetSliderService(_context);
         }


        }


     private GetSliderByIdForClickCount _getSliderByIdForClickCount;

     public GetSliderByIdForClickCount GetSliderByIdForClickCount
     {
         get
         {
             return _getSliderByIdForClickCount =
                 _getSliderByIdForClickCount ?? new GetSliderByIdForClickCount(_context);
         }
     }
 }
}
