using System.Collections.Generic;

namespace Pisheyar.Application.Accounts.Queries.GetAllClients
{
    public class GetAllClientsVm
    {
        public string Message { get; set; }

        public int State { get; set; }

        public IEnumerable<GetAllClientsDto> Clients { get; set; }
    }
}
