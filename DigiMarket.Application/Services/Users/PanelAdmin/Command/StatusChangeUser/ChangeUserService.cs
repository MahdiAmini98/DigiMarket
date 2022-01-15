using DigiMarket.Application.Interfaces.Context;
using DigiMarket.Common.Dto;

namespace DigiMarket.Application.Services.Users.Command.StatusChangeUser
{
    public class ChangeUserService : IChangeUserService
    {
        private IDigiMarketContext _context;

        public ChangeUserService(IDigiMarketContext context)
        {
            _context = context;
        }
        public ResultDto Excute(int userId)
        {

            var user = _context.Users.Find(userId);

            if (user==null)
            {

                return new ResultDto()
                {
                    IsSuccess = false,
                    Message = "کاربر مورد نظر یافت نشد"
                };

            }

            user.IsActive = !user.IsActive;
            _context.SaveChanges();

            string status = user.IsActive == true ? "فعال" : "غیرفعال";

            return new ResultDto()
            {
                IsSuccess = true,
                Message = $"کاربر با موفقیت {status} شد"
            };
        }
    }
}