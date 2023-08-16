using AutoMapper;
using MicroserviceDemo.Entities.Concrete;
using MicroserviceDemo.Entities.Dtos;

namespace MicroserviceDemo.Business.Mappings.AutoMapper.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<List<Product>, ProductListDto>().ReverseMap();
        }
    }
}
