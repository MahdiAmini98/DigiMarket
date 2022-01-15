﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Domain.Entities.Commons;

namespace DigiMarket.Domain.Entities.Home_Page_Images
{
   public class HomePageImages:BaseEntity
    {
        public string Src { get; set; }
        public string Link { get; set; }
        public ImageLocation ImageLocation { get; set; }
    }

   public enum ImageLocation
   {
     L1=0,
     L2=1,
     R1=2,
     CenterFullScreen=3,
     G1=4,
     G2=5,
   }
}
