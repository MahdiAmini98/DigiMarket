using System;

namespace DigiMarket.Application.Services.Users.Command.EditUser
{
    public class RequestEditUserDto
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Email { get; set; }
    }
}