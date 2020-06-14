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

namespace Pisheyar.Application.Codes.Commands.CreateCode
{
    public class CreateCodeCommand : IRequest<CreateCodeVm>
    {
        public Guid CodeGroupGuid { get; set; }

        public string Name { get; set; }

        public string DisplayName { get; set; }

        public class CreateComplaintCommandHandler : IRequestHandler<CreateCodeCommand, CreateCodeVm>
        {
            private readonly IPisheyarContext _context;
            private readonly ICurrentUserService _currentUser;

            public CreateComplaintCommandHandler(IPisheyarContext context, ICurrentUserService currentUser)
            {
                _context = context;
                _currentUser = currentUser;
            }

            public async Task<CreateCodeVm> Handle(CreateCodeCommand request, CancellationToken cancellationToken)
            {
                User currentUser = await _context.User
                    .Where(x => x.UserGuid == Guid.Parse(_currentUser.NameIdentifier))
                    .SingleOrDefaultAsync(cancellationToken);

                if (currentUser == null) return new CreateCodeVm()
                {
                    Message = "کاربر مورد نظر یافت نشد",
                    State = (int)CreateCodeState.UserNotFound
                };

                Admin admin = await _context.Admin
                    .SingleOrDefaultAsync(x => x.UserId == currentUser.UserId, cancellationToken);

                if (admin == null) return new CreateCodeVm()
                {
                    Message = "ادمین مورد نظر یافت نشد",
                    State = (int)CreateCodeState.AdminNotFound
                };

                CodeGroup codeGroup = await _context.CodeGroup
                    .SingleOrDefaultAsync(x => x.CodeGroupGuid == request.CodeGroupGuid, cancellationToken);

                if (codeGroup == null) return new CreateCodeVm()
                {
                    Message = "کد گروه مورد نظر یافت نشد",
                    State = (int)CreateCodeState.CodeGroupNotFound
                };

                Code code = new Code()
                {
                    CodeGroupId = codeGroup.CodeGroupId,
                    Name = request.Name,
                    DisplayName = request.DisplayName
                };

                _context.Code.Add(code);

                await _context.SaveChangesAsync(cancellationToken);

                return new CreateCodeVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)CreateCodeState.Success
                };
            }
        }
    }
}
