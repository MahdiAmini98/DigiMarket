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
   public class Category:BaseEntity
    {
        [Key]
        public int CategoryId { get; set; }
        [Display(Name = "عنوان گروه")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1} کارکتر باشد")]
        public string CategoryName { get; set; }
        public int? ParentId { get; set; }


        #region Relations
        //یک دسته بندی میتواند لیستی از دسته بندی ها را به عنوان زیر گروه خود داشته باشد
        public virtual ICollection<Category> SubCategories { get; set; }
            [ForeignKey("ParentId")]
        //یک دسته بندی می تواند یک پدر یا پرنت داشته باشد/البته بعضی دسته بندی ها که خود پدر هستند پرنت آیدی نال دارند
        public virtual Category ParentCategory { get; set; }

        #endregion
    }
}
