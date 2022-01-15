using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.FacadPatterns;
using DigiMarket.Application.Interfaces.FacadPatterns.ProductFacad.PanelAdmin;
using Microsoft.AspNetCore.Authorization;

namespace EndPoint.DigiMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoriesController : Controller
    {
        private IProductFacad_Admin _productFacadAdmin;

        public CategoriesController(IProductFacad_Admin productFacadAdmin)
        {
            _productFacadAdmin = productFacadAdmin;
        }
        public IActionResult Index(int? parentId)
        {
            return View(_productFacadAdmin.GetCategoriesService.Excute(parentId).Data);
        }

        [HttpGet]
        public IActionResult AddNewCategory(int? ParentId)
        {
            ViewBag.parentId = ParentId;
            return View();
        }


        [HttpPost]
        public IActionResult AddNewCategory(int? ParentId, string Name)
        {
          var  result = _productFacadAdmin.AddNewCategoryService.Excute(ParentId, Name);
            return Json(result);
        }

        [HttpPost]
        public IActionResult DeleteCategory(int categoryId)
        {
            return Json(_productFacadAdmin.DeleteCategoryService.Execute(categoryId));

        }
    }
}
