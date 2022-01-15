using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Domain.Entities.Commons;

namespace DigiMarket.Domain.Entities.Slider
{
   public class Slider:BaseEntity
    {
        public string Link { get; set; }
        public string Src { get; set; }
        // تعداد بازدید های بنر -تعداد کلیک هایی که روی بنر می شود
        public int ClickCount { get; set; }

    }
}
