using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Services.Orders.Site.Queries.GetUserOrders;
using DigiMarket.Common.Dto;
using DigiMarket.Domain.Entities.Orders;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.Orders.Site.Queries.GetOrderDetail
{
   public interface IGetOrderDetailService
   {
       ResultDto<GetOrderDetail> Execute( int orderId);
   }


   public class GetOrderDetailService : IGetOrderDetailService
   {
       private IDigiMarketContext _context;
       

       public GetOrderDetailService(IDigiMarketContext context)
       {
           _context = context;
       }
       public ResultDto<GetOrderDetail> Execute( int orderId)
       {
           var orderDetail = _context.OrderDetails.Include(p => p.Product).Include(p=>p.Order).ThenInclude(p=>p.RequestPay)
               .Where(p => p.OrderId == orderId)
               .OrderByDescending(p => p.KeyId)
               .Select(p => new OrderDetailDto
               {
                   Count = p.Count,
                   orderDetailId = p.KeyId,
                   productName = p.Product.ProductName,
                   Price = p.Price,
                  
               }).ToList();

           var amount = _context.Orders.Include(p => p.RequestPay).Where(p => p.KeyId == orderId).FirstOrDefault();

           return new ResultDto<GetOrderDetail>()
           {
               Data = new GetOrderDetail()
               {
                   Amount = amount.RequestPay.Amount,
                   OrderDetail = orderDetail
               },
               IsSuccess = true,
               Message = "جزییات محصول با موفقیت واکشی شد"
           };

       }
   }

   public class GetOrderDetail
   {
       public int Amount { get; set; }
       public List<OrderDetailDto> OrderDetail { get; set; }
    }
  
   public class OrderDetailDto
   {
       public int orderDetailId { get; set; }
     
       public string productName { get; set; }
       public int Price { get; set; }
       public int Count { get; set; }
      
   }

}
