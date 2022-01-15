using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.FacadPatterns.OrderFacad.PanelAdmin;
using DigiMarket.Domain.Entities.Orders;
using Microsoft.AspNetCore.Authorization;

namespace EndPoint.DigiMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Operator, Admin")]
    public class OrdersController : Controller
    {
        private IOrderFacad_Admin _orderFacadAdmin;

        public OrdersController(IOrderFacad_Admin orderFacadAdmin)
        {
            _orderFacadAdmin = orderFacadAdmin;
        }
        public IActionResult Index(OrderState orderState)
        {
            return View(_orderFacadAdmin.GetOrdersForAdminService.Execute(orderState).Data);
        }
    }
}
