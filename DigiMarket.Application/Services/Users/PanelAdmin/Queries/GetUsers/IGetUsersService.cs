using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DigiMarket.Application.Services.Users.Queries.GetUsers
{
   public interface IGetUsersService
   {
       ResualtGetUserDto Execute(RequestGetUserDto request);
   }
}
