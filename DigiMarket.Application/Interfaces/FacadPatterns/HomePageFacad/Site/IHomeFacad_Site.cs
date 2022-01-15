using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Services.HomePage.Site.Queries.GetHomePageImages;
using DigiMarket.Application.Services.HomePage.Site.Queries.GetProductForInstantOfferHomePage;
using DigiMarket.Application.Services.HomePage.Site.Queries.GetProductForModalHomePage;

namespace DigiMarket.Application.Interfaces.FacadPatterns.HomePage.Site
{
  public  interface IHomeFacad_Site
    {
        GetHomePageImagesService GetHomePageImagesService { get; }
        GetProductForModalHomePage GetProductForModalHomePage { get; }
        GetProductForInstantOfferHomePage GetProductForInstantOfferHomePage { get; }
    }
}
