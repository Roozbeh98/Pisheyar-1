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
using AutoMapper.QueryableExtensions;
using AutoMapper;

namespace Pisheyar.Application.Posts.Queries.GetAllComplaints
{
    public class GetAllComplaintsQuery : IRequest<GetAllComplaintsVm>
    {
        public class GetAllComplaintsQueryHandler : IRequestHandler<GetAllComplaintsQuery, GetAllComplaintsVm>
        {
            private readonly IPisheyarContext _context;
            private readonly ICurrentUserService _currentUser;
            private readonly IMapper _mapper;

            public GetAllComplaintsQueryHandler(IPisheyarContext context, ICurrentUserService currentUser, IMapper mapper)
            {
                _context = context;
                _currentUser = currentUser;
                _mapper = mapper;
            }

            public async Task<GetAllComplaintsVm> Handle(GetAllComplaintsQuery request, CancellationToken cancellationToken)
            {
                User currentUser = await _context.User
                       .Where(x => x.UserGuid == Guid.Parse(_currentUser.NameIdentifier))
                       .SingleOrDefaultAsync(cancellationToken);

                if (currentUser == null) return new GetAllComplaintsVm()
                {
                    Message = "کاربر مورد نظر یافت نشد",
                    State = (int)GetAllComplaintsState.UserNotFound
                };

                Admin admin = await _context.Admin
                    .SingleOrDefaultAsync(x => x.UserId == currentUser.UserId, cancellationToken);

                if (admin == null) return new GetAllComplaintsVm()
                {
                    Message = "ادمین مورد نظر یافت نشد",
                    State = (int)GetAllComplaintsState.AdminNotFound
                };

                List<GetAllComplaintsDto> complaints = await _context.Complaint
                    .OrderByDescending(x => x.CreationDate)
                    .ProjectTo<GetAllComplaintsDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);

                if (complaints.Count == 0) return new GetAllComplaintsVm()
                {
                    Message = "شکایتی یافت نشد",
                    State = (int)GetAllComplaintsState.NotAnyComplaints
                };

                return new GetAllComplaintsVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)GetAllComplaintsState.Success,
                    Complaints = complaints
                };
            }
        }
    }
}
