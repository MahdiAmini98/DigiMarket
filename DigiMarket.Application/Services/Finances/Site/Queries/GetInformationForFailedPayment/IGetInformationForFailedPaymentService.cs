using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Services.Carts;
using DigiMarket.Common.Dto;
using DigiMarket.Domain.Entities.Carts;

namespace DigiMarket.Application.Services.Finances.Site.Queries.GetInformationForFailedpayment
{
   public interface IGetInformationForFailedPaymentService
   {
       ResultDto<RequestFailedPayDto> Execute(Guid guid, Guid browserId, int userId);
   }



   public class GetInformationForFailedPaymentService : IGetInformationForFailedPaymentService
   {
       private IDigiMarketContext _context;
       private ICartService _cartService;

        public GetInformationForFailedPaymentService(IDigiMarketContext context, ICartService cartService)
       {
           _context = context;
           _cartService = cartService;
       }
       public ResultDto<RequestFailedPayDto> Execute(Guid guid ,Guid browserId, int userId)
       {

           var requestPay = _context.RequestPays.Where(p => p.GuidKey == guid && p.IsPay == false).FirstOrDefault();
           var cart = _cartService.GetMyCart(browserId, userId);

           return new ResultDto<RequestFailedPayDto>()
           {
               Data = new RequestFailedPayDto()
               {
                   RequestPayId = requestPay.KeyId,
                   SumPrice = requestPay.Amount,
                   Time = requestPay.InsertTime,
                   ProductCount = cart.Data.ProductCount,
                   Items = cart.Data.CartItem.ToList()
               },
               IsSuccess = true,
               Message = "اطلاعات لازم برای خرید ناموفق کاربر از پایگاه داده واکشی شد"
           };
       }
   }
    public class RequestFailedPayDto
    {

        public int RequestPayId { get; set; }
        public DateTime Time { get; set; }
        public int SumPrice { get; set; }
        public int ProductCount { get; set; }
        public List<CartItemDto> Items { get; set; }
    }
}
