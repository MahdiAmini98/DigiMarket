using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Domain.Entities.Commons;
using DigiMarket.Domain.Entities.Users;

namespace DigiMarket.Domain.Entities.Carts
{
   public class Cart:BaseEntity
    {
        public int? UserId { get; set; }
        //شناسه یا آیدی مرورگر کاربر ==> مرورگر کاربری که سبد خربد را ایجاد کرده مشخص می کند
        public Guid BrowserId { get; set; }
        //زمانی که سبد خریدی بسته شد و تسویه حساب شود true  بر گشت می دهد
        public bool Finished { get; set; }



        #region Relation

        [ForeignKey("UserId")]
        public User Users { get; set; }

        public ICollection<CartItem> Items { get; set; }
        #endregion
    }
}
