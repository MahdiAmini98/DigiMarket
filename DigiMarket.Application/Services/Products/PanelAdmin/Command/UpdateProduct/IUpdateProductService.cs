using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;
using DigiMarket.Domain.Entities.Prouduct;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.Products.PanelAdmin.Command.UpdateProduct
{
    public interface IUpdateProductService
    {
        ResultDto Execute( RequestUpdateProductDto update);
    }


    public class UpdateProductService : IUpdateProductService
    {

        private readonly IDigiMarketContext _context;
        private readonly IHostingEnvironment _environment;

        public UpdateProductService(IDigiMarketContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public ResultDto Execute(RequestUpdateProductDto update)
        {

            //var product = _context.Products
            //    .Include(p=>p.ProductFeatures)
            //    .Include(p=>p.ProductImages)
            //    .Where(p=>p.ProductId == productId);


            Product product = _context.Products.Find(update.ProductId);
            if (update.ProductId != null)
            {

                if (string.IsNullOrWhiteSpace(update.Name) || string.IsNullOrWhiteSpace(update.Brand) ||
                    string.IsNullOrWhiteSpace(update.Description))

                {
                    return new ResultDto()
                    {
                        IsSuccess = false,
                        Message = "لطفا فیلدهای محصول را وارد کنید"
                    };

                }

                product.ProductName = update.Name;
                product.Price = update.Price;
                product.Brand = update.Brand;
                product.CategoryId = update.CategoryId;
                product.Description = update.Description;
                product.Inventory = update.Inventory;
                product.Displayed = update.Displayed;
                _context.Products.Update(product);
                _context.SaveChanges();



                if (update.Images != null)
                {


                    List<ProductImage> productImages = new List<ProductImage>();

                    foreach (var item in update.Images)
                    {

                        var uploadFile = UploadFile(item);
                        productImages.Add(new ProductImage()
                        {
                            Src = uploadFile.FileNameAddress,
                            Product = product
                        });
                    }

                    _context.ProductImages.UpdateRange(productImages);
                    _context.SaveChanges();

                }


                if (update.Features != null)
                {


                    List<ProductFeatures> productFeatures = new List<ProductFeatures>();

                    foreach (var item in update.Features)
                    {

                        productFeatures.Add(new ProductFeatures()
                        {
                            DisPlayName = item.DisplayName,
                            Value = item.Value,
                            Product = product
                        });
                    }

                    _context.ProductFeatures.UpdateRange(productFeatures);

                    _context.SaveChanges();

                }

                _context.Products.UpdateRange(product);
                _context.SaveChanges();


             

            }

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "عملیات موفقیت آمیز بود"
            };


        }



        #region UploadFile

        //متد آپلود عکس محصولات
        private AddNewProduct.UploadDto UploadFile(IFormFile file)
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
                    return new AddNewProduct.UploadDto()
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

                return new AddNewProduct.UploadDto()
                {
                    FileNameAddress = folder + fileName,
                    Status = true,
                };
            }
            return null;
        }

        #endregion
    }













    public class RequestUpdateProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int Inventory { get; set; }
        public bool Displayed { get; set; }
        public int CategoryId { get; set; }
        public List<IFormFile> Images { get; set; }
        public List<AddNewProduct.AddNewProduct_Features> Features { get; set; }
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
