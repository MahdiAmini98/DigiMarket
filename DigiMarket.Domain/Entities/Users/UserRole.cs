using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiMarket.Domain.Entities.Users
{
   public class UserRole
    {
        [Key]
        public int UR_Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        #region Relation

        public virtual User User { get; set; }
        public virtual Role Role { get; set; }

        #endregion
    }
}
