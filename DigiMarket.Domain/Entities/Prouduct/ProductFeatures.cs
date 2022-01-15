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
    public class ProductFeatures:BaseEntity
    {
        [Key]
        public int ProductFeaturesId { get; set; }
        public string DisPlayName { get; set; }
        public string Value { get; set; }
        public int ProductId { get; set; }


        #region Relations
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        

        #endregion
    }
}
