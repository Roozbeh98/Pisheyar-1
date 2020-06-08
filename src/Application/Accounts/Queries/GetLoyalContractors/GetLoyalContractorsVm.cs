using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Application.Payments.Queries.GetLoyalContractors
{
    public class GetLoyalContractorsVm
    {
        public string Message { get; set; }

        public int State { get; set; }

        public List<GetLoyalContractorsDto> LoyalContractors { get; set; }
    }
}
