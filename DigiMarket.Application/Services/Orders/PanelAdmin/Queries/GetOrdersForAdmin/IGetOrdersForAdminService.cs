using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;
using DigiMarket.Domain.Entities.Orders;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.Orders.PanelAdmin.Queries.GetOrdersForAdmin
{
  public  interface IGetOrdersForAdminService
  {
      ResultDto<List<OrdersAdminDto>> Execute(OrderState orderState);
  }

  public class GetOrdersForAdminService : IGetOrdersForAdminService
  {
      private IDigiMarketContext _context;

      public GetOrdersForAdminService(IDigiMarketContext context)
      {
          _context = context;
      }
      public ResultDto<List<OrdersAdminDto>> Execute(OrderState orderState)
      {

          var orders = _context.Orders.Include(p=>p.User)
              .Include(p => p.OrderDetails)
              .ThenInclude(p=>p.Product)
              .Where(p => p.OrderState == orderState)
              .OrderByDescending(p => p.KeyId)
              .Select(p => new OrdersAdminDto()
              {
                  InsertTime = p.InsertTime,
                  orderId = p.KeyId,
                  OrderState = p.OrderState,
                  ProductCount = p.OrderDetails.Count,
                  RequestId = p.RequestPayId,
                  UserId = p.UserId,
                  Amount = p.RequestPay.Amount,
                  UserName = p.User.FullName
              }).ToList();

          return new ResultDto<List<OrdersAdminDto>>()
          {
              Data = orders,
              IsSuccess = true,
              Message = " فاکتورها برای پنل ادمین با موفقیت واکشی شده است"
          };
      }
  }

  public class OrdersAdminDto
  {
      public int orderId { get; set; }
      public DateTime InsertTime { get; set; }
      public int RequestId { get; set; }
      public int UserId { get; set; }
      public string UserName { get; set; }
      public int Amount { get; set; }
      public OrderState OrderState { get; set; }
      public int ProductCount { get; set; }

  }
}
