using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Products.PanelAdmin.Command.DeleteFeatureProduct
{
  public  interface IDeleteFeatureProductService
  {
      ResultDto Execute(int Id);
  }

  public class DeleteFeatureProductService : IDeleteFeatureProductService
  {
      private IDigiMarketContext _context;

      public DeleteFeatureProductService(IDigiMarketContext context)
      {
          _context = context;
      }
      public ResultDto Execute(int Id)
      {
          var feature = _context.ProductFeatures.Find(Id);

          if (feature == null)
          {
              return new ResultDto()
              {
                  IsSuccess = false,
                  Message = "عکس یافت نشد"
              };
          }

          feature.IsRemoved = true;
          feature.RemoveTime = DateTime.Now;
          _context.SaveChanges();

          return new ResultDto()
          {
              IsSuccess = true,
              Message = " عملیات با موفقیت انجام شد"
          };
        }
  }
}
