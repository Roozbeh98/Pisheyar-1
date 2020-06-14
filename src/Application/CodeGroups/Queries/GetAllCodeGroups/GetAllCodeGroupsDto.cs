using AutoMapper;
using Pisheyar.Application.Common;
using Pisheyar.Application.Common.Mappings;
using Pisheyar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Application.CodeGroups.Queries.GetAllCodeGroups
{
    public class GetAllCodeGroupsDto : IMapFrom<CodeGroup>
    {
        public Guid CodeGroupGuid { get; set; }

        public string DisplayName { get; set; }

        public string ModifiedDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CodeGroup, GetAllCodeGroupsDto>()
                .ForMember(d => d.ModifiedDate, opt => opt.MapFrom(s => PersianDateExtensionMethods.ToPeString(s.ModifiedDate, "yyyy/MM/dd HH:mm")));
        }
    }
}
