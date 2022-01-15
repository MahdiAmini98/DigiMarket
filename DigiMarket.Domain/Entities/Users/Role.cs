using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiMarket.Domain.Entities.Users
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Display(Name = "عنوان نقش")]
        [Required(ErrorMessage = "لطفا{0}را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0}نمیتواند بیشتر از {1} کارکتر باشد")]
        public string RoleTittle { get; set; }
           

        #region Relation

        public IEnumerable<UserRole> UserRoles { get; set; }


        #endregion
    }
}
