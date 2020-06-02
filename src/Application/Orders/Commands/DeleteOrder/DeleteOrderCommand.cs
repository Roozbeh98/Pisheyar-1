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

namespace Pisheyar.Application.Orders.Commands.DeleteOrder
{
    public class DeleteOrderCommand : IRequest<DeleteOrderVm>
    {
        public Guid OrderGuid { get; set; }

        public class DeleteUserCommandHandler : IRequestHandler<DeleteOrderCommand, DeleteOrderVm>
        {
            private readonly IPisheyarContext _context;

            public DeleteUserCommandHandler(IPisheyarContext context)
            {
                _context = context;
            }

            public async Task<DeleteOrderVm> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
            {
                Order order = await _context.Order
                    .SingleOrDefaultAsync(x => x.OrderGuid == request.OrderGuid && !x.IsDelete);

                if (order == null) return new DeleteOrderVm()
                {
                    Message = "سفارش مورد نظر یافت نشد",
                    State = (int)DeleteOrderState.OrderNotFound
                };

                order.IsDelete = true;
                order.ModifiedDate = DateTime.Now;

                await _context.SaveChangesAsync(cancellationToken);

                return new DeleteOrderVm()
                {
                    Message = "عملیات موفق آمیز", 
                    State = (int)DeleteOrderState.Success
                };
            }
        }
    }
}
