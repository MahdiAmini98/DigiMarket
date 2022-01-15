using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Users.Command.RemoveUser
{
  public  interface IRemoveUserService
  {
      ResultDto Execute(int userid);
  }
}
