using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Pisheyar.Application.Common.Interfaces;
using Pisheyar.Application.Posts.Queries.GetAllPosts;
using Pisheyar.Domain.Entities;
using Pisheyar.Domain.Enums;

namespace Pisheyar.Application.Codes.Queries.GetOrderRequestsPrice
{
    public class GetOrderRequestsPriceQuery : IRequest<GetOrderRequestsPriceVm>
    {
        public class GetCodesByCodeGroupGuidQueryHandler : IRequestHandler<GetOrderRequestsPriceQuery, GetOrderRequestsPriceVm>
        {
            private readonly IPisheyarContext _context;
            private readonly ICurrentUserService _currentUser;

            public GetCodesByCodeGroupGuidQueryHandler(IPisheyarContext context, ICurrentUserService currentUser)
            {
                _context = context;
                _currentUser = currentUser;
            }

            public async Task<GetOrderRequestsPriceVm> Handle(GetOrderRequestsPriceQuery request, CancellationToken cancellationToken)
            {
                User currentUser = await _context.User
                    .Where(x => x.UserGuid == Guid.Parse(_currentUser.NameIdentifier))
                    .SingleOrDefaultAsync(cancellationToken);

                if (currentUser == null) return new GetOrderRequestsPriceVm()
                {
                    Message = "کاربر مورد نظر یافت نشد",
                    State = (int)GetOrderRequestsPriceState.UserNotFound
                };

                Admin admin = await _context.Admin
                    .SingleOrDefaultAsync(x => x.UserId == currentUser.UserId, cancellationToken);

                if (admin == null) return new GetOrderRequestsPriceVm()
                {
                    Message = "ادمین مورد نظر یافت نشد",
                    State = (int)GetOrderRequestsPriceState.AdminNotFound
                };

                Setting setting = await _context.Setting
                    .FirstOrDefaultAsync(cancellationToken);

                if (setting == null) return new GetOrderRequestsPriceVm()
                {
                    Message = "تنظیمات مورد نظر یافت نشد",
                    State = (int)GetOrderRequestsPriceState.SettingNotFound
                };

                return new GetOrderRequestsPriceVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)GetOrderRequestsPriceState.Success,
                    Price = setting.OrderRequestPrice
                };
            }
        }
    }
}
