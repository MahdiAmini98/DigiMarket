using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Interfaces.FacadPatterns.CommonFacad.Site;
using DigiMarket.Application.Services.Common.Site.Queries.GetCategoryForSearch;
using DigiMarket.Application.Services.Common.Site.Queries.GetMenuItem;

namespace DigiMarket.Application.Services.Common.Site.FacadPattern
{
   public class CommonFacad_Site: ICommonFacad_Site
    {
       private IDigiMarketContext _context;

       public CommonFacad_Site(IDigiMarketContext context)
       {
           _context = context;
       }


       private IGetMenuItemService _getMenuItemService;


        public IGetMenuItemService _GetMenuItemService
        {
            get
            {
                return _getMenuItemService = _getMenuItemService ?? new GetMenuItemService(_context);
            }
        }

        private IGetCategoryForSearchService _getCategoryForSearchService;

        public IGetCategoryForSearchService _GetCategoryForSearchService
        {

            get
            {
                return _getCategoryForSearchService =
                    _getCategoryForSearchService ?? new GetCategoryForSearchService(_context);
            }
        }
    }
}
