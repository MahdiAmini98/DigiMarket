using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Services.Products.PanelAdmin.Command.AddNewProduct;
using DigiMarket.Common.Dto;
using DigiMarket.Domain.Entities.Slider;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Storage;

namespace DigiMarket.Application.Services.Sliders.PanelAdmin.Command.AddNewSlider
{
    public interface IAddNewSliderService
    {
        ResultDto Execute(IFormFile file,string link);
    }


    public class AddNewSliderService : IAddNewSliderService
    {
        private readonly IDigiMarketContext _context;
        private readonly IHostingEnvironment _environment;

        public AddNewSliderService(IDigiMarketContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }



        public ResultDto Execute(IFormFile file, string link)
        {

            var resultUpload = UploadFile(file);


            // Add Slider

            Slider  slider= new Slider()
            {
                Link = link,
                Src = resultUpload.FileNameAddress,
            
            };

            _context.Sliders.Add(slider);
            _context.SaveChanges();


            return new ResultDto()
            {
                IsSuccess = true,
                Message = "اسلایدر با موفقیت اضافه شد"
            };
        }

        #region UploadFile

        //متد آپلود عکس محصولات
        private UploadDto UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string folder = $@"images\HomePage\Sliders\";
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
}



