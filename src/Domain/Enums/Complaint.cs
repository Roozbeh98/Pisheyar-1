using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Domain.Enums
{
    public enum CreateComplaintState
    {
        Success = 1,
        UserNotFound = 2
    }

    public enum GetAllComplaintsState
    {
        Success = 1,
        UserNotFound = 2,
        AdminNotFound = 3,
        NotAnyComplaints = 4
    }
}
