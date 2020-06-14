using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Domain.Enums
{
    public enum CodeType
    {
        Success = 1,
        CodeGroupNotFound = 3
    }

    public enum CreateCodeState
    {
        Success = 1,
        UserNotFound = 2,
        AdminNotFound = 3,
        CodeGroupNotFound = 4
    }

    public enum DeleteCodeState
    {
        Success = 1,
        CodeNotFound = 2
    }
}
