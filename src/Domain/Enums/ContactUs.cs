using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Domain.Enums
{
    public enum SendContactUsMessgae
    {
        Success = 1,
        CategoryNotFound = 2
    }

    public enum GetAllContactUsMessagesState
    {
        Success = 1,
        UserNotFound = 2,
        AdminNotFound = 3,
        NotAnyMessages = 4
    }
}
