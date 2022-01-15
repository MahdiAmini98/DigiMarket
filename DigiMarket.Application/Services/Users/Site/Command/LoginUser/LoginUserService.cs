using System.Collections.Generic;
using System.Linq;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;
using DigiMarket.Common.PasswordHasher;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.Users.Command.LoginUser
{
    public class LoginUserService : ILoginUserService
    {
        private IDigiMarketContext _context;

        public LoginUserService(IDigiMarketContext context)
        {
            _context = context;
        }
        public ResultDto<ResultLoginUserDto> Excute(string UserName, string Password)
        {

            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
            {
                return new ResultDto<ResultLoginUserDto>()
                {
                    Data = { },
                    IsSuccess = false,
                    Message = "لطقا اطلاعات مورد نیاز را تکمیل کنید"
                };
            }


            var user = _context.Users
                .Include(p => p.UserRoles)
                .ThenInclude(p => p.Role)
                .Where(p => p.Email.Equals(UserName)
                            && p.IsActive == true)
                .FirstOrDefault();


            if (user == null)
            {
                return new ResultDto<ResultLoginUserDto>()
                {
                    Data = { },
                    IsSuccess = false,
                    Message = "کاربری با این مشخصات ثبت نام نکرده است"
                };
            }


            // مورد بررسی قرار میگیرد اگر پسورد وارد شده در لاگین همان پسورد هش شده بود اچازه لاگین کردن می دهد VerifyPasswordدر کدهای پایین پسورد کاربر که در دیتا بیس هش شده است از طریق متد  


            var passwordhaser = new PasswordHasher();

            bool resultVerifyPassword = passwordhaser.VerifyPassword(user.Password, Password);

            if (resultVerifyPassword == false)
            {
                return new ResultDto<ResultLoginUserDto>()
                {
                    Data = { },
                    IsSuccess = false,
                    Message = "پسورد وارد شده اشتباه است"
                };
            }


            List<string> roles = new List<string>();

            foreach (var item in user.UserRoles)
            {
                roles.Add(item.Role.RoleTittle);

            }


            return new ResultDto<ResultLoginUserDto>()
            {
                Data = new ResultLoginUserDto()
                {
                    Name = user.FullName,
                    Roles = roles,
                    UserId = user.KeyId
                },
                IsSuccess = true,
                Message = "کاربر با موفقیت وارد شد"
            };

        }

    }
}