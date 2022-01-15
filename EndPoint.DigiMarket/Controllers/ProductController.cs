using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.FacadPatterns.ProductFacad.Site;
using DigiMarket.Application.Services.Products.Site.Queries.GetProductForSite;

namespace EndPoint.DigiMarket.Controllers
{
    public class ProductController : Controller
    {
        private IProductFasad_Site _productFasadSite;

        public ProductController(IProductFasad_Site productFasadSite)
        {
            _productFasadSite = productFasadSite;
        }
        public IActionResult Index(Ordering ordering,string searchKey,int? catId,int page=1, int pageSize=100)
        {
            return View(_productFasadSite.GetProductForSiteService.Execute(ordering, searchKey,catId,page,  pageSize).Data);
        }

        public IActionResult DetailProduct(int Id)
        {
            return View(_productFasadSite.GetProductDetailForSiteService.Execute(Id).Data);
        }
    }
}
