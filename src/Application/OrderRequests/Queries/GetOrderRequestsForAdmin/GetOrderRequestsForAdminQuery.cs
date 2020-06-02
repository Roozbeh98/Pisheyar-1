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

namespace Pisheyar.Application.OrderRequests.Queries.GetOrderRequestsForAdmin
{
    public class GetOrderRequestsForAdminQuery : IRequest<GetOrderRequestsForAdminVm>
    {
        public Guid OrderGuid { get; set; }

        public class OrdersListQueryHandler : IRequestHandler<GetOrderRequestsForAdminQuery, GetOrderRequestsForAdminVm>
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

            public async Task<GetOrderRequestsForAdminVm> Handle(GetOrderRequestsForAdminQuery request, CancellationToken cancellationToken)
            {
                User currentUser = await _context.User
                    .Where(x => x.UserGuid == Guid.Parse(_currentUser.NameIdentifier))
                    .SingleOrDefaultAsync(cancellationToken);

                if (currentUser == null) return new GetOrderRequestsForAdminVm()
                {
                    Message = "کاربر مورد نظر یافت نشد",
                    State = (int)GetOrderRequestsForAdminState.UserNotFound
                };

                Admin admin = await _context.Admin
                    .SingleOrDefaultAsync(x => x.UserId == currentUser.UserId, cancellationToken);

                if (admin == null) return new GetOrderRequestsForAdminVm()
                {
                    Message = "ادمین مورد نظر یافت نشد",
                    State = (int)GetOrderRequestsForAdminState.AdminNotFound
                };

                Order order = await _context.Order
                    .Where(x => x.OrderGuid == request.OrderGuid)
                    .SingleOrDefaultAsync(cancellationToken);

                if (order == null) return new GetOrderRequestsForAdminVm()
                {
                    Message = "سفارش مورد نظر یافت نشد",
                    State = (int)GetOrderRequestsForAdminState.OrderNotFound
                };

                List<GetOrderRequestsForAdminDto> orderRequests = await _context.OrderRequest
                    .Where(x => x.OrderId == order.OrderId)
                    .ProjectTo<GetOrderRequestsForAdminDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);

                if (orderRequests.Count <= 0)
                {
                    return new GetOrderRequestsForAdminVm()
                    {
                        Message = "درخواست سفارشی برای سفارش مورد نظر یافت نشد",
                        State = (int)GetOrderRequestsForAdminState.NotAnyOrderRequestsFound
                    };
                }

                return new GetOrderRequestsForAdminVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)GetOrderRequestsForAdminState.Success,
                    OrderRequests = orderRequests
                };
            }
        }
    }
}
