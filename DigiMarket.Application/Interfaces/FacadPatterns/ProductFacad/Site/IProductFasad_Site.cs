using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Services.Products.Site.Queries.GetProductDetailForSite;
using DigiMarket.Application.Services.Products.Site.Queries.GetProductForSite;

namespace DigiMarket.Application.Interfaces.FacadPatterns.ProductFacad.Site
{
  public  interface IProductFasad_Site
    {
        IGetProductForSiteService GetProductForSiteService { get; }
        IGetProductDetailForSiteService GetProductDetailForSiteService { get; }
    }
}
