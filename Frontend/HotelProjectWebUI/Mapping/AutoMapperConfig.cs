using AutoMapper;
using HotelProjectEntityLayer.Concrete;
using HotelProjectWebUI.Dtos.ServiceDto;

namespace HotelProjectWebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto,Service>().ReverseMap();
            CreateMap<UpdateServiceDto,Service>().ReverseMap();
            CreateMap<CreateServiceDto,Service>().ReverseMap();
        }
    }
}
