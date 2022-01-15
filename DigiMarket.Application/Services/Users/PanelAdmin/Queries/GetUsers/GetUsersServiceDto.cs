using System;

namespace DigiMarket.Application.Services.Users.Queries.GetUsers
{
    public class GetUsersServiceDto
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime CrateDateTime { get; set; }
        public bool IsActive { get; set; }


    }
}