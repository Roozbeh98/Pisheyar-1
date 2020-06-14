using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Domain.Enums
{
    public enum CreateSuggestionState
    {
        Success = 1,
        UserNotFound = 2
    }

    public enum GetAllSuggestionsState
    {
        Success = 1,
        UserNotFound = 2,
        AdminNotFound = 3,
        NotAnySuggestions = 4
    }
}
