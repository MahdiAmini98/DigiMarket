using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.FacadPatterns.CommonFacad.Site;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.DigiMarket.ViewComponents
{
    public class Search : ViewComponent
    {
        private ICommonFacad_Site _commonFacad;

        public Search(ICommonFacad_Site commonFacad)
        {
            _commonFacad = commonFacad;
        }

        public IViewComponentResult Invoke()
        {

            return View(viewName: "Search", _commonFacad._GetCategoryForSearchService.Execute().Data);
        }
    }
}
