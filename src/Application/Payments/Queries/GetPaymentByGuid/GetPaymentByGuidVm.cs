using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Application.Payments.Queries.GetPaymentByGuid
{
    public class GetPaymentByGuidVm
    {
        public string Message { get; set; }

        public int State { get; set; }

        public GetPaymentByGuidDto Payment { get; set; }
    }
}
