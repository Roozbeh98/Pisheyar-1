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

namespace Pisheyar.Application.Codes.Queries.GetUsersInitialCredit
{
    public class GetUsersInitialCreditQuery : IRequest<GetUsersInitialCreditVm>
    {
        public class GetCodesByCodeGroupGuidQueryHandler : IRequestHandler<GetUsersInitialCreditQuery, GetUsersInitialCreditVm>
        {
            private readonly IPisheyarContext _context;
            private readonly ICurrentUserService _currentUser;

            public GetCodesByCodeGroupGuidQueryHandler(IPisheyarContext context, ICurrentUserService currentUser)
            {
                _context = context;
                _currentUser = currentUser;
            }

            public async Task<GetUsersInitialCreditVm> Handle(GetUsersInitialCreditQuery request, CancellationToken cancellationToken)
            {
                User currentUser = await _context.User
                    .Where(x => x.UserGuid == Guid.Parse(_currentUser.NameIdentifier))
                    .SingleOrDefaultAsync(cancellationToken);

                if (currentUser == null) return new GetUsersInitialCreditVm()
                {
                    Message = "کاربر مورد نظر یافت نشد",
                    State = (int)GetUsersInitialCreditState.UserNotFound
                };

                Admin admin = await _context.Admin
                    .SingleOrDefaultAsync(x => x.UserId == currentUser.UserId, cancellationToken);

                if (admin == null) return new GetUsersInitialCreditVm()
                {
                    Message = "ادمین مورد نظر یافت نشد",
                    State = (int)GetUsersInitialCreditState.AdminNotFound
                };

                Setting setting = await _context.Setting
                    .FirstOrDefaultAsync(cancellationToken);

                if (setting == null) return new GetUsersInitialCreditVm()
                {
                    Message = "تنظیمات مورد نظر یافت نشد",
                    State = (int)GetUsersInitialCreditState.SettingNotFound
                };

                return new GetUsersInitialCreditVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)GetUsersInitialCreditState.Success,
                    Credit = setting.UserInitialCredit
                };
            }
        }
    }
}
