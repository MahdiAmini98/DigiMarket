using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Services.Sliders.Site.Queries.GetSlider;
using DigiMarket.Application.Services.Sliders.Site.Queries.GetSliderByIdForClickCount;

namespace DigiMarket.Application.Interfaces.FacadPatterns.SliderFacad.Site
{
  public  interface ISliderFacad_Site
    {
        GetSliderService GetSliderService { get; }
        GetSliderByIdForClickCount GetSliderByIdForClickCount { get; }
    }
}
