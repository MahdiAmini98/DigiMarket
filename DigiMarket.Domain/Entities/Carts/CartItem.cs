using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Domain.Entities.Commons;
using DigiMarket.Domain.Entities.Prouduct;

namespace DigiMarket.Domain.Entities.Carts
{
  public  class CartItem:BaseEntity
    {

        public int ProductId { get; set; }
        public int CartId { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }

        #region Relation

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [ForeignKey("CartId")]

        public virtual Cart Cart { get; set; }

        #endregion
    }
}
