using System.Collections.Generic;
using System.Linq;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common;

namespace DigiMarket.Application.Services.Users.Queries.GetUsers
{
    public class GetUsersService : IGetUsersService
    {
        private readonly IDigiMarketContext _context;

        public GetUsersService(IDigiMarketContext context)
        {
            _context = context;
        }
        public ResualtGetUserDto Execute(RequestGetUserDto request)
        {
            var users = _context.Users.AsQueryable();
            if ( ! string.IsNullOrWhiteSpace(request.searchKey))
            {
                users = users.Where(u => u.FullName.Contains(request.searchKey) && u.Email.Contains(request.searchKey));

            }

            int rowCount = 0;
            var userList=users.ToPaged(request.Page, 50, out rowCount).Select(p => new GetUsersServiceDto()
            {
                CrateDateTime = p.CrateDateTime,
                Email = p.Email,
                FullName = p.FullName,
                IsActive = p.IsActive,
                UserId = p.KeyId,
                
            }).ToList();

            return new ResualtGetUserDto
            {
                Rows = rowCount,
                Users = userList
            };
        } 
       
    }
}