using AutoMapper;
using Diploma1.Application.DTO;
using Diploma1.Domain.Entities;
using Diploma1.Domain.ValueObjects;

namespace Diploma1.Application.Mappings
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FullName.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.FullName.LastName))
                .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.FullName.MiddleName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email.Value))
                .ReverseMap()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => new FullName(src.FirstName, src.LastName, src.MiddleName)))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => Email.Create(src.Email)));
        }
    }
}