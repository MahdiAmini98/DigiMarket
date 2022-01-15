using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Services.Users.Queries.GetUsers;
using DigiMarket.Common.Dto;
using DigiMarket.Common.PasswordHasher;
using DigiMarket.Domain.Entities.Users;

namespace DigiMarket.Application.Services.Users.Command.CreateUser
{
    public class CreateUserService : ICreateUserService
    {
        private readonly IDigiMarketContext _context;

        public CreateUserService(IDigiMarketContext context)
        {
            _context = context;
        }

        public ResultDto<ResaultCreateUserDto> Excute(RequestCreateUserDto requestCreateUser)
        {

            try
            {

                if (string.IsNullOrEmpty(requestCreateUser.Email))
                {

                  return  new ResultDto<ResaultCreateUserDto>()
                    {
                        Data = new ResaultCreateUserDto()
                        {
                            UserId = 0
                        },
                        IsSuccess = false,
                        Message = "لطفا ایمیل خود را وارد کنید"

                    };
                }

              

                if (string.IsNullOrWhiteSpace(requestCreateUser.FullName))
                {

                 return   new ResultDto<ResaultCreateUserDto>()
                    {
                        Data = new ResaultCreateUserDto()
                        {
                            UserId = 0
                        },
                        IsSuccess = false,
                        Message = "لطفا نام خود را وارد کنید"

                    };

                }

                if (string.IsNullOrWhiteSpace(requestCreateUser.Password))
                {
                 return   new ResultDto<ResaultCreateUserDto>()
                    {
                        Data = new ResaultCreateUserDto()
                        {
                            UserId = 0
                        },
                        IsSuccess = false,
                        Message = "لطفا کلمه عبور خود را وارد کنید"
                    };
                }

                if (string.IsNullOrWhiteSpace(requestCreateUser.RePasword))
                {
                 return   new ResultDto<ResaultCreateUserDto>()
                    {
                        Data = new ResaultCreateUserDto()
                        {
                            UserId = 0
                        },
                        IsSuccess = false,
                        Message = "لطفا تکرار کلمه عبور را وارد کنید"
                    };
                }

                if (requestCreateUser.Password != requestCreateUser.RePasword)
                {
                   return new ResultDto<ResaultCreateUserDto>()
                    {
                        Data = new ResaultCreateUserDto()
                        {
                            UserId = 0
                        },
                        IsSuccess = false,
                        Message = "تکرار کلمه عبور با کلمه عبور مغایرت ندارد"
                    };
                }



                //فرمت نوشتاری ایمیل را چک می کند  و اگر ایمیلش اشتباه بود بهش پیغام می دهد

                string emailRegex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[A-Z0-9.-]+\.[A-Z]{2,}$";

                var match = Regex.Match(requestCreateUser.Email, emailRegex, RegexOptions.IgnoreCase);
                if (!match.Success)
                {
                    return new ResultDto<ResaultCreateUserDto>()
                    {
                        Data = new ResaultCreateUserDto()
                        {
                            UserId = 0,
                        },
                        IsSuccess = false,
                        Message = "ایمیل خودرا به درستی وارد نمایید"
                    };
                }



                var passwordHasher = new PasswordHasher();
               var hashPassword = passwordHasher.HashPassword(requestCreateUser.Password);





                User user = new User()
                {
                    CrateDateTime = DateTime.Now,
                    Email = requestCreateUser.Email,
                    FullName = requestCreateUser.FullName,
                    Password = hashPassword,
                    IsActive = true
                };
                List<UserRole> userrole = new List<UserRole>();

                foreach (var item in requestCreateUser.Roles)
                {
                    var roles = _context.Roles.Find(item.RoleId);

                    userrole.Add(new UserRole()
                    {
                        RoleId = roles.RoleId,
                        Role = roles,
                        User = user,
                        UserId = user.KeyId
                    });
                }

                user.UserRoles = userrole;
                _context.Users.Add(user);
                _context.SaveChanges();

                return new ResultDto<ResaultCreateUserDto>()
                {
                    Data = new ResaultCreateUserDto()
                    {
                        UserId = user.KeyId
                    },
                    IsSuccess = true,
                    Message = "ثبت نام کاربر انجام شد"
                };
            }
            catch (Exception)
            {

              return  new ResultDto<ResaultCreateUserDto>()
                {
                    Data = new ResaultCreateUserDto()
                    {
                        UserId = 0
                    },
                    IsSuccess = false,
                    Message = "ثبت نام انجام نشد..!"
                };
            }


        }
    }
}