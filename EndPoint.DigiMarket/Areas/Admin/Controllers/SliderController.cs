using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.FacadPatterns.SliderFacad.PanelAdmin;
using DigiMarket.Application.Services.Sliders.PanelAdmin.Queries.GetSlider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace EndPoint.DigiMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin ,Operator")]

    public class SliderController : Controller
    {
        private ISliderFacad_Admin _sliderFacadAdmin;

        public SliderController(ISliderFacad_Admin sliderFacadAdmin)
        {
            _sliderFacadAdmin = sliderFacadAdmin;
        }
        public IActionResult Index(string serchkey, int page = 1)
        {

         var sliders=   _sliderFacadAdmin.GetSliderService.Execute(new RequestGetSlidersDto()
            {
                Page = page,
                SearchKey = serchkey
            });
            return View(sliders);
        }

        public IActionResult AddSlider()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSlider(IFormFile file , string link)
        {

            _sliderFacadAdmin.AddNewSliderService.Execute(file, link);
            return View();
        }

        public IActionResult DeleteSlider(int Id)

        {
            //_sliderFacadAdmin.DeleteSliderService.Execute(Id);
            //return Redirect("https://localhost:44340/admin/Slider/Index");


            return Json(_sliderFacadAdmin.DeleteSliderService.Execute(Id));
        }

    }
}
