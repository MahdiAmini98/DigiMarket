using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EndPoint.DigiMarket.ClaimUtility
{

    //  ها بدست اوریم Claims کاربری که لاگین است را از طریق    userId با استفاده از این کلاس می توانیم
    //  
    // ها ذخیره شده و از این طریق می توانیم به آن ها دسترسی داشته باشیم Claims نکته)یادمان باشد آیدی و نام و نفش کاربری که در سایت لاگین است در 
    public static class ClaimUtility
    {
        public static int? GetUserId(ClaimsPrincipal User)
        {
            try
            {
                var claimsIdentity = User.Identity as ClaimsIdentity;

                if (claimsIdentity.FindFirst(ClaimTypes.NameIdentifier) != null)
                {
                    int userId = int.Parse(claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value);
                    return userId;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {

                return null;
            }

        }



        public static string GetUserEmail(ClaimsPrincipal User)
        {
            try
            {
                var claimsIdentity = User.Identity as ClaimsIdentity;

                if (claimsIdentity.FindFirst(ClaimTypes.NameIdentifier) != null)
                {
                    return claimsIdentity.FindFirst(ClaimTypes.Email).Value;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {

                return null;
            }

        }



        public static string GetUserName(ClaimsPrincipal User)
        {
            try
            {
                var claimsIdentity = User.Identity as ClaimsIdentity;

                if (claimsIdentity.FindFirst(ClaimTypes.NameIdentifier) != null)
                {
                    return claimsIdentity.FindFirst(ClaimTypes.Name).Value;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {

                return null;
            }

        }





        public static List<string> GetRoles(ClaimsPrincipal User)
        {
            try
            {
                var claimsIdentity = User.Identity as ClaimsIdentity;

                List<string> rolesList = new List<string>();

                foreach (var item in claimsIdentity.Claims.Where(p => p.Type.EndsWith("role"))) 
                {
                    rolesList.Add(item.Value );
                }

              return rolesList;
            }
            catch (Exception ex)
            {

                return null;
            }

        }

    }
}
