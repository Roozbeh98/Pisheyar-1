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

namespace Pisheyar.Application.Payments.Queries.GetPaymentByGuid
{
    public class GetPaymentByGuidQuery : IRequest<GetPaymentByGuidVm>
    {
        public Guid PaymentGuid { get; set; }

        public class OrdersListQueryHandler : IRequestHandler<GetPaymentByGuidQuery, GetPaymentByGuidVm>
        {
            private readonly IPisheyarContext _context;
            private readonly ICurrentUserService _currentUser;
            private readonly IMapper _mapper;

            public OrdersListQueryHandler(IPisheyarContext context, ICurrentUserService currentUserService, IMapper mapper)
            {
                _context = context;
                _currentUser = currentUserService;
                _mapper = mapper;
            }

            public async Task<GetPaymentByGuidVm> Handle(GetPaymentByGuidQuery request, CancellationToken cancellationToken)
            {
                User currentUser = await _context.User
                    .Where(x => x.UserGuid == Guid.Parse(_currentUser.NameIdentifier))
                    .SingleOrDefaultAsync(cancellationToken);

                if (currentUser == null) return new GetPaymentByGuidVm()
                {
                    Message = "کاربر مورد نظر یافت نشد",
                    State = (int)GetPaymentByGuidState.UserNotFound
                };

                Admin admin = await _context.Admin
                    .SingleOrDefaultAsync(x => x.UserId == currentUser.UserId, cancellationToken);

                if (admin == null) return new GetPaymentByGuidVm()
                {
                    Message = "ادمین مورد نظر یافت نشد",
                    State = (int)GetPaymentByGuidState.AdminNotFound
                };

                GetPaymentByGuidDto payment = await _context.Payment
                    .Where(x => x.PaymentGuid == request.PaymentGuid)
                    .ProjectTo<GetPaymentByGuidDto>(_mapper.ConfigurationProvider)
                    .SingleOrDefaultAsync(cancellationToken);

                if (payment == null) return new GetPaymentByGuidVm()
                {
                    Message = "پرداخت مورد نظر یافت نشد",
                    State = (int)GetPaymentByGuidState.PaymentNotFound
                };

                return new GetPaymentByGuidVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)GetPaymentByGuidState.Success,
                    Payment = payment
                };
            }
        }
    }
}
