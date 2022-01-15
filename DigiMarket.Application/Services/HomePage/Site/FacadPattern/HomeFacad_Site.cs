using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Interfaces.FacadPatterns.HomePage.Site;
using DigiMarket.Application.Services.HomePage.Site.Queries.GetHomePageImages;
using DigiMarket.Application.Services.HomePage.Site.Queries.GetProductForInstantOfferHomePage;
using DigiMarket.Application.Services.HomePage.Site.Queries.GetProductForModalHomePage;

namespace DigiMarket.Application.Services.HomePage.Site.FacadPattern
{
   public class HomeFacad_Site: IHomeFacad_Site
   {
       private IDigiMarketContext _context;


       public HomeFacad_Site(IDigiMarketContext context)
       {
           _context = context;
       }



       private GetHomePageImagesService _getHomePageImagesService;

       public GetHomePageImagesService GetHomePageImagesService
       {
           get
           {
               return _getHomePageImagesService = _getHomePageImagesService ?? new GetHomePageImagesService(_context);

            }

        }


       private GetProductForModalHomePage _getProductForModalHomePage;

       public GetProductForModalHomePage GetProductForModalHomePage
       {
           get
           {
               return _getProductForModalHomePage =
                   _getProductForModalHomePage ?? new GetProductForModalHomePage(_context);
           }

       }


       private GetProductForInstantOfferHomePage _getProductForInstantOfferHomePage;

       public GetProductForInstantOfferHomePage GetProductForInstantOfferHomePage
       {
           get
           {
               return _getProductForInstantOfferHomePage = _getProductForInstantOfferHomePage ??
                                                           new GetProductForInstantOfferHomePage(_context);
           }
       }
   }
}
