using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using DigiMarket.Application.Services.HomePage.Site.Queries.GetHomePageImages;
using DigiMarket.Application.Services.Products.Site.Queries.GetProductForSite;
using DigiMarket.Application.Services.Sliders.Site.Queries.GetSlider;

namespace EndPoint.DigiMarket.ViewModel.HomePage
{
    public class HomePageViewModel
    {
        public List<SliderDto> Slider { get; set; }
        public List<HomePageImagesDto> Images { get; set; }
        public List<ProductForSiteDto> Camera { get; set; }
        public List<ProductForSiteDto> Mobile { get; set; }
        public List<ProductForSiteDto> HomeAppliances { get; set; }
        public List<ProductForSiteDto> Laptop { get; set; }

        public List<ProductForSiteDto> Modal { get; set; }

        //مربوط به قسمت ==> پیشنهاد لحظه ای ======>در صفحه اصلی سایت
        public List<ProductForSiteDto> InstantOffer { get; set; }
    }
}
