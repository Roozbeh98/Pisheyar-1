using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Application.Posts.Queries.GetAllComplaints
{
    public class GetAllComplaintsVm
    {
        public string Message { get; set; }

        public int State { get; set; }

        public IEnumerable<GetAllComplaintsDto> Complaints { get; set; }
    }
}
