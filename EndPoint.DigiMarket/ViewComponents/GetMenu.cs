using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.FacadPatterns.CommonFacad.Site;
using DigiMarket.Application.Services.Common.Site.Queries.GetMenuItem;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.DigiMarket.ViewComponents
{
    public class GetMenu:ViewComponent
    {
        private ICommonFacad_Site _commonFacad;

        public GetMenu(ICommonFacad_Site commonFacad)
        {
            _commonFacad = commonFacad;
        }

       


        public IViewComponentResult Invoke()
        {

            return View(viewName: "GetMenu", model: _commonFacad._GetMenuItemService.Execute().Data);
        }
    }
}
