using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Domain.Enums
{
    public enum CreateAdvertisementState
    {
        Success = 1,
        DocumentGuidProblem = 2,
        DocumentNotFound = 3
    }

    public enum GetAllAdvertisementsState
    {
        Success = 1,
        NotAnyAdvertisements = 2
    }
}
