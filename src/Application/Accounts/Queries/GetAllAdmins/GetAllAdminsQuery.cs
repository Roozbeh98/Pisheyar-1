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

namespace Pisheyar.Application.Accounts.Queries.GetAllAdmins
{
    public class GetAllAdminsQuery : IRequest<GetAllAdminsVm>
    {
        public class GetUsersQueryHandler : IRequestHandler<GetAllAdminsQuery, GetAllAdminsVm>
        {
            private readonly IPisheyarContext _context;
            private readonly IMapper _mapper;

            public GetUsersQueryHandler(IPisheyarContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GetAllAdminsVm> Handle(GetAllAdminsQuery request, CancellationToken cancellationToken)
            {
                List<GetAllAdminsDto> admins = await _context.User
                    .Where(x => !x.IsDelete && x.RoleId == 1)
                    .OrderByDescending(x => x.ModifiedDate)
                    .ProjectTo<GetAllAdminsDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);

                if (admins.Count < 0) return new GetAllAdminsVm()
                {
                    Message = "ادمینی یافت نشد",
                    State = (int)GetAllAdminsState.NotAnyAdminsFound
                };

                return new GetAllAdminsVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)GetAllAdminsState.Success,
                    Admins = admins
                };
            }
        }
    }
}
