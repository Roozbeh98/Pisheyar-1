using AutoMapper;
using Pisheyar.Application.Common;
using Pisheyar.Application.Common.Mappings;
using Pisheyar.Application.Posts.Queries.GetAllPosts;
using Pisheyar.Domain.Entities;
using System;
using System.Linq;

namespace Pisheyar.Application.Accounts.Queries.GetAllContractors
{
    public class GetAllContractorsDto : IMapFrom<User>
    {
        public Guid UserGuid { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Gender { get; set; }

        public string ProfileImage { get; set; }

        public string City { get; set; }

        public string Business { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public int Credit { get; set; }

        public double? AverageRate { get; set; }

        public bool IsActive { get; set; }

        public bool IsRegister { get; set; }

        public string RegisteredDate { get; set; }

        public string ModifiedDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<User, GetAllContractorsDto>()
                .ForMember(d => d.Gender, opt => opt.MapFrom(s => s.GenderCode.DisplayName ))
                .ForMember(d => d.ProfileImage, opt => opt.MapFrom(s => s.ProfileDocument.Path ))
                .ForMember(d => d.City, opt => opt.MapFrom(s => s.Contractor.Select(x => x.City.Name).FirstOrDefault()))
                .ForMember(d => d.Business, opt => opt.MapFrom(s => s.Contractor.Select(x => x.BusinessTypeCode.Name).FirstOrDefault()))
                .ForMember(d => d.Latitude, opt => opt.MapFrom(s => s.Contractor.Select(x => x.Latitude).FirstOrDefault()))
                .ForMember(d => d.Longitude, opt => opt.MapFrom(s => s.Contractor.Select(x => x.Longitude).FirstOrDefault()))
                .ForMember(d => d.Credit, opt => opt.MapFrom(s => s.Contractor.Select(x => x.Credit).FirstOrDefault()))
                .ForMember(d => d.AverageRate, opt => opt.MapFrom(s => s.Contractor.Select(x => x.AverageRate).FirstOrDefault()))
                .ForMember(d => d.RegisteredDate, opt => opt.MapFrom(s => PersianDateExtensionMethods.ToPeString(s.RegisteredDate, "yyyy/MM/dd HH:mm")))
                .ForMember(d => d.ModifiedDate, opt => opt.MapFrom(s => PersianDateExtensionMethods.ToPeString(s.ModifiedDate, "yyyy/MM/dd HH:mm")));
        }
    }
}
