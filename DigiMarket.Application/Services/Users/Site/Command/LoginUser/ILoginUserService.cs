using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Services.Users.Queries.GetUsers;
using DigiMarket.Common.Dto;
using DigiMarket.Domain.Entities.Users;

namespace DigiMarket.Application.Services.Users.Command.LoginUser
{
    
    public  interface ILoginUserService
  {
      ResultDto<ResultLoginUserDto> Excute(string UserName, string Password);
  }
}
