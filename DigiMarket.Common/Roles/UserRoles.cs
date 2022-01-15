using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiMarket.Common.Roles
{
    //این کلاس برای این ایجاد شد که زمانی که در بستر ارتباطی خود میخاهیم برای حدول نقش ها مقدار های زیر را سید کنیم از ایم کلاس و مقادیری که در تین کلاس است استفاده کنیم
    //const=برای متغیرهایی استفاده می شود که ثابت هستند .ینی مقدارآن ها هیچ وقت تغییر نمی کند
    public class UserRoles
   {
       public const string Admin = "Admin";
       public const string Operator = "Operator";
       public const string Customer = "Customer";
   }
}
