using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Application.Payments.Queries.GetAllPayments
{
    public class GetAllPaymentsVm
    {
        public string Message { get; set; }

        public int State { get; set; }

        public List<GetAllPaymentsDto> Payments { get; set; }
    }
}
