using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.FacadPatterns;
using DigiMarket.Application.Interfaces.FacadPatterns.ProductFacad.PanelAdmin;
using DigiMarket.Application.Services.Products.PanelAdmin.Command.AddNewProduct;
using DigiMarket.Application.Services.Products.PanelAdmin.Command.UpdateProduct;
using DigiMarket.Application.Services.Products.Queries.GetAllCategory;
using DigiMarket.Application.Services.Products.Queries.GetProductDetailForAdmin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using AddNewProduct_Features = DigiMarket.Application.Services.Products.PanelAdmin.Command.AddNewProduct.AddNewProduct_Features;

namespace EndPoint.DigiMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Operator")]
    public class ProductController : Controller
    {
        private IProductFacad_Admin _productFacadAdmin;

        public ProductController(IProductFacad_Admin productFacadAdmin)
        {
            _productFacadAdmin = productFacadAdmin;
        }

      
        public IActionResult Index(int Page= 1 , int PageSize = 20)
        {
            return View(_productFacadAdmin.GetProductForAdminService.Execute(Page,PageSize).Data);
        }

        [HttpGet]
        public IActionResult AddNewProduct()
        {
            ViewBag.Category = new SelectList(_productFacadAdmin.GetAllCategoryService.Execute().Data,"Id" ,"Name");
            return View();
        }

        [HttpPost]
        public IActionResult AddNewProduct(RequestAddNewProductDto request , List<AddNewProduct_Features> features)
        {

            List<IFormFile> images = new List<IFormFile>();

            for (int i = 0; i < Request.Form.Files.Count; i++)
            {
                var file = Request.Form.Files[i];
                images.Add(file);
            }

            request.Images = images;
            request.Features = features;
            return Json(_productFacadAdmin.AddNewProductService.Execute(request));

        }

        public IActionResult Detail(int Id)
        {
            return View(_productFacadAdmin.GetProductDetailForAdminService.Execute(Id).Data);
        }

        [HttpPost]
        public IActionResult Remove(int productId)
        {
            return Json(_productFacadAdmin.RemoveProductService.Execute(productId));
        }


        [HttpGet]
        public IActionResult EditProduct(int Id)
        {
            ViewBag.Category = new SelectList(_productFacadAdmin.GetAllCategoryService.Execute().Data, "Id", "Name");

            return View(_productFacadAdmin.GetProductDetailForAdminService.Execute(Id).Data);
        }


        [HttpPost]

        public IActionResult EditProduct(RequestUpdateProductDto request, List<AddNewProduct_Features> features)
        {

            List<IFormFile> images = new List<IFormFile>();

            for (int i = 0; i < Request.Form.Files.Count; i++)
            {
                var file = Request.Form.Files[i];
                images.Add(file);
            }

            request.Images = images;
            request.Features = features;
            return Json(_productFacadAdmin.UpdateProductService.Execute(request));

          

        }

        [HttpPost]

        public IActionResult DeleteProductImage(int Id)
        {
            return Json(_productFacadAdmin.DeleteImageProductService.Execute(Id));
        }

       
        public IActionResult DeleteProductFeature(int Id)
        {

           return Json(_productFacadAdmin.DeleteFeatureProductService.Execute(Id));
        }
    }
    

}
