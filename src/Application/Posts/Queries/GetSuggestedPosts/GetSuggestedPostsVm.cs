using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Application.Posts.Queries.GetSuggestedPosts
{
    public class GetSuggestedPostsVm
    {
        public string Message { get; set; }

        public int State { get; set; }

        public IEnumerable<GetSuggestedPostsDto> Posts { get; set; }
    }
}
