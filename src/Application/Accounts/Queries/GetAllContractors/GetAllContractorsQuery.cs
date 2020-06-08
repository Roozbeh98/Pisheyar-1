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

namespace Pisheyar.Application.Accounts.Queries.GetAllContractors
{
    public class GetAllContractorsQuery : IRequest<GetAllContractorsVm>
    {
        public class GetUsersQueryHandler : IRequestHandler<GetAllContractorsQuery, GetAllContractorsVm>
        {
            private readonly IPisheyarContext _context;
            private readonly IMapper _mapper;

            public GetUsersQueryHandler(IPisheyarContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GetAllContractorsVm> Handle(GetAllContractorsQuery request, CancellationToken cancellationToken)
            {
                List<GetAllContractorsDto> contractors = await _context.User
                    .Where(x => !x.IsDelete && x.RoleId == 2)
                    .OrderByDescending(x => x.ModifiedDate)
                    .ProjectTo<GetAllContractorsDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);

                if (contractors.Count < 0) return new GetAllContractorsVm()
                {
                    Message = "سرویس دهنده ای یافت نشد",
                    State = (int)GetAllContractorsState.NotAnyContractosFound
                };

                return new GetAllContractorsVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)GetAllContractorsState.Success,
                    Contractors = contractors
                };
            }
        }
    }
}
