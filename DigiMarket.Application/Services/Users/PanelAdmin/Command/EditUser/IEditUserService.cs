using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Services.Users.Command.CreateUser;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Users.Command.EditUser
{
  public  interface IEditUserService
  {
      ResultDto Excute(RequestEditUserDto requestEdit);
  }
}
