using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Sliders.PanelAdmin.Command.DeleteSlider
{
   public interface IDeleteSliderService
   {
       ResultDto Execute(int sliderId);
   }


   public class DeleteSliderService : IDeleteSliderService
   {
       private IDigiMarketContext _context;

       public DeleteSliderService(IDigiMarketContext context)
       {
           _context = context;
       }
       public ResultDto Execute(int sliderId)
       {
          
               var slider = _context.Sliders.Find(sliderId);

               if (slider == null)
               {
                   return new ResultDto()
                   {
                       IsSuccess = false,
                       Message = "اسلایدری یافت نشد"
                   };
               }

              slider.IsRemoved = true;
               slider.RemoveTime=DateTime.Now;
               _context.SaveChanges();

               return new ResultDto()
               {
                   IsSuccess = true,
                   Message = " عملیات با موفقیت انجام شد"
               };

       }
   }
}
