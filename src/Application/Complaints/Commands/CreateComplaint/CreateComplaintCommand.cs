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

namespace Pisheyar.Application.Contact.Commands.CreateComplaint
{
    public class CreateComplaintCommand : IRequest<CreateComplaintVm>
    {
        public string Subject { get; set; }

        public string Description { get; set; }

        public class CreateComplaintCommandHandler : IRequestHandler<CreateComplaintCommand, CreateComplaintVm>
        {
            private readonly IPisheyarContext _context;
            private readonly ICurrentUserService _currentUser;

            public CreateComplaintCommandHandler(IPisheyarContext context, ICurrentUserService currentUser)
            {
                _context = context;
                _currentUser = currentUser;
            }

            public async Task<CreateComplaintVm> Handle(CreateComplaintCommand request, CancellationToken cancellationToken)
            {
                User currentUser = await _context.User
                    .Where(x => x.UserGuid == Guid.Parse(_currentUser.NameIdentifier))
                    .SingleOrDefaultAsync(cancellationToken);

                if (currentUser == null) return new CreateComplaintVm()
                {
                    Message = "کاربر مورد نظر یافت نشد",
                    State = (int)CreateComplaintState.UserNotFound
                };

                Complaint complaint = new Complaint()
                {
                    UserId = currentUser.UserId,
                    Subject = request.Subject,
                    Description = request.Description
                };

                _context.Complaint.Add(complaint);

                await _context.SaveChangesAsync(cancellationToken);

                return new CreateComplaintVm()
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)CreateComplaintState.Success
                };
            }
        }
    }
}
