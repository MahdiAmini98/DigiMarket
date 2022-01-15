using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Services.Products.PanelAdmin.Command.AddNewProduct;
using DigiMarket.Common.Dto;
using DigiMarket.Domain.Entities.Home_Page_Images;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace DigiMarket.Application.Services.HomePage.PanelAdmin.Command.AddNewHomePageImages
{
   public interface IAddNewHomePageImages
   {
       ResultDto Execute(RequestHomePageImagesDto request);
   }

   public class AddNewHomePageImages : IAddNewHomePageImages
   {
       private IDigiMarketContext _context;
       private IHostingEnvironment _environment;

       public AddNewHomePageImages(IDigiMarketContext context, IHostingEnvironment environment)
       {
           _context = context;
           _environment = environment;
       }

       public ResultDto Execute(RequestHomePageImagesDto request)
       {
           var resultUpload = UploadFile(request.File);

           HomePageImages homePageImages = new HomePageImages()
           {
               ImageLocation = request.ImageLocation,
               Link = request.Link,
               Src = resultUpload.FileNameAddress
           };

           _context.HomePageImages.Add(homePageImages);
           _context.SaveChanges();


           return new ResultDto()
           {
               IsSuccess = true,
               Message = " اطلاعات با موفیت در پایگاه داده اضافه شد"
           };
       }

       #region UploadFile

       //متد آپلود عکس محصولات
       private UploadDto UploadFile(IFormFile file)
       {
           if (file != null)
           {
               string folder = $@"images\HomePage\Images\";
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



    public class RequestHomePageImagesDto
   {
       public IFormFile File { get; set; }
       public string Link { get; set; }
       public ImageLocation ImageLocation{ get; set; }
   }
}
