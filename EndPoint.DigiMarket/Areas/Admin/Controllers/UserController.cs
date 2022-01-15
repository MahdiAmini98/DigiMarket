using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Application.Services.Users.Command.CreateUser;
using DigiMarket.Application.Services.Users.Command.EditUser;
using DigiMarket.Application.Services.Users.Command.RemoveUser;
using DigiMarket.Application.Services.Users.Command.StatusChangeUser;
using DigiMarket.Application.Services.Users.Queries.GetRoles;
using DigiMarket.Application.Services.Users.Queries.GetUsers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EndPoint.DigiMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly IDigiMarketContext _context;
        private readonly IGetUsersService _usersService;
        private readonly IGetRolesService _rolesService;
        private readonly ICreateUserService _createService;
        private readonly IRemoveUserService _removeService;
        private readonly IChangeUserService _changeService;
        private readonly IEditUserService _editService;

        public UserController(IEditUserService editService, IChangeUserService changeService, IRemoveUserService removeService, ICreateUserService createService, IDigiMarketContext context, IGetUsersService usersService, IGetRolesService rolesService)
        {
            _context = context;
            _usersService = usersService;
            _rolesService = rolesService;
            _createService = createService;
            _removeService = removeService;
            _changeService = changeService;
            _editService = editService;
        }
       [Microsoft.AspNetCore.Mvc.Route("Admin")]
        public IActionResult Index(string serchkey, int page = 1)
        {


            return View(_usersService.Execute(new RequestGetUserDto
            {
                Page = page,
                searchKey = serchkey,
            }));
        }
        [HttpGet]
        public IActionResult CreateUser()
        {
            ViewBag.Roles = new SelectList(_rolesService.Execute().Data, "Id", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(string Email, string FullName, int RoleId, string Password, string RePassword)
        {
            var result = _createService.Excute(new RequestCreateUserDto()
            {
                Email = Email,
                FullName = FullName,
                Password = Password,
                RePasword = RePassword,
                Roles = new List<RolesInCreateUserDto>()
                {
                    new RolesInCreateUserDto()
                    {
                        RoleId = RoleId
                    }
                }

            });
            return Json(result);
        }


        [HttpPost]

        public IActionResult DeleteUser(int UserId)
        {
            return Json(_removeService.Execute(UserId));
        }


        [HttpPost]
        public IActionResult UserSatusChange(int UserId)
        {
            return Json(_changeService.Excute(UserId));
        }


        [HttpPost]
        public IActionResult Edit(int UserId, string Fullname,string Email)
        {
            return Json(_editService.Excute(new RequestEditUserDto()
            {
                FullName = Fullname,
                UserId = UserId,
                Email = Email,
                UpdateTime = DateTime.Now
            }));


        }


    }
}
