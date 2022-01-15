using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Services.HomePage.PanelAdmin.Command.AddNewHomePageImages;
using DigiMarket.Application.Services.HomePage.PanelAdmin.Command.DeleteHomePageImages;
using DigiMarket.Application.Services.HomePage.PanelAdmin.Queries.GetHomePageImages;

namespace DigiMarket.Application.Interfaces.FacadPatterns.HomePage.PanelAdmin
{
  public  interface IHomeFacad_Admin
  {
      AddNewHomePageImages AddNewHomePageImages { get; }
      GetHomePageImagesService GetHomePageImagesService { get; }

      DeleteHomePageImages DeleteHomePageImages { get; }
    }
}
