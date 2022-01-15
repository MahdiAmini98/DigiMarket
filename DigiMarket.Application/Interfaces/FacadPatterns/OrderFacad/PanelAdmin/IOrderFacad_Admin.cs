using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Services.Orders.PanelAdmin.Queries.GetOrdersForAdmin;

namespace DigiMarket.Application.Interfaces.FacadPatterns.OrderFacad.PanelAdmin
{
   public interface IOrderFacad_Admin
    {
        GetOrdersForAdminService GetOrdersForAdminService { get; }
    }
}
