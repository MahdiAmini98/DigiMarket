using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.FacadPatterns.HomePage.PanelAdmin;
using DigiMarket.Application.Services.HomePage.PanelAdmin.Command.AddNewHomePageImages;
using DigiMarket.Domain.Entities.Home_Page_Images;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace EndPoint.DigiMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Operator")]
    public class HomePageImagesController : Controller
    {
        private IHomeFacad_Admin _homeFacadAdmin;

        public HomePageImagesController(IHomeFacad_Admin homeFacadAdmin)
        {
            _homeFacadAdmin = homeFacadAdmin;
        }

        public IActionResult Index(int Page = 1, int PageSize = 20)
        {
           var result= _homeFacadAdmin.GetHomePageImagesService.Execute(Page ,PageSize).Data;
            return View(result);
        }



        public IActionResult DeleteImages(int Id)
        {

            return Json(_homeFacadAdmin.DeleteHomePageImages.Execute(Id));
        }


        public IActionResult AddImages()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddImages(IFormFile file , string link ,ImageLocation location)
        {
            _homeFacadAdmin.AddNewHomePageImages.Execute(new RequestHomePageImagesDto()
            {
                File = file,
                ImageLocation = location,
                Link = link
            });

            return View();
        }
    }
}
