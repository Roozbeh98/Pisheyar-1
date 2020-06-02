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

namespace Pisheyar.Application.Accounts.Commands.DeleteOrderRequest
{
    public class DeleteOrderRequestCommand : IRequest<DeleteOrderRequestVm>
    {
        public Guid OrderRequestGuid { get; set; }

        public class DeleteUserCommandHandler : IRequestHandler<DeleteOrderRequestCommand, DeleteOrderRequestVm>
        {
            private readonly IPisheyarContext _context;

            public DeleteUserCommandHandler(IPisheyarContext context)
            {
                _context = context;
            }

            public async Task<DeleteOrderRequestVm> Handle(DeleteOrderRequestCommand request, CancellationToken cancellationToken)
            {
                OrderRequest orderRequest = await _context.OrderRequest
                    .SingleOrDefaultAsync(x => x.OrderRequestGuid == request.OrderRequestGuid && !x.IsDelete);

                if (orderRequest == null) return new DeleteOrderRequestVm()
                {
                    Message = "درخواست سفارش مورد نظر یافت نشد",
                    State = (int)DeleteOrderRequestState.OrderRequestNotFound
                };

                orderRequest.IsDelete = true;
                orderRequest.ModifiedDate = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return new DeleteOrderRequestVm()
                {
                    Message = "عملیات موفق آمیز", 
                    State = (int)DeleteOrderRequestState.Success
                };
            }
        }
    }
}
