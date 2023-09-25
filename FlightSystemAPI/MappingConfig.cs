using AutoMapper;
using FlightSystem.BLL.Models.Dto;
using FlightSystem.DAL.Models;

namespace FlightSystem.WebAPI
{
    public class MappingConfig: Profile
    {
        public MappingConfig()
        {
            //A mapping is created indicating that when AutoMapper maps from Flight to FlightDto, it should ignore the Id property.
            CreateMap<Journey, JourneyDto>().ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.Ignore()); // Ignore the Id property
        }
    }
}
