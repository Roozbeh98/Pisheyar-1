using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Pisheyar.Application.Common.Interfaces;
using Pisheyar.Domain.Entities;
using Pisheyar.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pisheyar.Application.Payments.Queries.GetLoyalContractors
{
    public class GetLoyalContractorsQuery : IRequest<GetLoyalContractorsVm>
    {
        public class OrdersListQueryHandler : IRequestHandler<GetLoyalContractorsQuery, GetLoyalContractorsVm>
        {
            private readonly IPisheyarContext _context;
            private readonly ICurrentUserService _currentUser;

            public OrdersListQueryHandler(IPisheyarContext context, ICurrentUserService currentUserService)
            {
                _context = context;
                _currentUser = currentUserService;
            }

            public async Task<GetLoyalContractorsVm> Handle(GetLoyalContractorsQuery request, CancellationToken cancellationToken)
            {
                User currentUser = await _context.User
                    .Where(x => x.UserGuid == Guid.Parse(_currentUser.NameIdentifier))
                    .SingleOrDefaultAsync(cancellationToken);

                if (currentUser == null) return new GetLoyalContractorsVm()
                {
                    Message = "کاربر مورد نظر یافت نشد",
                    State = (int)GetLoyalContractorsState.UserNotFound
                };

                Admin admin = await _context.Admin
                    .SingleOrDefaultAsync(x => x.UserId == currentUser.UserId, cancellationToken);

                if (admin == null) return new GetLoyalContractorsVm()
                {
                    Message = "ادمین مورد نظر یافت نشد",
                    State = (int)GetLoyalContractorsState.AdminNotFound
                };

                List<GetLoyalContractorsDto> loyalContractors = await _context.Payment
                    .Where(x => x.IsSuccessful)
                    .GroupBy(x => new
                    {
                        x.Contractor.User.UserGuid,
                        x.ContractorId,
                        x.Contractor.User.FirstName,
                        x.Contractor.User.LastName
                    })
                    .Select(x => new GetLoyalContractorsDto()
                    {
                        UserGuid = x.Key.UserGuid,
                        FirstName = x.Key.FirstName,
                        LastName = x.Key.LastName,
                        PaymentCount = x.Count()
                    })
                    .OrderByDescending(x => x.PaymentCount)
                    .Take(100)
                    .ToListAsync(cancellationToken);

                if (loyalContractors.Count <= 0) return new GetLoyalContractorsVm()
                {
                    Message = "سرویس دهنده ای یافت نشد",
                    State = (int)GetLoyalContractorsState.NotAnyContractorsFound
                };

                return new GetLoyalContractorsVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)GetLoyalContractorsState.Success,
                    LoyalContractors = loyalContractors
                };
            }
        }
    }
}
