using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Services.Sliders.PanelAdmin.Command.AddNewSlider;
using DigiMarket.Application.Services.Sliders.PanelAdmin.Command.DeleteSlider;
using DigiMarket.Application.Services.Sliders.PanelAdmin.Queries.GetSlider;

namespace DigiMarket.Application.Interfaces.FacadPatterns.SliderFacad.PanelAdmin
{
   public interface ISliderFacad_Admin
    {
        AddNewSliderService AddNewSliderService { get;  }
        GetSliderService GetSliderService { get; }
        DeleteSliderService DeleteSliderService { get; }
    }
}
