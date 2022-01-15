using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;
using DigiMarket.Domain.Entities.Orders;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.Orders.Site.Command.AddNewOrder
{
    public interface IAddNewOrderService
    {
        ResultDto Execute(RequestAddNewOrderServiceDto request);
    }


    public class AddNewOrderService : IAddNewOrderService
    {
        private IDigiMarketContext _context;

        public AddNewOrderService(IDigiMarketContext context)
        {
            _context = context;
        }

        public ResultDto Execute(RequestAddNewOrderServiceDto request)
        {

            var user = _context.Users.Find(request.UserId);
            var cart = _context.Carts.Include(p => p.Items).ThenInclude(p => p.Product)
                .Where(p => p.KeyId == request.CartId).FirstOrDefault();
            var requestPay = _context.RequestPays.Find(request.RequestPayId);


            requestPay.IsPay = true;
            requestPay.PayTime = DateTime.Now;

            cart.Finished = true;

            Order order = new Order()
            {
                Address = "",
                InsertTime = DateTime.Now,
                OrderState = OrderState.Processing,
                RequestPay = requestPay,
                User = user,

            };

            _context.Orders.Add(order);

            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (var item in cart.Items)
            {

                OrderDetail orderDetail = new OrderDetail()
                {
                    Count = item.Count,
                    Order = order,
                    Price = item.Product.Price,
                    Product = item.Product
                };

                orderDetails.Add(orderDetail);
            }

            _context.OrderDetails.AddRange(orderDetails);

            _context.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "ایجاد فاکتور با موفقیت انجام شذ"
            };
        }




    }

    public class RequestAddNewOrderServiceDto
    {
        public int CartId { get; set; }
        public int RequestPayId { get; set; }
        public int UserId { get; set; }
    }
}