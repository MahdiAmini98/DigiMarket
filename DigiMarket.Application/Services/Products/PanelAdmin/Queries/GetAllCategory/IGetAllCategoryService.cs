using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.Products.Queries.GetAllCategory
{
  public interface IGetAllCategoryService
  {
      ResultDto<List<RequestGetAllCategoryDto>> Execute();
  }

  public class GetAllCategoryService : IGetAllCategoryService
  {
      private readonly IDigiMarketContext _context;

      public GetAllCategoryService(IDigiMarketContext context)
      {
          _context = context;
      }
      public ResultDto<List<RequestGetAllCategoryDto>> Execute()
      {
          var categoris = _context.Categories
              .Include(c => c.ParentCategory)
              .Where(c => c.ParentId != null).Select(c =>
              new RequestGetAllCategoryDto()
              {
                  Id = c.CategoryId,
                  Name = $"{c.ParentCategory.CategoryName} - {c.CategoryName} "
              }).ToList();
          return new ResultDto<List<RequestGetAllCategoryDto>>()
          {
              Data = categoris,
              IsSuccess = true,
              Message = "دسته بندی  ها از دیتا بیس واکشی شده اند"
          };

      }
  }

  public class RequestGetAllCategoryDto
  {
      public int Id { get; set; }
      public string Name { get; set; }
  }
}
