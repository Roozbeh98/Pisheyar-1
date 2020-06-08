using AutoMapper;
using Pisheyar.Application.Common;
using Pisheyar.Application.Common.Mappings;
using Pisheyar.Application.Posts.Queries.GetAllPosts;
using Pisheyar.Domain.Entities;
using System;
using System.Linq;

namespace Pisheyar.Application.Accounts.Queries.GetAllClients
{
    public class GetAllClientsDto : IMapFrom<User>
    {
        public Guid UserGuid { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Gender { get; set; }

        public string ProfileImage { get; set; }

        public string City { get; set; }

        public bool IsActive { get; set; }

        public bool IsRegister { get; set; }

        public string RegisteredDate { get; set; }

        public string ModifiedDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<User, GetAllClientsDto>()
                .ForMember(d => d.Gender, opt => opt.MapFrom(s => s.GenderCode.DisplayName))
                .ForMember(d => d.ProfileImage, opt => opt.MapFrom(s => s.ProfileDocument.Path))
                .ForMember(d => d.City, opt => opt.MapFrom(s => s.Client.Select(x => x.City.Name).FirstOrDefault()))
                .ForMember(d => d.RegisteredDate, opt => opt.MapFrom(s => PersianDateExtensionMethods.ToPeString(s.RegisteredDate, "yyyy/MM/dd HH:mm")))
                .ForMember(d => d.ModifiedDate, opt => opt.MapFrom(s => PersianDateExtensionMethods.ToPeString(s.ModifiedDate, "yyyy/MM/dd HH:mm")));
        }
    }
}
