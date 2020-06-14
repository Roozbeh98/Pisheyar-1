using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Application.Posts.Queries.GetAllSuggestions
{
    public class GetAllSuggestionsVm
    {
        public string Message { get; set; }

        public int State { get; set; }

        public IEnumerable<GetAllSuggestionsDto> Suggestions { get; set; }
    }
}
