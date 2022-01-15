using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.FacadPatterns.FinancesFacad.Site;
using DigiMarket.Application.Interfaces.FacadPatterns.OrderFacad.Site;
using Microsoft.AspNetCore.Authorization;

namespace EndPoint.DigiMarket.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private IOrderFacad_Site _orderFacadSite;
        private IFinancesFacad_Site _financesFacadSite;

        public OrderController(IOrderFacad_Site orderFacadSite , IFinancesFacad_Site financesFacadSite)
        {
            _orderFacadSite = orderFacadSite;
            _financesFacadSite = financesFacadSite;
        }
        public IActionResult Index()
        {
            var userId = ClaimUtility.ClaimUtility.GetUserId(User);
            return View(_orderFacadSite.GetUserOrdersService.Execute(userId.Value).Data);
        }

        public IActionResult OrderDetail(int id)
        {
            var userId = ClaimUtility.ClaimUtility.GetUserId(User);

           
            return View(_orderFacadSite.GetOrderDetailService.Execute(id).Data);
        }
    }
}
