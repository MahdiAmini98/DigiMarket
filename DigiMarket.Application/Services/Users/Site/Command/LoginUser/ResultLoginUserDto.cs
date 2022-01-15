using System.Collections.Generic;

namespace DigiMarket.Application.Services.Users.Command.LoginUser
{
    public class ResultLoginUserDto
    {
        public int UserId { get; set; }
        public List<string> Roles { get; set; }
        public string Name { get; set; }

    }
}