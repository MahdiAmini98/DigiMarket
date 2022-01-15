using EndPoint.DigiMarket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.FacadPatterns.HomePage.Site;
using DigiMarket.Application.Interfaces.FacadPatterns.ProductFacad.Site;
using DigiMarket.Application.Interfaces.FacadPatterns.SliderFacad.Site;
using DigiMarket.Application.Services.Products.Site.Queries.GetProductForSite;
using EndPoint.DigiMarket.ViewModel.HomePage;


namespace EndPoint.DigiMarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISliderFacad_Site _sliderFacadSite;
        private readonly IHomeFacad_Site _homeFacadSite;
        private readonly IProductFasad_Site _productFasadSite;

        public HomeController(ILogger<HomeController> logger, ISliderFacad_Site sliderFacadSite , IHomeFacad_Site homeFacadSite, IProductFasad_Site productFasadSite)
        {
            _logger = logger;
            _sliderFacadSite = sliderFacadSite;
            _homeFacadSite = homeFacadSite;
            _productFasadSite = productFasadSite;
        }

        public IActionResult Index()
        {

            HomePageViewModel homePageView = new HomePageViewModel()
            {
                Slider = _sliderFacadSite.GetSliderService.Execute().Data,
                Images = _homeFacadSite.GetHomePageImagesService.Execute().Data,
                Camera = _productFasadSite.GetProductForSiteService.Execute(Ordering.Notorder
                    , null, 28, 1, 6).Data.Products,
                Mobile = _productFasadSite.GetProductForSiteService.Execute(Ordering.Newest, null, 24, 1, 6).Data.Products,
                HomeAppliances = _productFasadSite.GetProductForSiteService.Execute(Ordering.Newest, null, 1024, 1, 6).Data.Products,
                Laptop = _productFasadSite.GetProductForSiteService.Execute(Ordering.Newest, null, 25, 1, 6).Data.Products,
                Modal = _homeFacadSite.GetProductForModalHomePage.Execute().Data,
                //مربوط به قسمت ==> پیشنهاد لحظه ای ======>در صفحه اصلی سایت

                InstantOffer = _homeFacadSite.GetProductForInstantOfferHomePage.Execute().Data
            };
            return View(homePageView);
        }

        public IActionResult ClickCountSlider(int id)
        {
            
            return Redirect(_sliderFacadSite.GetSliderByIdForClickCount.Execute(id).Data.Link);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
