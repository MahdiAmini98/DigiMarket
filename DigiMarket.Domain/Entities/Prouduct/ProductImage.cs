using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Domain.Entities.Commons;

namespace DigiMarket.Domain.Entities.Prouduct
{
   public class ProductImage:BaseEntity
    {
        [Key]
        public int ProductImageId { get; set; }
        //آدرس تصویر در این فیلد ذخیره می شود
        public string Src { get; set; }
        public int ProductId { get; set; }


        #region Relations
        [ForeignKey("ProductId")]
        public virtual  Product Product { get; set; }

        #endregion
    }
}
