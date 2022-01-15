using DigiMarket.Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DigiMarket.Application.Services.Users.Queries.GetRoles;
using DigiMarket.Application.Services.Users.Queries.GetRoles;
using DigiMarket.Application.Services.Users.Queries.GetRoles;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Users.Queries.GetRoles
{
    public interface IGetRolesService
    {
        ResultDto<List<RolesDto>> Execute();
    }
}
