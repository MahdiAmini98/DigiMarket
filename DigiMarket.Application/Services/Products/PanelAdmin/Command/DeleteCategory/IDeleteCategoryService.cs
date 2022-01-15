using System;
using System.Linq;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Products.PanelAdmin.Command.DeleteCategory
{
    public interface IDeleteCategoryService
    {
        ResultDto Execute(int CategoryId);



    }

    public class DeleteCategoryService : IDeleteCategoryService
    {
        private IDigiMarketContext _context;

        public DeleteCategoryService(IDigiMarketContext context)
        {
            _context = context;
        }
        public ResultDto Execute(int CategoryId)
        {
            var category = _context.Categories.Find(CategoryId);

            if (category == null)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "دسته بندی یافت نشد"
                };
            }

            if (category.ParentId !=null)
            {
                category.IsRemoved = true;
                category.RemoveTime = DateTime.Now;
                _context.SaveChanges();
            }

            if (category.ParentId == null)
            {


                var sub = _context.Categories.Where(c => c.ParentId == CategoryId).ToList();
                foreach (var subcategory in sub)
                {
                    subcategory.IsRemoved = true;
                    subcategory.RemoveTime=DateTime.Now;
                    _context.SaveChanges();
                }


                category.IsRemoved = true;
                category.RemoveTime=DateTime.Now;
                _context.SaveChanges();

            }

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "دسته بندی و زیر دسته ها با موفقیت حذف شدند"
            };

        }
      
    }


}
