using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiMarket.Application.Services.Carts;
using EndPoint.DigiMarket.Cookies;
using EndPoint.DigiMarket.ClaimUtility;
namespace EndPoint.DigiMarket.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        private CookiesManeger cookiesManeger;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
           cookiesManeger = new CookiesManeger();

        }
        public IActionResult Index()
        {
           var userId = ClaimUtility.ClaimUtility.GetUserId(User);
            var resultGetList = _cartService.GetMyCart(cookiesManeger.GetBrowserId(HttpContext), userId);
            return View(resultGetList.Data);
        }

        public IActionResult AddToCart(int productId)
        {

           var resultAdd = _cartService.AddToCart(productId, cookiesManeger.GetBrowserId(HttpContext));

            return RedirectToAction("Index");
        }

        public IActionResult RemoveToCart(int productId)
        {
            _cartService.RemoveFromCart(productId, cookiesManeger.GetBrowserId(HttpContext));
            return RedirectToAction("Index");

        }

        public IActionResult AddToCountProduct(int cartItemId)
        {
            _cartService.AddToCountProduct(cartItemId);

            return RedirectToAction("Index");
        }

        public IActionResult LowToCountProduct(int cartItemId)
        {
            _cartService.LowToCountProduct(cartItemId);

            return RedirectToAction("Index");
        }
       
    }
}
