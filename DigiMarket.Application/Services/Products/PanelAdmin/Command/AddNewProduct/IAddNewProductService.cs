using System;
using System.Collections.Generic;
using System.IO;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;
using DigiMarket.Domain.Entities.Prouduct;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace DigiMarket.Application.Services.Products.PanelAdmin.Command.AddNewProduct
{
   public interface IAddNewProductService
   {
       ResultDto Execute( RequestAddNewProductDto request);
   }



   public class AddNewProductService : IAddNewProductService
   {
       private readonly IDigiMarketContext _context;
       private readonly IHostingEnvironment _environment;

        public AddNewProductService(IDigiMarketContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public ResultDto Execute(RequestAddNewProductDto request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "لطفا نام محصول را وارد کنید"
                };
            }


            try
            {

                var category = _context.Categories.Find(request.CategoryId);

                Product product = new Product()
                {

                    Brand = request.Brand,
                    Category = category,
                    Description = request.Description,
                    Displayed = request.Displayed,
                    ProductName = request.Name,
                    Inventory = request.Inventory,
                    InsertTime = DateTime.Now,
                    Price = request.Price,

                };
                _context.Products.Add(product);
               
                List<ProductImage> productImages = new List<ProductImage>();

                foreach (var item in request.Images)
                {

                    var uploadFile = UploadFile(item);
                    productImages.Add(new ProductImage()
                    {
                        Src = uploadFile.FileNameAddress,
                        Product = product
                    });
                }
                _context.ProductImages.AddRange(productImages);



                List<ProductFeatures> productFeatures = new List<ProductFeatures>();

                foreach (var item in request.Features)
                {

                    productFeatures.Add(new ProductFeatures()
                    {
                        DisPlayName = item.DisplayName,
                        Value = item.Value,
                        Product = product
                    });
                }
                _context.ProductFeatures.AddRange(productFeatures);


                _context.SaveChanges();

                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = "محصول با موفقیت اضافه شد"
                };

            }


            catch (Exception e)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "خطا رخ داد ",

                };
            }
        }



        #region UploadFile

        //متد آپلود عکس محصولات
        private UploadDto UploadFile(IFormFile file)
       {
           if (file != null)
           {
               string folder = $@"images\ProductImages\";
               var uploadsRootFolder = Path.Combine(_environment.WebRootPath, folder);
               if (!Directory.Exists(uploadsRootFolder))
               {
                   Directory.CreateDirectory(uploadsRootFolder);
               }


               if (file == null || file.Length == 0)
               {
                   return new UploadDto()
                   {
                       Status = false,
                       FileNameAddress = "",
                   };
               }

               string fileName = DateTime.Now.Ticks.ToString() + file.FileName;
               var filePath = Path.Combine(uploadsRootFolder, fileName);
               using (var fileStream = new FileStream(filePath, FileMode.Create))
               {
                   file.CopyTo(fileStream);
               }

               return new UploadDto()
               {
                   FileNameAddress = folder + fileName,
                   Status = true,
               };
           }
           return null;
       }

       #endregion

    }

    public class RequestAddNewProductDto
   {
       public string Name { get; set; }
       public string Brand { get; set; }
       public int Price { get; set; }
       public string Description { get; set; }
       public int Inventory { get; set; }
       public bool Displayed { get; set; }
       public int CategoryId { get; set; }
       public List<IFormFile> Images { get; set; }
       public List<AddNewProduct_Features> Features { get; set; }
   }

   public class AddNewProduct_Features
   {
       public string DisplayName { get; set; }
       public string Value { get; set; }

   }

   public class UploadDto
   {
       public long Id { get; set; }
       public bool Status { get; set; }
       public string FileNameAddress { get; set; }






    






}



    



}
