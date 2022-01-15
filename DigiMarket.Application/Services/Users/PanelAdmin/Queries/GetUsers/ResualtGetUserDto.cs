using System.Collections.Generic;

namespace DigiMarket.Application.Services.Users.Queries.GetUsers
{
    public class ResualtGetUserDto
    {
        public List<GetUsersServiceDto> Users { get; set; }
        public int Rows { get; set; }

    }
}