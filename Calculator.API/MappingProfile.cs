using AutoMapper;
using Calculator.API.Dtos;
using Calculator.API.Services;

namespace Calculator.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CoordinateDto, Coordinate>();
        }
    }
}
