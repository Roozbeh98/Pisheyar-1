﻿using AutoMapper;
using Pisheyar.Application.Common;
using Pisheyar.Application.Common.Mappings;
using Pisheyar.Application.Common.UploadHelper.Filepond;
using Pisheyar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Application.Posts.Queries.GetMostViewedPosts
{
    public class GetMostViewedPostsDto : IMapFrom<Post>
    {
        public Guid PostGuid { get; set; }

        public FilepondDto Document { get; set; }

        public GetMostViewedPostsCategoryNameDto Category { get; set; }

        public List<GetMostViewedPostsTagNameDto> Tags { get; set; }

        public string UserFullName { get; set; }

        public int ViewCount { get; set; }

        public int LikeCount { get; set; }

        public string Title { get; set; }

        public string Abstract { get; set; }

        public string Description { get; set; }

        public bool IsShow { get; set; }

        public bool IsSuggested { get; set; }

        public bool IsInSlider { get; set; }

        public string ModifiedDate { get; set; }

        public string Slug { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Post, GetMostViewedPostsDto>()
                .ForMember(d => d.UserFullName, opt => opt.MapFrom(s => s.User.FirstName + " " + s.User.LastName))
                .ForMember(d => d.ModifiedDate, opt => opt.MapFrom(s => PersianDateExtensionMethods.ToPeString(s.ModifiedDate, "yyyy/MM/dd HH:mm")))
                .ForMember(d => d.Slug, opt => opt.MapFrom(s => s.Title.Trim().ToLowerInvariant().Replace(" ", "-")))
                .ForMember(d => d.Document, opt => opt.MapFrom(s => new FilepondDto
                {
                    Source = s.Document.Path,
                    Options = new FilepondOptions
                    {
                        Type = "local",
                        Files = new FilepondFile
                        {
                            Name = s.Document.Name,
                            Size = s.Document.Size.ToString(),
                            Type = s.Document.TypeCode.Name
                        },
                        Metadata = new FilepondMetadata
                        {
                            Poster = s.Document.Path
                        }
                    }
                }));
        }
    }

    public class GetMostViewedPostsCategoryNameDto
    {
        public Guid Guid { get; set; }

        public string Title { get; set; }
    }

    public class GetMostViewedPostsTagNameDto
    {
        public Guid Guid { get; set; }

        public string Name { get; set; }
    }
}
