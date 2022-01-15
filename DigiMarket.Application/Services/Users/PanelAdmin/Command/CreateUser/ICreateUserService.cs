using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Users.Command.CreateUser
{
  public  interface ICreateUserService
  {

      ResultDto<ResaultCreateUserDto> Excute(RequestCreateUserDto requestCreateUser);

  }
}
