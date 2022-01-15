using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.FacadPatterns.FinancesFacad.Site;
using DigiMarket.Application.Interfaces.FacadPatterns.OrderFacad.Site;
using DigiMarket.Application.Services.Carts;
using DigiMarket.Application.Services.Orders.Site.Command.AddNewOrder;
using Dto.Payment;
using EndPoint.DigiMarket.Cookies;
using Microsoft.AspNetCore.Authorization;
using ZarinPal.Class;

namespace EndPoint.DigiMarket.Controllers
{
    [Authorize("Customer")]
    public class PayController : Controller
    {
        private IFinancesFacad_Site _financesFacadSite;
        private ICartService _cartService;
        private CookiesManeger _cookiesManeger;
        private IOrderFacad_Site _orderFacadSite;

        //نمونه سازی های درگاه زرین پال

        private readonly Payment _payment; 
        private readonly Authority _authority;
        private readonly Transactions _transactions;

        public PayController(IFinancesFacad_Site financesFacadSite ,ICartService cartService , IOrderFacad_Site orderFacadSite)
        {
            _financesFacadSite = financesFacadSite;
            _cartService = cartService;
            _cookiesManeger = new CookiesManeger();
            _orderFacadSite = orderFacadSite;

            //نمونه سازی های درگاه زرین پال

            var expose = new Expose();
            _payment = expose.CreatePayment();
            _authority = expose.CreateAuthority();
            _transactions = expose.CreateTransactions();
        }
        public async Task<IActionResult> Index()
        {
            var userId = ClaimUtility.ClaimUtility.GetUserId(User);
            var browserId = _cookiesManeger.GetBrowserId(HttpContext);
            var cart = _cartService.GetMyCart(browserId, userId);

            if (cart.Data.SumPrice > 0)
            {
                var requestpay = _financesFacadSite.AddRequestPayService.Execute(userId.Value, cart.Data.SumPrice);


                //ارسال به درگاه پرداخت زرین پال

                #region Zarinpal Code

                var result = await _payment.Request(new DtoRequest()
                {
                    Mobile = "09121112222",
                    CallbackUrl = $"https://localhost:44340/pay/Verify?guid={requestpay.Data.Guid}",
                    Description = $"پرداخت فاکتور شماره: {requestpay.Data.RequestPayId}",
                    Email = "farazmaan@outlook.com",
                    Amount = requestpay.Data.Amount,
                    MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"
                }, ZarinPal.Class.Payment.Mode.sandbox);
                return Redirect($"https://sandbox.zarinpal.com/pg/StartPay/{result.Authority}");

                #endregion
            }


            else
            {
                return RedirectToAction("Index", "Cart");
            }

          
        }


        public async Task<IActionResult> Verify(Guid guid ,string authority ,string status)
        {

          var requstPay=  _financesFacadSite.GetRequestPayService.Execute(guid).Data;
            //اعتبار سنجی پرداخت زرین پال

            var verification = await _payment.Verification(new DtoVerification
            {
                Amount = requstPay.Amount,
                MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                Authority = authority
            }, Payment.Mode.sandbox);

            //برای جدول   authority و refId  ایجاد سرویسی برای ست کردن مقادیر 
            //این سرویس را خودت ایجاد کن

            var browserId = _cookiesManeger.GetBrowserId(HttpContext);
            var userId = ClaimUtility.ClaimUtility.GetUserId(User);
            var cart = _cartService.GetMyCart(browserId, userId);
            if (verification.Status==100)
            {

                // در پایگاه داده RefId ,  authority  ثبت
              
                _financesFacadSite.GetAuthorityAndRefIdForRequestPayService.Execute(guid, authority,
                    verification.RefId);

                //ایجاد فاکنور یا سفارش برای پرداختی که انجام شده
                _orderFacadSite.AddNewOrderService.Execute(new RequestAddNewOrderServiceDto()
                {
                    CartId = cart.Data.CartId,
                    RequestPayId = requstPay.RequestPayId,
                    UserId = userId.Value
                });

                //redirect to orders :برگشت به صفحه فاکتورهای کاربر
                return RedirectToAction("Index", "Order");
            }


            //اگر پرداخت نا موفق بود
            else
            {
                return View(
                    _financesFacadSite.GetInformationForFailedPaymentService.Execute(guid, browserId, userId.Value).Data);
            }
           
        }
    }
}
