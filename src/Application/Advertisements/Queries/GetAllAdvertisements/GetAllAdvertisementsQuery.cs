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
            private readonly ICurrentUserService _currentUser;
            private readonly IMapper _mapper;

            public GetAllPostsQueryHandler(IPisheyarContext context, ICurrentUserService currentUser, IMapper mapper)
            {
                _context = context;
                _currentUser = currentUser;
                _mapper = mapper;
            }

            public async Task<GetAllAdvertisementsVm> Handle(GetAllAdvertisementsQuery request, CancellationToken cancellationToken)
            {
                User currentUser = await _context.User
                          .Where(x => x.UserGuid == Guid.Parse(_currentUser.NameIdentifier))
                          .SingleOrDefaultAsync(cancellationToken);

                if (currentUser == null) return new GetAllAdvertisementsVm()
                {
                    Message = "کاربر مورد نظر یافت نشد",
                    State = (int)GetAllAdvertisementsState.UserNotFound
                };

                Admin admin = await _context.Admin
                    .SingleOrDefaultAsync(x => x.UserId == currentUser.UserId, cancellationToken);

                if (admin == null) return new GetAllAdvertisementsVm()
                {
                    Message = "ادمین مورد نظر یافت نشد",
                    State = (int)GetAllAdvertisementsState.AdminNotFound
                };

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
