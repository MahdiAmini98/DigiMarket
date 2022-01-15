using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Interfaces.FacadPatterns.FinancesFacad.Site;
using DigiMarket.Application.Services.Carts;
using DigiMarket.Application.Services.Finances.Site.Command.AddRequestPay;
using DigiMarket.Application.Services.Finances.Site.Queries.GetAuthorityAndRefIdForRequestPay;
using DigiMarket.Application.Services.Finances.Site.Queries.GetInformationForFailedpayment;
using DigiMarket.Application.Services.Finances.Site.Queries.GetRequestPay;

namespace DigiMarket.Application.Services.Finances.Site.FacadPattern
{
  public  class FinancesFacad_Site : IFinancesFacad_Site
  {
      private IDigiMarketContext _context;
      private ICartService _cartService;



        public FinancesFacad_Site(IDigiMarketContext context,  ICartService cartService)

        {
            _cartService = cartService;
          _context = context;
      }


      private AddRequestPayService _addRequestPayService;


      public AddRequestPayService AddRequestPayService
      {
          get
          {
              return _addRequestPayService = _addRequestPayService ?? new AddRequestPayService(_context);

            }
        }


      private GetRequestPayService _getRequestPayService;

      public GetRequestPayService GetRequestPayService
      {
          get
          {
              return _getRequestPayService = _getRequestPayService ?? new GetRequestPayService(_context);
          }
      }


      private GetAuthorityAndRefIdForRequestPayService _getAuthorityAndRefIdForRequestPayService;

      public GetAuthorityAndRefIdForRequestPayService GetAuthorityAndRefIdForRequestPayService
      {
          get
          {
              return _getAuthorityAndRefIdForRequestPayService = _getAuthorityAndRefIdForRequestPayService ??
                                                                 new GetAuthorityAndRefIdForRequestPayService(_context);
          }

      }

      private GetInformationForFailedPaymentService _getInformationForFailedPaymentService;

      public GetInformationForFailedPaymentService GetInformationForFailedPaymentService
      {
          get
          {
              return _getInformationForFailedPaymentService = _getInformationForFailedPaymentService ??
                                                              new GetInformationForFailedPaymentService(_context,
                                                                  _cartService);
          }
      }
  }
}
