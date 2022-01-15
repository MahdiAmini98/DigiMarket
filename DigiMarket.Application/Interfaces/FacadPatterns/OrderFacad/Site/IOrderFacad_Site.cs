using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Services.Orders.Site.Command.AddNewOrder;
using DigiMarket.Application.Services.Orders.Site.Queries.GetOrderDetail;
using DigiMarket.Application.Services.Orders.Site.Queries.GetUserOrders;

namespace DigiMarket.Application.Interfaces.FacadPatterns.OrderFacad.Site
{
   public interface IOrderFacad_Site
    {
        AddNewOrderService AddNewOrderService { get; }
        GetUserOrdersService GetUserOrdersService { get; }
        GetOrderDetailService GetOrderDetailService { get; }

    }
}
