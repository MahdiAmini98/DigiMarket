using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Interfaces.FacadPatterns.SliderFacad.PanelAdmin;
using DigiMarket.Application.Services.Products.PanelAdmin.Command.AddNewProduct;
using DigiMarket.Application.Services.Sliders.PanelAdmin.Command.AddNewSlider;
using DigiMarket.Application.Services.Sliders.PanelAdmin.Command.DeleteSlider;
using DigiMarket.Application.Services.Sliders.PanelAdmin.Queries.GetSlider;
using Microsoft.AspNetCore.Hosting;

namespace DigiMarket.Application.Services.Sliders.PanelAdmin.FacadPattern
{
   public class SliderFacad_Admin: ISliderFacad_Admin
    {
        private readonly IDigiMarketContext _context;
        private readonly IHostingEnvironment _environment;

        public SliderFacad_Admin(IDigiMarketContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }


        private AddNewSliderService _addNewSliderService;

        public AddNewSliderService AddNewSliderService
        {
            get
            {
                return _addNewSliderService = _addNewSliderService ?? new AddNewSliderService(_context, _environment);
            }
        }


        private GetSliderService _getSliderService;

        public GetSliderService GetSliderService
        {
            get
            {
                return _getSliderService = _getSliderService ?? new GetSliderService(_context);
            }

        }


        private DeleteSliderService _deleteSliderService;

        public DeleteSliderService DeleteSliderService
        {
            get
            {
                return _deleteSliderService = _deleteSliderService ?? new DeleteSliderService(_context);
            }

        }
    }
}
