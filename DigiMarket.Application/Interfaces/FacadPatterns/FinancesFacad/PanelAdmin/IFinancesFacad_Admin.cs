using DigiMarket.Application.Services.Finances.PanelAdmin.Queries.GetPaysForAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiMarket.Application.Interfaces.FacadPatterns.FinancesFacad.PanelAdmin
{
    public interface IFinancesFacad_Admin
    {
        GetPaysForAdminService GetPaysForAdminService { get; }
    }
}
