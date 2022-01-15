using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Services.Sliders.Site.Queries.GetSlider;
using DigiMarket.Common;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Sliders.PanelAdmin.Queries.GetSlider
{
    public interface IGetSliderService
    {
        ResultDto<ResualtGetSlidersDto> Execute(RequestGetSlidersDto request);
    }

    public class GetSliderService : IGetSliderService
    {
        private IDigiMarketContext _context;

        public GetSliderService(IDigiMarketContext context)
        {
            _context = context;
        }

        public ResultDto<ResualtGetSlidersDto> Execute(RequestGetSlidersDto request)
        {

            var sliders = _context.Sliders.AsQueryable();


            if (! string.IsNullOrEmpty(request.SearchKey))
            {
                sliders = sliders.Where(p => p.Link.Contains(request.SearchKey));
            }


            int rowCount = 0;

            var listSlider = sliders.ToPaged(request.Page, 20, out rowCount).Select(p => new GetSlidersDto()
            {
                ClickCount = p.ClickCount,
                Link = p.Link,
                Src = p.Src,
                Id = p.KeyId
            }).ToList();



            return new ResultDto<ResualtGetSlidersDto>()
            {
                Data = new ResualtGetSlidersDto()
                {
                    Rows = rowCount,
                    sliders = listSlider
                },
                IsSuccess = true,
                Message = "ob"
            };

        }

    }


    public class GetSlidersDto
    {
        public int Id { get; set; }
        public int ClickCount { get; set; }
        public string Src { get; set; }
        public string Link { get; set; }
        
    }

    public class RequestGetSlidersDto
    {
        public string SearchKey { get; set; }
        public int Page { get; set; }

    }

    public class ResualtGetSlidersDto
    {
        public List<GetSlidersDto> sliders { get; set; }
        public int Rows { get; set; }
    }
}
