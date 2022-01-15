using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DigiMarket.Application.Services.Users.Command.CreateUser;
using DigiMarket.Application.Services.Users.Command.LoginUser;
using DigiMarket.Application.Services.Users.Queries.GetUsers;
using DigiMarket.Common.Dto;
using EndPoint.DigiMarket.ViewModel.AuthenticationViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace EndPoint.DigiMarket.Controllers
{
    public class AuthenticationController : Controller
    {
        private ICreateUserService _createUserService;
        private ILoginUserService _loginUserService;

        public AuthenticationController(ILoginUserService loginUserService, ICreateUserService createUserService)
        {
            _createUserService = createUserService;
            _loginUserService = loginUserService;
        }

        #region Sign Up

        [HttpGet]
        public IActionResult Signup()
        {
            return View();
           

        }



        [HttpPost]
        public IActionResult Signup( SignupViewModel signupViewModel)
        {

            if (string.IsNullOrWhiteSpace(signupViewModel.Email) || string.IsNullOrWhiteSpace(signupViewModel.FullName) || string.IsNullOrWhiteSpace(signupViewModel.Password) || string.IsNullOrWhiteSpace(signupViewModel.Repassword))
            {
                return Json(new ResultDto { IsSuccess = false, Message = "لطفا تمامی موارد رو ارسال نمایید" });
            }

            if (signupViewModel.Password != signupViewModel.Repassword)
            {
                return Json(new ResultDto {IsSuccess = false, Message = "کلمه عبور با تکرار آن مغایرت ندارد"});
            }

            if (User.Identity.IsAuthenticated == true)
            {
                return Json(new ResultDto
                {
                    IsSuccess = false,
                    Message = "شما به حساب کاربری خود وارد شده اید! و در حال حاضر نمیتوانید ثبت نام مجدد نمایید"
                });
            }

            if (signupViewModel.Password.Length < 8)
            {
                return Json(new ResultDto { IsSuccess = false, Message = "رمز عبور باید حداقل 8 کاراکتر باشد" });

            }

            string emailRegex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[A-Z0-9.-]+\.[A-Z]{2,}$";

            var match = Regex.Match(signupViewModel.Email, emailRegex, RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                return Json(new ResultDto { IsSuccess = true, Message = "ایمیل خودرا به درستی وارد نمایید" });
            }


            var signupResult = _createUserService.Excute(new RequestCreateUserDto()
            {
                Email = signupViewModel.Email,
                FullName = signupViewModel.FullName,
                Password = signupViewModel.Password,
                RePasword = signupViewModel.Repassword,
                Roles = new List<RolesInCreateUserDto>()
                {
                    new RolesInCreateUserDto()
                    {
                        RoleId = 3
                    }
                }

            });


            if (signupResult.IsSuccess == true)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,signupResult.Data.UserId.ToString()),
                    new Claim(ClaimTypes.Email, signupViewModel.Email),
                    new Claim(ClaimTypes.Name, signupViewModel.FullName),
                    new Claim(ClaimTypes.Role, "Customer"),
                };


                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var properties = new AuthenticationProperties()
                {
                    IsPersistent = true
                };
                HttpContext.SignInAsync(principal, properties);

            }



            return Json(signupResult);



        }

        #endregion

        #region Sign In

        [HttpGet]
        public IActionResult Signin(string ReturnUrl = "/")
        {
            ViewBag.url = ReturnUrl;

            return View();
        }


        [HttpPost]
        public IActionResult Signin(string Email, string Password, string url = "/")
        {
            var signin = _loginUserService.Excute(Email, Password);

            if (signin.IsSuccess==true)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,signin.Data.UserId.ToString()),
                    new Claim(ClaimTypes.Email, Email),
                    new Claim(ClaimTypes.Name, signin.Data.Name),
                 
                };
                foreach (var item in signin.Data.Roles)
                {
                        claims.Add(new Claim(ClaimTypes.Role,item));


                }
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var properties = new AuthenticationProperties()
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.Now.AddDays(5),
                };
                HttpContext.SignInAsync(principal, properties);

            }

            return Json(signin);

        }
        #endregion

        #region Sign Out

        public IActionResult SignOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");
        }

        #endregion

        #region AccessDenied

        //زمانی که در پنل ادمین کاربری دسترسی لازم به
        //سربرگی در پنل ادمین را نداشته باشد به این اکشن فرستاده می شود


        public IActionResult AccessDenied()
        {
            return View();
        }
        #endregion
    }
}
