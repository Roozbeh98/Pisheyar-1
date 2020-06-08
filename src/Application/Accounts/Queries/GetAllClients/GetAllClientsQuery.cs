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

namespace Pisheyar.Application.Accounts.Queries.GetAllClients
{
    public class GetAllClientsQuery : IRequest<GetAllClientsVm>
    {
        public class GetUsersQueryHandler : IRequestHandler<GetAllClientsQuery, GetAllClientsVm>
        {
            private readonly IPisheyarContext _context;
            private readonly IMapper _mapper;

            public GetUsersQueryHandler(IPisheyarContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GetAllClientsVm> Handle(GetAllClientsQuery request, CancellationToken cancellationToken)
            {
                List<GetAllClientsDto> clients = await _context.User
                    .Where(x => !x.IsDelete && x.RoleId == 3)
                    .OrderByDescending(x => x.ModifiedDate)
                    .ProjectTo<GetAllClientsDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);

                if (clients.Count < 0) return new GetAllClientsVm()
                {
                    Message = "سرویس گیرنده ای یافت نشد",
                    State = (int)GetAllClientsState.NotAnyClientsFound
                };

                return new GetAllClientsVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)GetAllClientsState.Success,
                    Clients = clients
                };
            }
        }
    }
}
