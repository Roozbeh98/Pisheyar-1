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

namespace Pisheyar.Application.Posts.Queries.GetAllAdvertisements
{
    public class GetAllAdvertisementsQuery : IRequest<GetAllAdvertisementsVm>
    {
        public class GetAllPostsQueryHandler : IRequestHandler<GetAllAdvertisementsQuery, GetAllAdvertisementsVm>
        {
            private readonly IPisheyarContext _context;
            private readonly IMapper _mapper;

            public GetAllPostsQueryHandler(IPisheyarContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GetAllAdvertisementsVm> Handle(GetAllAdvertisementsQuery request, CancellationToken cancellationToken)
            {
                List<GetAllAdvertisementsDto> advertisements = await _context.Advertisement
                    .Where(x => x.IsShow && !x.IsDelete)
                    .ProjectTo<GetAllAdvertisementsDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);

                if (advertisements.Count == 0) return new GetAllAdvertisementsVm()
                {
                    Message = "تبلیغی یافت نشد",
                    State = (int)GetAllAdvertisementsState.NotAnyAdvertisements
                };

                return new GetAllAdvertisementsVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)GetAllAdvertisementsState.Success,
                    Advertisements = advertisements
                };
            }
        }
    }
}
