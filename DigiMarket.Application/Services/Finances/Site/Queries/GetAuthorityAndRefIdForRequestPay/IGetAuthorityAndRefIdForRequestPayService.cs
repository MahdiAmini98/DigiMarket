using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Finances.Site.Queries.GetAuthorityAndRefIdForRequestPay
{
   public interface IGetAuthorityAndRefIdForRequestPayService
   {
       ResultDto Execute(Guid guid, string authority, int refId);
   }

   public class GetAuthorityAndRefIdForRequestPayService : IGetAuthorityAndRefIdForRequestPayService
   {
       private IDigiMarketContext _context;

       public GetAuthorityAndRefIdForRequestPayService(IDigiMarketContext context)
       {
           _context = context;
       }
       public ResultDto Execute(Guid guid,string authority, int refId)
       {

           var requestPay = _context.RequestPays.Where(p => p.GuidKey == guid).FirstOrDefault();

           if (requestPay !=null)
           {
               requestPay.Authority = authority;
               requestPay.RefId = refId;
               _context.SaveChanges();

               return new ResultDto()
               {
                   IsSuccess = true,
                   Message = " ذخیره شد RequestPays با موفقیت در جدول  Authority و RefId"
               };
           }
           else
           {
               throw new Exception("RequestPay Not Found");
           }
        }
   }
}
