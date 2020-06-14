using AutoMapper;
using Pisheyar.Application.Common;
using Pisheyar.Application.Common.Mappings;
using Pisheyar.Application.Common.UploadHelper.Filepond;
using Pisheyar.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Pisheyar.Application.Posts.Queries.GetAllComplaints
{
    public class GetAllComplaintsDto : IMapFrom<Complaint>
    {
        public Guid ComplaintGuid { get; set; }

        public string User { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public string CreationDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Complaint, GetAllComplaintsDto>()
                .ForMember(d => d.User, opt => opt.MapFrom(s => s.User.FirstName + " " + s.User.LastName))
                .ForMember(d => d.CreationDate, opt => opt.MapFrom(s => PersianDateExtensionMethods.ToPeString(s.CreationDate, "yyyy/MM/dd HH:mm")));
        }
    }
}
