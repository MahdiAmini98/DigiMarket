using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Interfaces.FacadPatterns.HomePage.PanelAdmin;
using DigiMarket.Application.Services.HomePage.PanelAdmin.Command.AddNewHomePageImages;
using DigiMarket.Application.Services.HomePage.PanelAdmin.Command.DeleteHomePageImages;
using DigiMarket.Application.Services.HomePage.PanelAdmin.Queries.GetHomePageImages;
using Microsoft.AspNetCore.Hosting;

namespace DigiMarket.Application.Services.HomePage.PanelAdmin.FacadPattern
{
    public class HomeFacad_Admin :IHomeFacad_Admin
    {
        private readonly IDigiMarketContext _context;
        private readonly IHostingEnvironment _environment;

        public HomeFacad_Admin(IDigiMarketContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }


        private AddNewHomePageImages _addNewHomePageImages;

        public AddNewHomePageImages AddNewHomePageImages
        {
            get
            {
                return _addNewHomePageImages = _addNewHomePageImages ?? new AddNewHomePageImages(_context, _environment);
            }

        }


        private GetHomePageImagesService _getHomePageImagesService;

        public GetHomePageImagesService GetHomePageImagesService
        {
            get
            {
                return _getHomePageImagesService = _getHomePageImagesService ?? new GetHomePageImagesService(_context);
            }
        }


        private DeleteHomePageImages _deleteHomePageImages;

        public DeleteHomePageImages DeleteHomePageImages
        {
            get
            {
                return _deleteHomePageImages = _deleteHomePageImages ?? new DeleteHomePageImages(_context);
            }
        }
    }
}
