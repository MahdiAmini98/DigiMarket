using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Interfaces.FacadPatterns.FinancesFacad.PanelAdmin;
using DigiMarket.Application.Services.Finances.PanelAdmin.Queries.GetPaysForAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiMarket.Application.Services.Finances.PanelAdmin.FacadPattern
{
  public  class FinancesFacad_Admin : IFinancesFacad_Admin
    {

        private IDigiMarketContext _context;

        public FinancesFacad_Admin(IDigiMarketContext context)
        {
            _context = context;
        }


        private GetPaysForAdminService _getPaysForAdminService;

        public GetPaysForAdminService GetPaysForAdminService { get
            {
                return _getPaysForAdminService = _getPaysForAdminService ?? new GetPaysForAdminService(_context);
            }
        }
    }
}
