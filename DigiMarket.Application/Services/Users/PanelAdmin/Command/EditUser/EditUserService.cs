using System;
using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Users.Command.EditUser
{
    public class EditUserService : IEditUserService
    {
        private IDigiMarketContext _context;

        public EditUserService(IDigiMarketContext context)
        {
            _context = context;
        }
        public ResultDto Excute(RequestEditUserDto requestEdit)
        {
            var user = _context.Users.Find(requestEdit.UserId);

            if (user == null)
            {
                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "کاربری یافت نشد"
                };
            }

            user.FullName = requestEdit.FullName;
            user.UpdateTime = requestEdit.UpdateTime=DateTime.Now;
            user.Email = requestEdit.Email;
            _context.SaveChanges();

            return new ResultDto()
            {
                IsSuccess = true,
                Message = "کاربر با موقیت تغییر یافت"
            };

        }
    }
}