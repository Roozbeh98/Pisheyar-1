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

namespace Pisheyar.Application.Posts.Queries.GetAllSuggestions
{
    public class GetAllSuggestionsQuery : IRequest<GetAllSuggestionsVm>
    {
        public class GetAllComplaintsQueryHandler : IRequestHandler<GetAllSuggestionsQuery, GetAllSuggestionsVm>
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

            public async Task<GetAllSuggestionsVm> Handle(GetAllSuggestionsQuery request, CancellationToken cancellationToken)
            {
                User currentUser = await _context.User
                    .Where(x => x.UserGuid == Guid.Parse(_currentUser.NameIdentifier))
                    .SingleOrDefaultAsync(cancellationToken);

                if (currentUser == null) return new GetAllSuggestionsVm()
                {
                    Message = "کاربر مورد نظر یافت نشد",
                    State = (int)GetAllSuggestionsState.UserNotFound
                };

                Admin admin = await _context.Admin
                    .SingleOrDefaultAsync(x => x.UserId == currentUser.UserId, cancellationToken);

                if (admin == null) return new GetAllSuggestionsVm()
                {
                    Message = "ادمین مورد نظر یافت نشد",
                    State = (int)GetAllSuggestionsState.AdminNotFound
                };

                List<GetAllSuggestionsDto> suggestions = await _context.Suggestion
                    .OrderByDescending(x => x.CreationDate)
                    .ProjectTo<GetAllSuggestionsDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);

                if (suggestions.Count == 0) return new GetAllSuggestionsVm()
                {
                    Message = "انتقاد و پشنهادی یافت نشد",
                    State = (int)GetAllSuggestionsState.NotAnySuggestions
                };

                return new GetAllSuggestionsVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)GetAllSuggestionsState.Success,
                    Suggestions = suggestions
                };
            }
        }
    }
}
