using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Application.Posts.Queries.GetAllAdvertisements
{
    public class GetAllAdvertisementsVm
    {
        public string Message { get; set; }

        public int State { get; set; }

        public IEnumerable<GetAllAdvertisementsDto> Advertisements { get; set; }
    }
}
