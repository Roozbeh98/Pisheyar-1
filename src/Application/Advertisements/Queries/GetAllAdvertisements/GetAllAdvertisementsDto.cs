using AutoMapper;
using Pisheyar.Application.Common;
using Pisheyar.Application.Common.Mappings;
using Pisheyar.Application.Common.UploadHelper.Filepond;
using Pisheyar.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Pisheyar.Application.Posts.Queries.GetAllAdvertisements
{
    public class GetAllAdvertisementsDto : IMapFrom<Advertisement>
    {
        public Guid AdvertisementGuid { get; set; }

        public string DocumentPath { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ModifiedDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Advertisement, GetAllAdvertisementsDto>()
                .ForMember(d => d.DocumentPath, opt => opt.MapFrom(s => s.Document.Path))
                .ForMember(d => d.ModifiedDate, opt => opt.MapFrom(s => PersianDateExtensionMethods.ToPeString(s.ModifiedDate, "yyyy/MM/dd HH:mm")));
        }
    }
}
