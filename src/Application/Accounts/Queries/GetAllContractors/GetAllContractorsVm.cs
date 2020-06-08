using System.Collections.Generic;

namespace Pisheyar.Application.Accounts.Queries.GetAllContractors
{
    public class GetAllContractorsVm
    {
        public string Message { get; set; }

        public int State { get; set; }

        public IEnumerable<GetAllContractorsDto> Contractors { get; set; }
    }
}
