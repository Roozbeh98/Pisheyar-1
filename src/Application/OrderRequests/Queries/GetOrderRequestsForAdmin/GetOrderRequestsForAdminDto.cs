using AutoMapper;
using Pisheyar.Application.Common;
using Pisheyar.Application.Common.Mappings;
using Pisheyar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pisheyar.Application.OrderRequests.Queries.GetOrderRequestsForAdmin
{
    public class GetOrderRequestsForAdminDto : IMapFrom<OrderRequest>
    {
        public Guid OrderRequestGuid { get; set; }

        public string Contractor { get; set; }

        public string Message { get; set; }

        public long OfferedPrice { get; set; }

        public bool IsAllowed { get; set; }

        public bool IsAccepted { get; set; }

        public bool IsAccessible { get; set; }

        public string ModifiedDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OrderRequest, GetOrderRequestsForAdminDto>()
                .ForMember(d => d.IsAllowed, opt => opt.MapFrom(s => s.IsAllow))
                .ForMember(d => d.IsAccepted, opt => opt.MapFrom(s => s.IsAccept))
                .ForMember(d => d.IsAccessible, opt => opt.MapFrom(s => (s.Order.StateCodeId == 9 && s.IsAllow) || s.IsAccept))
                .ForMember(d => d.Contractor, opt => opt.MapFrom(s => s.Contractor.User.FirstName + " " + s.Contractor.User.LastName))
                .ForMember(d => d.ModifiedDate, opt => opt.MapFrom(s => PersianDateExtensionMethods.ToPeString(s.ModifiedDate, "yyyy/MM/dd HH:mm")));
        }
    }
}
