using System;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Users.Command.RemoveUser
{
    public class RemoveUserService : IRemoveUserService
    {
        private IDigiMarketContext _context;

        public RemoveUserService(IDigiMarketContext context)
        {
            _context = context;
        }

        public ResultDto Execute(int UserId)
        {

            var user = _context.Users.Find(UserId);
            if (user == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "کاربر یافت نشد"
                };
            }
            user.RemoveTime = DateTime.Now;
            user.IsRemoved = true;
            _context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess = true,
                Message = "کاربر با موفقیت حذف شد"
            };
        }
    }
}