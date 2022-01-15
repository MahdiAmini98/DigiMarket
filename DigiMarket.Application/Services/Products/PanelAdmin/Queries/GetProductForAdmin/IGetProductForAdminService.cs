using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common;
using DigiMarket.Common.Dto;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.Products.Queries.GetProductForAdmin
{
  public interface IGetProductForAdminService
  {
      ResultDto<ProductForAdminDto> Execute(int page = 1 , int pageSize =20);
  }

    public class GetProductForAdminService : IGetProductForAdminService
    {
        private IDigiMarketContext _context; 

        public GetProductForAdminService(IDigiMarketContext context)
        {
            _context = context;
        }
        public ResultDto<ProductForAdminDto> Execute(int page = 1, int pageSize = 20)
        {

            int rowCount = 0;

            var products = _context.Products.Include(p => p.Category)
                .ToPaged(page, pageSize, out rowCount).Select(p =>
                new ProductForAdminList_Dto()
                {
                    ProductId = p.ProductId,
                    Name = p.ProductName,
                    Category = p.Category.CategoryName,
                    Brand = p.Brand,
                    Description = p.Description,
                    Price = p.Price,
                    Inventory = p.Inventory,
                    Displayed = p.Displayed
                }).ToList();

            return new ResultDto<ProductForAdminDto>()
            {
                Data = new ProductForAdminDto()
                {
                    CurrentPage = page,
                    RowCount = rowCount,
                    PageSize = pageSize,
                    Products = products
                },
                IsSuccess = true,
                Message = "عملیات با موفقیت انجام شد"

            };

        }
    }

    public class ProductForAdminDto
  {
      //تعداد کل صفحات را برگشت می دهد که در نوار صفحه بندی مشخص شود چند صفحه را نشان دهد.
      //مثلا اگر کلا دو صفحه داشتیم در نوار صغحه بندی در یوآی فقط دو صفحه را نشان می دهد
      public int RowCount { get; set; }
      public int CurrentPage { get; set; }
      //در هر صفحه چند محصول نشان بدهد؟
      public int PageSize { get; set; }
      public List<ProductForAdminList_Dto> Products { get; set; }

  }

  public class ProductForAdminList_Dto
  {
      public int ProductId { get; set; }
      public string Name { get; set; }
      public string Category { get; set; }
      public string Brand { get; set; }
      public string Description { get; set; }
      public int Price { get; set; }
      public int Inventory { get; set; }
      public bool Displayed { get; set; }

  }
}
