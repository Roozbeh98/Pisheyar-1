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

namespace Pisheyar.Application.Accounts.Commands.DeleteUser
{
    public class DeleteUserCommand : IRequest<DeleteUserVm>
    {
        public Guid UserGuid { get; set; }

        public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, DeleteUserVm>
        {
            private readonly IPisheyarContext _context;

            public DeleteUserCommandHandler(IPisheyarContext context)
            {
                _context = context;
            }

            public async Task<DeleteUserVm> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
            {
                User user = await _context.User
                    .SingleOrDefaultAsync(x => x.UserGuid == request.UserGuid && !x.IsDelete);

                if (user == null) return new DeleteUserVm()
                {
                    Message = "کاربر مورد نظر یافت نشد",
                    State = (int)DeleteUserState.UserNotFound
                };

                user.IsDelete = true;
                user.ModifiedDate = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return new DeleteUserVm() 
                {
                    Message = "عملیات موفق آمیز",
                    State = (int)DeleteUserState.Success 
                };
            }
        }
    }
}
