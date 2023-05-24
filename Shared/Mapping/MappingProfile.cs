using AutoMapper;
using DataAccessLayer.Models;
using Shared.DTO;

namespace Shared.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<EmpDetail, EmpDTO>()
            .ForMember(dest => dest.Id, act => act.MapFrom(src => src.EmpId))
            //.ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            //.ForMember(dest => dest.Age, act => act.MapFrom(src => src.Age))
            //.ForMember(dest => dest.Gender, act => act.MapFrom(src => src.Gender))
            //.ForMember(dest => dest.City, act => act.MapFrom(src => src.City))
            .ReverseMap();
        }
    }
}
