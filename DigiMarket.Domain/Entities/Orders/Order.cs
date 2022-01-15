using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Domain.Entities.Commons;
using DigiMarket.Domain.Entities.Finances;
using DigiMarket.Domain.Entities.Users;

namespace DigiMarket.Domain.Entities.Orders
{
  public class Order:BaseEntity
    {
        public int UserId { get; set; }
        public int RequestPayId { get; set; }
        public OrderState OrderState { get; set; }
        [MaxLength(50000)]
        public string Address { get; set; }


        #region Relations

        [ForeignKey("UserId")]

        public virtual User User { get; set; }
        [ForeignKey("RequestPayId")]
        public virtual  RequestPay RequestPay { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        
        #endregion

        
    }

  // وضعیت فاکتور : نشان می دهد فاکتور مشتری در حال حاضر در چه مرحله ای قرار دارد
  public  enum OrderState
  {
   
      //سفارش در حال پردازش است
      [Display(Name = "در حال پردازش")]
      Processing=0 ,

        //سفارش لغو شده
        [Display(Name = "لغو شده")]

        Canceled = 1 ,


        //سفارش تحویل داده شده
        [Display(Name = "تحویل داده شده")]

        Delivered = 2
  }
}
