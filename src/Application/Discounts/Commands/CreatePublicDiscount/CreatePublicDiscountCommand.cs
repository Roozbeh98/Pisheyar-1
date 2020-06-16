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

namespace Pisheyar.Application.Discounts.Commands.CreatePublicDiscount
{
    public class CreatePublicDiscountCommand : IRequest<CreatePublicDiscountVm>
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public Guid TypeCodeGuid { get; set; }

        public string ExpirationDate { get; set; }

        public class CreateSuggestionCommandHandler : IRequestHandler<CreatePublicDiscountCommand, CreatePublicDiscountVm>
        {
            private readonly IPisheyarContext _context;
            private readonly ICurrentUserService _currentUser;
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

            public CreateSuggestionCommandHandler(IPisheyarContext context, ICurrentUserService currentUser)
            {
                _context = context;
                _currentUser = currentUser;
            }

            public async Task<CreatePublicDiscountVm> Handle(CreatePublicDiscountCommand request, CancellationToken cancellationToken)
            {
                User currentUser = await _context.User
                    .Where(x => x.UserGuid == Guid.Parse(_currentUser.NameIdentifier))
                    .SingleOrDefaultAsync(cancellationToken);

                if (currentUser == null) return new CreatePublicDiscountVm()
                {
                    Message = "کاربر مورد نظر یافت نشد",
                    State = (int)CreatePublicDiscountState.UserNotFound
                };

                Admin admin = await _context.Admin
                    .SingleOrDefaultAsync(x => x.UserId == currentUser.UserId, cancellationToken);

                if (admin == null) return new CreatePublicDiscountVm()
                {
                    Message = "ادمین مورد نظر یافت نشد",
                    State = (int)CreatePublicDiscountState.AdminNotFound
                };

                string monthName = request.ExpirationDate.Substring(4, 3);
                _monthNumber.TryGetValue(monthName, out int month);

                // TODO: error handling

                //if (month == 0) return new CreatePublicDiscountVm()
                //{
                //    Message = "تاریخ انقضا نامعتبر",
                //    State = (int)GetAllPaymentsState.InvalidExpirationDate
                //};

                int day = Convert.ToInt32(request.ExpirationDate.Substring(8, 2));
                int year = Convert.ToInt32(request.ExpirationDate.Substring(11, 4));

                Code typeCode = await _context.Code
                    .SingleOrDefaultAsync(x => x.CodeGuid == request.TypeCodeGuid, cancellationToken);

                if (typeCode == null) return new CreatePublicDiscountVm()
                {
                    Message = "نوع کد تخفیف مورد نظر یافت نشد",
                    State = (int)CreatePublicDiscountState.TypeCodeNotFound
                };

                PublicDiscount publicDiscount = new PublicDiscount()
                {
                    TypeCodeId = typeCode.CodeId,
                    Name = request.Name,
                    Value = request.Value,
                    ExpirationDate = new DateTime(year, month, day)
                };

                _context.PublicDiscount.Add(publicDiscount);

                await _context.SaveChangesAsync(cancellationToken);

                return new CreatePublicDiscountVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)CreatePublicDiscountState.Success
                };
            }
        }
    }
}
