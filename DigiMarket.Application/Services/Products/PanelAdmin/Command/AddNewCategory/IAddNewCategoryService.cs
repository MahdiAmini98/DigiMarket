using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;
using DigiMarket.Domain.Entities.Prouduct;

namespace DigiMarket.Application.Services.Products.PanelAdmin.Command.AddNewCategory
{
   public interface IAddNewCategoryService
   {
       ResultDto Excute(int? ParentId, string Name);
   }


   public class AddNewCategoryService : IAddNewCategoryService
   {
       private IDigiMarketContext _context;

       public AddNewCategoryService(IDigiMarketContext context)
       {
           _context = context;
       }
       public ResultDto Excute(int? ParentId, string Name)
       {
           if (string.IsNullOrEmpty(Name))
           {
               return new ResultDto()
               {
                   IsSuccess = false,
                   Message = "نام دسته بندی را وارد کنید"
               };
           }


           Category category = new Category()
           {
               CategoryName = Name,
               ParentCategory = GetParent(ParentId)
           };

           _context.Categories.Add(category);
           _context.SaveChanges();


           return new ResultDto()
           {
               IsSuccess = true,
               Message = "دسته با موفقیت اضافه شد"
           };

       }

       private Category GetParent(int? ParentId)
       {
           return _context.Categories.Find(ParentId);
       }
   }

}
