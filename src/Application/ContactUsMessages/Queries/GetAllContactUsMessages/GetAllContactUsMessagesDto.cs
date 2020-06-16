using AutoMapper;
using Pisheyar.Application.Common;
using Pisheyar.Application.Common.Mappings;
using Pisheyar.Application.Common.UploadHelper.Filepond;
using Pisheyar.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Pisheyar.Application.ContactUsMessages.Queries.GetAllContactUsMessages
{
    public class GetAllContactUsMessagesDto : IMapFrom<ContactUs>
    {
        public Guid ContactUsGuid { get; set; }

        public string ContactUsBusinessTypeCode { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string CreationDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ContactUs, GetAllContactUsMessagesDto>()
                .ForMember(d => d.ContactUsBusinessTypeCode, opt => opt.MapFrom(s => s.ContactUsBusinessTypeCode.DisplayName))
                .ForMember(d => d.CreationDate, opt => opt.MapFrom(s => PersianDateExtensionMethods.ToPeString(s.CreationDate, "yyyy/MM/dd HH:mm")));

        }
    }
}
