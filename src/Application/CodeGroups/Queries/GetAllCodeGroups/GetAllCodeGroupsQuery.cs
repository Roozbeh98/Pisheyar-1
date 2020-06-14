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

namespace Pisheyar.Application.CodeGroups.Queries.GetAllCodeGroups
{
    public class GetAllCodeGroupsQuery : IRequest<GetAllCodeGroupsVm>
    {
        public class GetAllCodeGroupsQueryHandler : IRequestHandler<GetAllCodeGroupsQuery, GetAllCodeGroupsVm>
        {
            private readonly IPisheyarContext _context;
            private readonly IMapper _mapper;

            public GetAllCodeGroupsQueryHandler(IPisheyarContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GetAllCodeGroupsVm> Handle(GetAllCodeGroupsQuery request, CancellationToken cancellationToken)
            {
                var codeGroups = await _context.CodeGroup
                    .Where(x => !x.IsDelete)
                    .ProjectTo<GetAllCodeGroupsDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);

                if (codeGroups.Count == 0) return new GetAllCodeGroupsVm()
                {
                    Message = "کد گروهی یافت نشد",
                    State = (int)GetAllCodeGroupsState.NotAnyCodeGroups
                };

                return new GetAllCodeGroupsVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)GetAllCodeGroupsState.Success,
                    CodeGroups = codeGroups
                };
            }
        }
    }
}
