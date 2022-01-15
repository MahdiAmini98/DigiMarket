using System;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Products.PanelAdmin.Command.RemoveProduct
{
   public interface IRemoveProductService
   {
       ResultDto Execute(int ProductId);
   }

   public class RemoveProductService : IRemoveProductService
   {
       private IDigiMarketContext _context;

       public RemoveProductService(IDigiMarketContext context)
       {
           _context = context;
       }
       public ResultDto Execute(int ProductId)
       {

          
           var product = _context.Products.Find(ProductId);

           if (product == null)
           {
               return new ResultDto()
               {
                   IsSuccess = false,
                   Message = "محصول با این مشخصات پیدا نشد"
               };
           }
           product.IsRemoved = true;
           product.RemoveTime=DateTime.Now;
           _context.SaveChanges();
           return new ResultDto()
           {
               IsSuccess = true,
               Message = "محصول با موفقیت حذف گردید"

           };



       }
   }
}
