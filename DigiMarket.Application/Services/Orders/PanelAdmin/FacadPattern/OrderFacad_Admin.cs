using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Interfaces.FacadPatterns.OrderFacad.PanelAdmin;
using DigiMarket.Application.Services.Orders.PanelAdmin.Queries.GetOrdersForAdmin;

namespace DigiMarket.Application.Services.Orders.PanelAdmin.FacadPattern
{
   public class OrderFacad_Admin: IOrderFacad_Admin
   {
       private IDigiMarketContext _context;

       public OrderFacad_Admin(IDigiMarketContext context)
       {
           _context = context;
       }


       private GetOrdersForAdminService _getOrdersForAdminService;

       public GetOrdersForAdminService GetOrdersForAdminService
       {
           get
           {
               return _getOrdersForAdminService = _getOrdersForAdminService ?? new GetOrdersForAdminService(_context);
           }
       }
   }
}
