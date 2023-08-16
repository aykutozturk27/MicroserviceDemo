using AutoMapper;
using MicroserviceDemo.Entities.Concrete;
using MicroserviceDemo.Entities.Dtos;

namespace MicroserviceDemo.Business.Mappings.AutoMapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserForLoginDto>().ReverseMap();
            CreateMap<User, UserForRegisterDto>().ReverseMap();
        }
    }
}
