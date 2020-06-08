using AutoMapper;
using Pisheyar.Application.Common.Mappings;
using Pisheyar.Domain.Entities;
using System;

namespace Pisheyar.Application.Posts.Queries.GetPostsByCategory
{
    public class GetPostsByCategoryDto : IMapFrom<Post>
    {
        public Guid PostGuid { get; set; }

        public string UserFullName { get; set; }

        public int ViewCount { get; set; }

        public int LikeCount { get; set; }

        public string Title { get; set; }

        public string Abstract { get; set; }

        public string Description { get; set; }

        public bool IsShow { get; set; }

        public bool IsSuggested { get; set; }

        public bool IsInSlider { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string DocumentFileName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Post, GetPostsByCategoryDto>()
                .ForMember(d => d.UserFullName, opt => opt.MapFrom(s => s.User.FirstName + " " + s.User.LastName))
                .ForMember(d => d.DocumentFileName, opt => opt.MapFrom(s => s.Document.Name));
        }
    }
}
