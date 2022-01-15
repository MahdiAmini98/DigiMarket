using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Finances.Site.Queries.GetRequestPay
{
    public interface IGetRequestPayService
    {
        ResultDto<RequstPayDto> Execute(Guid guid);
    }


    public class GetRequestPayService : IGetRequestPayService
    {
        private IDigiMarketContext _context;

        public GetRequestPayService(IDigiMarketContext context)
        {
            _context = context;
        }
        public ResultDto<RequstPayDto> Execute(Guid guid)
        {
            var requestPay = _context.RequestPays.Where(p => p.GuidKey == guid).FirstOrDefault();

            if (guid !=null)
            {

                return new ResultDto<RequstPayDto>()
                {
                    Data = new RequstPayDto()
                    {
                        Amount = requestPay.Amount,
                        RequestPayId = requestPay.KeyId
                    },
                    IsSuccess = true,
                    Message = "درخاست پیگیری با موفقیت یافت شد"
                };
            }
            else
            {
                throw new Exception("RequestPay Not Found");
            }
           
                
           


            

        }
    }

    public class RequstPayDto
    {
        public int RequestPayId { get; set; }
        public int Amount{ get; set; }
    }
}
