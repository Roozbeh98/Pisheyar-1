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

namespace Pisheyar.Application.Payments.Queries.GetAllPayments
{
    public class GetAllPaymentsQuery : IRequest<GetAllPaymentsVm>
    {
        public Guid? ContractorGuid { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool? SuccessfulStatus { get; set; }

        public class OrdersListQueryHandler : IRequestHandler<GetAllPaymentsQuery, GetAllPaymentsVm>
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

            public async Task<GetAllPaymentsVm> Handle(GetAllPaymentsQuery request, CancellationToken cancellationToken)
            {
                User currentUser = await _context.User
                    .Where(x => x.UserGuid == Guid.Parse(_currentUser.NameIdentifier))
                    .SingleOrDefaultAsync(cancellationToken);

                if (currentUser == null) return new GetAllPaymentsVm()
                {
                    Message = "کاربر مورد نظر یافت نشد",
                    State = (int)GetAllPaymentsState.UserNotFound
                };

                Admin admin = await _context.Admin
                    .SingleOrDefaultAsync(x => x.UserId == currentUser.UserId, cancellationToken);

                if (admin == null) return new GetAllPaymentsVm()
                {
                    Message = "ادمین مورد نظر یافت نشد",
                    State = (int)GetAllPaymentsState.AdminNotFound
                };

                IQueryable<Payment> payments = _context.Payment
                    .AsQueryable();

                if (request.ContractorGuid != null)
                    payments = payments.Where(x => x.Contractor.ContractorGuid == request.ContractorGuid);

                if (request.StartDate != null)
                    payments = payments.Where(x => x.CreationDate.Date >= request.StartDate.Value.Date);

                if (request.EndDate != null)
                    payments = payments.Where(x => x.CreationDate.Date <= request.EndDate.Value.Date);

                if (request.SuccessfulStatus != null)
                    payments = payments.Where(x => x.IsSuccessful == request.SuccessfulStatus);

                List<GetAllPaymentsDto> paymentsResult = await payments
                    .OrderByDescending(x => x.CreationDate)
                    .ProjectTo<GetAllPaymentsDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);

                if (paymentsResult.Count <= 0) return new GetAllPaymentsVm()
                {
                    Message = "پرداختی یافت نشد",
                    State = (int)GetAllPaymentsState.NotAnyPaymentsFound
                };

                return new GetAllPaymentsVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)GetAllPaymentsState.Success,
                    Payments = paymentsResult
                };
            }
        }
    }
}
