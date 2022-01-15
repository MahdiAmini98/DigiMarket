using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.Finances.PanelAdmin.Queries.GetPaysForAdmin
{
  public  interface IGetPaysForAdminService
    {
        ResultDto<List<PayDto>> Execute();
    }



    public class GetPaysForAdminService : IGetPaysForAdminService
    {
        private IDigiMarketContext _context;
        public GetPaysForAdminService(IDigiMarketContext context)
        {
          
            _context = context;
        }

        public ResultDto<List<PayDto>> Execute()
        {

            var requestPay = _context.RequestPays.Include(p=>p.Orders).Include(p => p.Users).ToList().Select(
                p => new PayDto
                {
                    RequestPayId=p.KeyId,
                    Amount = p.Amount,
                    Guid = p.GuidKey,
                    UserId = p.UserId,
                    UserName = p.Users.FullName,
                    IsPay = p.IsPay,
                    Paydate = p.InsertTime,
                    Authorize = p.Authority,
                    RefId = p.RefId,
                });

            return new ResultDto<List<PayDto>>
            {
                Data = requestPay.ToList(),
                IsSuccess = true,
                Message = "پرداخت ها با موفقیت از پایگاه داده استخراح شد"
            };


        }
    }


    public class PayDto
    {
        public int RequestPayId { get; set; }
        public Guid Guid { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Amount { get; set; }
        public bool IsPay { get; set; }
        public DateTime? Paydate { get; set; }
        public string Authorize { get; set; }
        public int RefId { get; set; } = 0;
    }
}
