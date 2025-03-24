using AutoMapper;
using HotelProjectEntityLayer.Concrete;
using HotelProjectWebUI.Dtos.LoginDto;
using HotelProjectWebUI.Dtos.RegisterDto;
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
            CreateMap<CreateNewUserDto,AppUser>().ReverseMap();
            CreateMap<LoginUserDto,AppUser>().ReverseMap();
        }
    }
}
