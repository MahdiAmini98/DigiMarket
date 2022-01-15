using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Interfaces.FacadPatterns.ProductFacad.Site;
using DigiMarket.Application.Services.Products.Site.Queries.GetProductDetailForSite;
using DigiMarket.Application.Services.Products.Site.Queries.GetProductForSite;

namespace DigiMarket.Application.Services.Products.Site.FasadPattern
{
   public class ProductFasad_Site: IProductFasad_Site
   {
       private readonly IDigiMarketContext _context;

       public ProductFasad_Site(IDigiMarketContext context)
       {
           _context = context;
       }

       private IGetProductForSiteService _getProductForSiteService;

       public IGetProductForSiteService GetProductForSiteService
       {
           get
           {
               return _getProductForSiteService = _getProductForSiteService ?? new GetProductForSiteService(_context);
           }

        }

       private IGetProductDetailForSiteService _getProductDetailForSiteService;

       public IGetProductDetailForSiteService GetProductDetailForSiteService
       {
           get
           {
               return _getProductDetailForSiteService = _getProductDetailForSiteService ?? new GetProductDetailForSiteService(_context);

            }

        }


      
   }
}
