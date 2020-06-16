using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Domain.Enums
{
    public enum CreatePublicDiscountState
    {
        Success = 1,
        UserNotFound = 2,
        AdminNotFound = 3,
        TypeCodeNotFound = 4
    }
}
