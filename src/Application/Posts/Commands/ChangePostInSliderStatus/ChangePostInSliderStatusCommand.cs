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

namespace Pisheyar.Application.Posts.Commands.ChangePostInSliderStatus
{
    public class ChangePostInSliderStatusCommand : IRequest<ChangePostInSliderStatusVm>
    {
        public Guid PostGuid { get; set; }

        public bool InSliderStatus { get; set; }

        public class ChangePostIsInSliderStatusCommandHandler : IRequestHandler<ChangePostInSliderStatusCommand, ChangePostInSliderStatusVm>
        {
            private readonly IPisheyarContext _context;

            public ChangePostIsInSliderStatusCommandHandler(IPisheyarContext context)
            {
                _context = context;
            }

            public async Task<ChangePostInSliderStatusVm> Handle(ChangePostInSliderStatusCommand request, CancellationToken cancellationToken)
            {
                Post post = await _context.Post
                    .SingleOrDefaultAsync(x => x.PostGuid == request.PostGuid && !x.IsDelete);

                if (post == null) return new ChangePostInSliderStatusVm
                {
                    Message = "پست مورد نظر یافت نشد",
                    State = (int)ChangePostInSliderStatusState.PostNotFound
                };

                post.IsInSlider = request.InSliderStatus;
                post.ModifiedDate = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return new ChangePostInSliderStatusVm
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)ChangePostInSliderStatusState.Success
                };
            }
        }
    }
}
