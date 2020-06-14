using System;
using System.Collections.Generic;
using System.Text;
using Pisheyar.Application.Common.Interfaces;
using Pisheyar.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Pisheyar.Domain.Enums;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Pisheyar.Application.ChangeOrderRequestPrice.Commands.ChangeOrderRequestsPrice
{
    public class ChangeOrderRequestsPriceCommand : IRequest<ChangeOrderRequestsPriceVm>
    {
        public int Price { get; set; }

        public class ChangeOrderRequestsPriceCommandHandler : IRequestHandler<ChangeOrderRequestsPriceCommand, ChangeOrderRequestsPriceVm>
        {
            private readonly IPisheyarContext _context;
            private readonly ICurrentUserService _currentUser;

            public ChangeOrderRequestsPriceCommandHandler(IPisheyarContext context, ICurrentUserService currentUser)
            {
                _context = context;
                _currentUser = currentUser;
            }

            public async Task<ChangeOrderRequestsPriceVm> Handle(ChangeOrderRequestsPriceCommand request, CancellationToken cancellationToken)
            {
                User currentUser = await _context.User
                    .Where(x => x.UserGuid == Guid.Parse(_currentUser.NameIdentifier))
                    .SingleOrDefaultAsync(cancellationToken);

                if (currentUser == null) return new ChangeOrderRequestsPriceVm()
                {
                    Message = "کاربر مورد نظر یافت نشد",
                    State = (int)ChangeOrderRequestPriceState.UserNotFound
                };

                Admin admin = await _context.Admin
                    .SingleOrDefaultAsync(x => x.UserId == currentUser.UserId, cancellationToken);

                if (admin == null) return new ChangeOrderRequestsPriceVm()
                {
                    Message = "ادمین مورد نظر یافت نشد",
                    State = (int)ChangeOrderRequestPriceState.AdminNotFound
                };

                Setting setting = await _context.Setting
                    .FirstOrDefaultAsync(cancellationToken);

                if (setting == null) return new ChangeOrderRequestsPriceVm()
                {
                    Message = "تنظیمات مورد نظر یافت نشد",
                    State = (int)ChangeOrderRequestPriceState.SettingNotFound
                };

                setting.OrderRequestPrice = request.Price;

                await _context.SaveChangesAsync(cancellationToken);

                return new ChangeOrderRequestsPriceVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)ChangeOrderRequestPriceState.Success
                };
            }
        }
    }
}
