using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Common.Site.Queries.GetCategoryForSearch
{
 public interface IGetCategoryForSearchService
 {
     ResultDto<List<CategoryItemForSearchDto>> Execute();
 }

    public class GetCategoryForSearchService : IGetCategoryForSearchService
    {
        private IDigiMarketContext _context;

        public GetCategoryForSearchService(IDigiMarketContext context)
        {
            _context = context;
        }
        public ResultDto<List<CategoryItemForSearchDto>> Execute()
        {
            var category = _context.Categories.Where(p => p.ParentId  == null)
                .ToList().Select(p => new CategoryItemForSearchDto()
                {
                    CategoryId = p.CategoryId,
                    CategoryName = p.CategoryName
                }).ToList();

            return new ResultDto<List<CategoryItemForSearchDto>>()
            {
                Data = category,
                IsSuccess = true,
                Message = "اطلاعات دسته بندی واکشی شد"
            };
        }
    }
    public class CategoryItemForSearchDto
 {
     public int CategoryId { get; set; }
     public string CategoryName { get; set; }
 }
}
