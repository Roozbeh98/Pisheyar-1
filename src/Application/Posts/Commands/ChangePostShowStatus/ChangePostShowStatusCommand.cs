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

namespace Pisheyar.Application.Posts.Commands.ChangePostShowStatus
{
    public class ChangePostShowStatusCommand : IRequest<ChangePostShowStatusVm>
    {
        public Guid PostGuid { get; set; }

        public bool ShowStatus { get; set; }

        public class ChangePostActivenessCommandHandler : IRequestHandler<ChangePostShowStatusCommand, ChangePostShowStatusVm>
        {
            private readonly IPisheyarContext _context;

            public ChangePostActivenessCommandHandler(IPisheyarContext context)
            {
                _context = context;
            }

            public async Task<ChangePostShowStatusVm> Handle(ChangePostShowStatusCommand request, CancellationToken cancellationToken)
            {
                Post post = await _context.Post
                    .SingleOrDefaultAsync(x => x.PostGuid == request.PostGuid && !x.IsDelete);

                if (post == null) return new ChangePostShowStatusVm
                {
                    Message = "پست مورد نظر یافت نشد",
                    State = (int)ChangePostShowStatusState.PostNotFound
                };

                post.IsShow = request.ShowStatus;
                post.ModifiedDate = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return new ChangePostShowStatusVm
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)ChangePostShowStatusState.Success
                };
            }
        }
    }
}
