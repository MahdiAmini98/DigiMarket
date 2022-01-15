using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Products.PanelAdmin.Command.DeleteImageProduct
{
  public  interface IDeleteImageProductService
  {
      ResultDto Execute(int Id);

  }


  public class DeleteImageProductService : IDeleteImageProductService
  {
      private IDigiMarketContext _context;

      public DeleteImageProductService(IDigiMarketContext context)
      {
          _context = context;
      }
      public ResultDto Execute(int Id)
      {
          var img = _context.ProductImages.Find(Id);

          if (img == null)
          {
              return new ResultDto()
              {
                  IsSuccess = false,
                  Message = "عکس یافت نشد"
              };
          }

          img.IsRemoved = true;
          img.RemoveTime = DateTime.Now;
          _context.SaveChanges();

          return new ResultDto()
          {
              IsSuccess = true,
              Message = " عملیات با موفقیت انجام شد"
          };

        }
    }
}
