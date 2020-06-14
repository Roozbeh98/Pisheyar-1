using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Application.CodeGroups.Queries.GetAllCodeGroups
{
    public class GetAllCodeGroupsVm
    {
        public string Message { get; set; }

        public int State { get; set; }

        public IEnumerable<GetAllCodeGroupsDto> CodeGroups { get; set; }
    }
}
