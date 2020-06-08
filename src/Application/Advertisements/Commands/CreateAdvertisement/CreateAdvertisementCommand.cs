using MediatR;
using Microsoft.EntityFrameworkCore;
using Pisheyar.Application.Common.Interfaces;
using Pisheyar.Application.Posts.Commands.CreatePost;
using Pisheyar.Domain.Entities;
using Pisheyar.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pisheyar.Application.Advertisements.Commands.CreateAdvertisement
{
    public class CreateAdvertisementCommand : IRequest<CreateAdvertisementVm>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsShow { get; set; }

        public string DocumentGuid { get; set; }

        public class CreateAdvertisementCommandHandler : IRequestHandler<CreateAdvertisementCommand, CreateAdvertisementVm>
        {
            private readonly IPisheyarContext _context;
            private readonly ICurrentUserService _currentUser;

            public CreateAdvertisementCommandHandler(IPisheyarContext context, ICurrentUserService currentUser)
            {
                _context = context;
                _currentUser = currentUser;
            }

            public async Task<CreateAdvertisementVm> Handle(CreateAdvertisementCommand request, CancellationToken cancellationToken)
            {
                User currentUser = await _context.User
                    .Where(x => x.UserGuid == Guid.Parse(_currentUser.NameIdentifier))
                    .SingleOrDefaultAsync(cancellationToken);

                if (currentUser == null) return new CreateAdvertisementVm()
                {
                    Message = "کاربر مورد نظر یافت نشد",
                    State = (int)CreatePostState.UserNotFound
                };

                Guid.TryParse(request.DocumentGuid, out Guid documentGuid);

                if (documentGuid == Guid.Empty) return new CreateAdvertisementVm
                {
                    Message = "تصویر آپلود شده شناسایی نشد",
                    State = (int)CreateAdvertisementState.DocumentGuidProblem
                };

                Document document = await _context.Document
                    .SingleOrDefaultAsync(x => x.DocumentGuid == documentGuid, cancellationToken);

                if (document == null) return new CreateAdvertisementVm()
                {
                    Message = "تصویر مورد نظر یافت نشد",
                    State = (int)CreateAdvertisementState.DocumentNotFound
                };

                Advertisement advertisement = new Advertisement()
                {
                    DocumentId = document.DocumentId,
                    Title = request.Title,
                    Description = request.Description,
                    IsShow = request.IsShow
                };

                _context.Advertisement.Add(advertisement);

                await _context.SaveChangesAsync(cancellationToken);

                return new CreateAdvertisementVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)CreatePostState.Success
                };
            }
        }
    }
}
