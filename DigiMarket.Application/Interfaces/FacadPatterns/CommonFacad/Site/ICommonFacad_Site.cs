using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Services.Common.Site.Queries.GetCategoryForSearch;
using DigiMarket.Application.Services.Common.Site.Queries.GetMenuItem;

namespace DigiMarket.Application.Interfaces.FacadPatterns.CommonFacad.Site
{
 public  interface ICommonFacad_Site
    {
        IGetMenuItemService _GetMenuItemService { get; }
        IGetCategoryForSearchService _GetCategoryForSearchService { get; }
    }
}
