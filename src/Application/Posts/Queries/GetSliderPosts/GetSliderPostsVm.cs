using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Application.Posts.Queries.GetSliderPosts
{
    public class GetSliderPostsVm
    {
        public string Message { get; set; }

        public int State { get; set; }

        public IEnumerable<GetSliderPostsDto> Posts { get; set; }
    }
}
