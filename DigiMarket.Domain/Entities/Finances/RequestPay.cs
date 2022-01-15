using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Domain.Entities.Commons;
using DigiMarket.Domain.Entities.Orders;
using DigiMarket.Domain.Entities.Users;

namespace DigiMarket.Domain.Entities.Finances
{
    // پیگیری درخاست
    public class RequestPay:BaseEntity
    {
        //کلیذ جدول
        public Guid GuidKey { get; set; }
        public int UserId { get; set; }
        public int Amount { get; set; }
        public bool IsPay { get; set; }
        public DateTime? PayTime { get; set; }
        //کلیدی که بعد از پرداخت مبلغ زرین پال برای پیگیری پرداخت انجام شده به ما برگشت می دهد که میتوانیم در این جدول ذخیره کنیم 
        public string Authority { get; set; }
        //کلیدی که بعد از پرداخت مبلغ زرین پال برای پیگیری پرداخت انجام شده به ما برگشت می دهد که میتوانیم در این جدول ذخیره کنیم 

        public int RefId { get; set; } = 0;

        #region Relations

        public virtual User Users { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        #endregion

    }
}
