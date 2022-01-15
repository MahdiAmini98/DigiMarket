using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;
using DigiMarket.Domain.Entities.Orders;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.Orders.Site.Queries.GetUserOrders
{
  public interface IGetUserOrdersService
  {
      ResultDto<List<GetUserOrdersDto>> Execute(int userId );
  }



  public class GetUserOrdersService : IGetUserOrdersService
  {
      private IDigiMarketContext _context;

      public GetUserOrdersService(IDigiMarketContext context)
      {
          _context = context;
      }
      public ResultDto<List<GetUserOrdersDto>> Execute(int userId)
      {

          var order = _context.Orders
                  //.Include(P => P.OrderDetails)
                  //.ThenInclude(P => P.Product)
                  .Where(p => p.UserId == userId )
                  .OrderByDescending(p => p.KeyId).Select(p => new GetUserOrdersDto()
                  {
                      OrderId = p.KeyId,
                      OrderState = p.OrderState,
                      orderTime = p.InsertTime,
                      RequestPayId = p.RequestPayId,
                      SumPrice = p.RequestPay.Amount,
                      //    OrderDetails = p.OrderDetails.Select(o => new OrderDetailDto
                      //    {
                      //        Count = o.Count,
                      //        orderDetailId = o.KeyId,
                      //        productId = o.ProductId,
                      //        productName = o.Product.ProductName,
                      //        Price = o.Price,
                      //    }).ToList()
                  }).ToList();


            return new ResultDto<List<GetUserOrdersDto>>()
              {
                  Data = order,
                  IsSuccess = true,
                  Message = "سفارشات کاربر با موفیت واکشی شد"
              };
           


      }
  }

  public class GetUserOrdersDto
  {
      public int OrderId { get; set; }
      public int RequestPayId { get; set; }
      public DateTime orderTime { get; set; }
      public OrderState OrderState { get; set; }
      public int SumPrice { get; set; }
      //public List<OrderDetailDto> OrderDetails { get; set; }
  }

    //public class OrderDetailDto
    //{
    //    public int orderDetailId { get; set; }
    //    public int productId { get; set; }
    //    public string productName { get; set; }
    //    public int Price { get; set; }
    //    public int Count { get; set; }
    //}
}
