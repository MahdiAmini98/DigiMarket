using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;
using System.Collections.Generic;
using System.Linq;
using DigiMarket.Application.Services.Users.Queries.GetRoles;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Users.Queries.GetRoles
{
    public class GetRolesService : IGetRolesService
    {
        private readonly IDigiMarketContext _context;

        public GetRolesService(IDigiMarketContext context)
        {
            _context = context;
        }
        public ResultDto<List<RolesDto>> Execute()
        {
            var roles = _context.Roles.ToList().Select(p => new RolesDto
            {
                Id = p.RoleId,
                Name = p.RoleTittle
            }).ToList();

            return new ResultDto<List<RolesDto>>()
            {
                Data = roles,
                IsSuccess = true,
                Message = "",
            };
        }
    }
}
