using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Services.Carts;
using EndPoint.DigiMarket.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.DigiMarket.ViewComponents
{
    public class Cart:ViewComponent
    {
        private readonly CookiesManeger _cookiesManeger;
        private readonly ICartService _cartService;


        public Cart( ICartService cartService)
        {
            _cookiesManeger = new CookiesManeger();
            _cartService = cartService;
        }



        public IViewComponentResult Invoke()
        {
            var userId = ClaimUtility.ClaimUtility.GetUserId(HttpContext.User);

            return View(viewName: "Cart", model:_cartService.GetMyCart(_cookiesManeger.GetBrowserId(HttpContext),userId).Data );
        }
    }
}
