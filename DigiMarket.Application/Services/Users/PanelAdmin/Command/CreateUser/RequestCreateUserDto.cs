using System.Collections.Generic;

namespace DigiMarket.Application.Services.Users.Command.CreateUser
{
    public class RequestCreateUserDto
    {

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RePasword { get; set; }

        public IList<RolesInCreateUserDto> Roles { get; set; }

    }
}