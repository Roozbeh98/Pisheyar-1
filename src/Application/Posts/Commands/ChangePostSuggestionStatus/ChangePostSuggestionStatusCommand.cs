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

namespace Pisheyar.Application.Posts.Commands.ChangePostSuggestionStatus
{
    public class ChangePostSuggestionStatusCommand : IRequest<ChangePostSuggestionStatusVm>
    {
        public Guid PostGuid { get; set; }

        public bool SuggestionStatus { get; set; }

        public class ChangePostActivenessCommandHandler : IRequestHandler<ChangePostSuggestionStatusCommand, ChangePostSuggestionStatusVm>
        {
            private readonly IPisheyarContext _context;

            public ChangePostActivenessCommandHandler(IPisheyarContext context)
            {
                _context = context;
            }

            public async Task<ChangePostSuggestionStatusVm> Handle(ChangePostSuggestionStatusCommand request, CancellationToken cancellationToken)
            {
                Post post = await _context.Post
                    .SingleOrDefaultAsync(x => x.PostGuid == request.PostGuid && !x.IsDelete);

                if (post == null) return new ChangePostSuggestionStatusVm
                {
                    Message = "پست مورد نظر یافت نشد",
                    State = (int)ChangePostSuggestionStatusState.PostNotFound
                };

                post.IsSuggested = request.SuggestionStatus;
                post.ModifiedDate = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return new ChangePostSuggestionStatusVm
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)ChangePostSuggestionStatusState.Success
                };
            }
        }
    }
}
