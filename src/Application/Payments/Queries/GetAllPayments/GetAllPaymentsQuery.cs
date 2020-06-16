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

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public bool? SuccessfulStatus { get; set; }

        public class OrdersListQueryHandler : IRequestHandler<GetAllPaymentsQuery, GetAllPaymentsVm>
        {
            private readonly IPisheyarContext _context;
            private readonly ICurrentUserService _currentUser;
            private readonly IMapper _mapper;
            private readonly Dictionary<string, int> _monthNumber = new Dictionary<string, int>()
            {
                { "Jan", 1 },
                { "Feb", 2 },
                { "Mar", 3 },
                { "Apr", 4 },
                { "May", 5 },
                { "Jun", 6 },
                { "Jul", 7 },
                { "Aug", 8 },
                { "Sep", 9 },
                { "Oct", 10 },
                { "Nov", 11 },
                { "Dec", 12 },
            };

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

                if (!string.IsNullOrEmpty(request.StartDate))
                {
                    string monthName = request.StartDate.Substring(4, 3);
                    _monthNumber.TryGetValue(monthName, out int month);

                    // TODO: error handling

                    //if (month == 0) return new GetAllPaymentsVm()
                    //{
                    //    Message = "تاریخ شروع نامعتبر",
                    //    State = (int)GetAllPaymentsState.InvalidStartDate
                    //};

                    int day = Convert.ToInt32(request.StartDate.Substring(8, 2));
                    int year = Convert.ToInt32(request.StartDate.Substring(11, 4));

                    DateTime date = new DateTime(year, month, day);

                    payments = payments.Where(x => x.CreationDate.Date >= date);
                }

                if (!string.IsNullOrEmpty(request.EndDate))
                {
                    string monthName = request.EndDate.Substring(4, 3);
                    _monthNumber.TryGetValue(monthName, out int month);

                    // TODO: error handling

                    //if (month == 0) return new GetAllPaymentsVm()
                    //{
                    //    Message = "تاریخ پایان نامعتبر",
                    //    State = (int)GetAllPaymentsState.InvalidEndDate
                    //};

                    int day = Convert.ToInt32(request.EndDate.Substring(8, 2));
                    int year = Convert.ToInt32(request.EndDate.Substring(11, 4));

                    DateTime date = new DateTime(year, month, day);

                    payments = payments.Where(x => x.CreationDate.Date <= date);
                }

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
