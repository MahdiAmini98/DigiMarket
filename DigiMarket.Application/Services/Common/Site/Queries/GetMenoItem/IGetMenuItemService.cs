using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.Common.Site.Queries.GetMenuItem
{
  public  interface IGetMenuItemService
  {
      ResultDto<List<MenuItemDto>> Execute();
  }

    public class GetMenuItemService : IGetMenuItemService
    {
        private IDigiMarketContext _context;

        public GetMenuItemService(IDigiMarketContext context)
        {
            _context = context;
        } 
        public ResultDto<List<MenuItemDto>> Execute()
        {
            var category = _context.Categories
                .Include(c => c.SubCategories).ToList()
                .Where(c=>c.ParentId==null)
                .Select(c => new MenuItemDto()
                {
                    CategoryId = c.CategoryId,
                    CategoryName = c.CategoryName,
                    ChildCategory = c.SubCategories.ToList().Select(child => new MenuItemDto() 
                    {
                        CategoryId = child.CategoryId,
                        CategoryName = child.CategoryName,

                    }).ToList()
                });

            return new ResultDto<List<MenuItemDto>>()
            {
                Data = category.ToList(),
                IsSuccess = true,
                Message = "دسته بندی ها و زیر دسته ها برای ایجاد منو استخراج شد"
            };

        }
    }


    public class MenuItemDto : IEnumerable
    {
      public int CategoryId { get; set; }
      public string CategoryName { get; set; }
      public List<MenuItemDto> ChildCategory { get; set; }
      public IEnumerator GetEnumerator()
      {
          throw new NotImplementedException();
      }
    }
}
