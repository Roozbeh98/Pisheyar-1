using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Application.OrderRequests.Queries.GetOrderRequestsForAdmin
{
    public class GetOrderRequestsForAdminVm
    {
        public string Message { get; set; }

        public int State { get; set; }

        public List<GetOrderRequestsForAdminDto> OrderRequests { get; set; }
    }
}
