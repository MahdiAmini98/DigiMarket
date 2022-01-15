using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.HomePage.PanelAdmin.Command.DeleteHomePageImages
{
  public interface IDeleteHomePageImages
  {
      ResultDto Execute(int Id);
  }

  public class DeleteHomePageImages : IDeleteHomePageImages
  {
      private IDigiMarketContext _context;

      public DeleteHomePageImages(IDigiMarketContext context)
      {
          _context = context;
      }
      public ResultDto Execute(int Id)
      {
          var image = _context.HomePageImages.Find(Id);


          if (image == null)
          {
              return new ResultDto()
              {
                  IsSuccess = false,
                  Message = " عکس مورد نظر یافت نشد"
              };
          }

          image.RemoveTime =DateTime.Now;
          image.IsRemoved = true;
          _context.SaveChanges();


          return new ResultDto()
          {
              IsSuccess = true,
              Message = "عکس مورد نظر با موفقیت حذف گردید"
          };
      }
  }
}
