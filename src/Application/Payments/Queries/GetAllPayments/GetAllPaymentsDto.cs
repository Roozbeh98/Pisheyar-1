using AutoMapper;
using Pisheyar.Application.Common;
using Pisheyar.Application.Common.Mappings;
using Pisheyar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pisheyar.Application.Payments.Queries.GetAllPayments
{
    public class GetAllPaymentsDto : IMapFrom<Payment>
    {
        public Guid PaymentGuid { get; set; }

        public string Contractor { get; set; }

        public int Cost { get; set; }

        public int Discount { get; set; }

        public long? TrackingToken { get; set; }

        public bool IsSuccessful { get; set; }

        public string CreationDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Payment, GetAllPaymentsDto>()
                .ForMember(d => d.Contractor, opt => opt.MapFrom(s => s.Contractor.User.FirstName + " " + s.Contractor.User.LastName))
                .ForMember(d => d.CreationDate, opt => opt.MapFrom(s => PersianDateExtensionMethods.ToPeString(s.CreationDate, "yyyy/MM/dd HH:mm")));
        }
    }
}
