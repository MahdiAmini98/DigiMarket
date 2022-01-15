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
  public class Product:BaseEntity
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "عنوان محصول")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(450, ErrorMessage = "{0}نمیتواند بیشتر از {1} کارکتر باشد")]
        public string ProductName { get; set; }
        public string Brand { get; set; }
        [Display(Name = "توضیحات محصول")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        public string Description { get; set; }
        [Display(Name = "قیمت محصول")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        public int Price { get; set; }
        //تعداد موحودی محصول
        public int Inventory { get; set; }
        //آیا محصول در سایت نمایش داده شود یا خیر؟
        public bool Displayed { get; set; }
        //تعداد بازدید از هر محصول را برگشت می دهد(برای پیاده سازی قسمت مرتب سازی بر اساس پر بازدیدترین ها
        public int ViewCount { get; set; }
        public int CategoryId { get; set; }


        #region Relation
        //هر محصول می تواند یک دسته داشته باشد
       
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductFeatures> ProductFeatures { get; set; }
     

        #endregion
    }
}
