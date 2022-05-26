using AlatAssessment.Entity.DTOs;
using AlatAssessment.Entity.Models;
using AutoMapper;

namespace AlatAssessment.API.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Customer, CustomerResponseDto>()
                .ForMember(dest => dest.IsCustomerConfirmed, src => src.MapFrom(p => p.PhoneNumberConfirmed))
                .ForMember(dest => dest.State, src => src.MapFrom(p => p.StateId))
                .ForMember(dest => dest.LGA, src => src.MapFrom(p => p.LGAId));

            CreateMap<AddCustomerDto, Customer>();
        }
    }
}
