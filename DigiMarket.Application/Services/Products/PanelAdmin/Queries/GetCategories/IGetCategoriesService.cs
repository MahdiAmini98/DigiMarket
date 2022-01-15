using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.Products.Queries.GetCategories
{
    public interface IGetCategoriesService
    {
        ResultDto<List<CategoriesDto>> Excute(int? ParentId);
    }


    public class GetCategoriesService : IGetCategoriesService
    {
        private IDigiMarketContext _context;

        public GetCategoriesService(IDigiMarketContext context)
        {
            _context = context;
        }
        public ResultDto<List<CategoriesDto>> Excute(int? ParentId)
        {

            var categories = _context.Categories
                .Include(p => p.ParentCategory)//اگه پدری داشته باشه پدرشو بدست میاره
                .Include(p => p.SubCategories)//فرزند هاشو بدست آورد
                .Where(p => p.ParentId == ParentId)//در این مرحله اگه  پرنت آیدی نال باشد لیست پدرها را بهمون نشون میده ولی اگه پرنت آیدی مقدار داشته باشد لیست فرزند های آن پرنت آیدی را برایمان لیست می کند
                .ToList()
                .Select(p => new CategoriesDto()
                {
                    Id = p.CategoryId,
                    Name = p.CategoryName,
                    Parent = p.ParentCategory != null
                        ? new ParentCategoryDto()
                        {
                            Id = p.ParentCategory.CategoryId,
                            Name = p.ParentCategory.CategoryName
                        }
                        : null,
                    HasChild = p.SubCategories.Count() >0 ? true : false,//اگر ساب کتگوری بزرگ تر از صفر بود ینی دارای فرزند است پس تورو برگشت میدهد ولی اگه ساب کتگوری صفر بود ینی فرزند تدارد و فالس برگشت می دهد

                }).ToList();

            return new ResultDto<List<CategoriesDto>>()
            {
                Data = categories,
                IsSuccess = true,
                Message = "لیست باموقیت برگشت داده شد"
            };

        }
    }
    public class CategoriesDto
    {
        //آیدی دسته بندی
        public int Id { get; set; }
        //نام دسته بندی
        public string Name { get; set; }
        //مشخص می کند این دسته بندی فرزندی دارد یا خیر
        public bool HasChild { get; set; }
        //اطلاعات پدر این دسته بندی
        public ParentCategoryDto Parent { get; set; }
    }

    //اطلاعات پدر  را در این کلاس ذخیره میکنم
    public class ParentCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
