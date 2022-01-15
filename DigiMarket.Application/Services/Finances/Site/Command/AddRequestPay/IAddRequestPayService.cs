using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;
using DigiMarket.Domain.Entities.Finances;

namespace DigiMarket.Application.Services.Finances.Site.Command.AddRequestPay
{
 public interface IAddRequestPayService
 {
     ResultDto<ResultRequestPayDto> Execute(int userId, int Amount);
 }


 public class AddRequestPayService : IAddRequestPayService
 {
     private IDigiMarketContext _context;

     public AddRequestPayService(IDigiMarketContext context)
     {
         _context = context;
     }
     public ResultDto<ResultRequestPayDto> Execute(int userId, int Amount)
     {
         var user = _context.Users.Find(userId);

         RequestPay requestPay = new RequestPay()
         {
             Amount = Amount,
             GuidKey = Guid.NewGuid(),
             IsPay = false,
             Users = user,
         };
         _context.RequestPays.Add(requestPay);
         _context.SaveChanges();


         return new ResultDto<ResultRequestPayDto>()
         {
             Data =new ResultRequestPayDto()
             {
                 Guid = requestPay.GuidKey,
                 Amount = requestPay.Amount,
                 Email = user.Email,
                 RequestPayId = requestPay.KeyId
             } ,
             IsSuccess = true,
             Message = "پیگیری پرداخت با موفقیت اضافه شد"
         };
     }
 }

 public class ResultRequestPayDto
 {
     public Guid Guid { get; set; }
     public int Amount { get; set; }
     public string Email { get; set; }
     public int RequestPayId { get; set; }
 }

}
