using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Interfaces.FacadPatterns.OrderFacad.Site;
using DigiMarket.Application.Services.Orders.Site.Command.AddNewOrder;
using DigiMarket.Application.Services.Orders.Site.Queries.GetOrderDetail;
using DigiMarket.Application.Services.Orders.Site.Queries.GetUserOrders;

namespace DigiMarket.Application.Services.Orders.Site.FacadPattern
{
    public class OrderFacad_Site : IOrderFacad_Site
    {
        private IDigiMarketContext _context;

        public OrderFacad_Site(IDigiMarketContext context)
        {
            _context = context;
           
        }


        private AddNewOrderService _addNewOrderService;


        public AddNewOrderService AddNewOrderService
        {

            get
            {
                return _addNewOrderService = _addNewOrderService ?? new AddNewOrderService(_context);
            }
        }

        private GetUserOrdersService _getUserOrdersService;

        public GetUserOrdersService GetUserOrdersService
        {
            get
            {
                return _getUserOrdersService = _getUserOrdersService ?? new GetUserOrdersService(_context);
            }
        }


        private GetOrderDetailService _getOrderDetailService;

        public GetOrderDetailService GetOrderDetailService
        {
            get
            {
                return _getOrderDetailService = _getOrderDetailService ?? new GetOrderDetailService(_context);
            }
        }
    } 
}
