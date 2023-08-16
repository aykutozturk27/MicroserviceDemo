using Autofac;
using AutoMapper;
using MicroserviceDemo.Business.Mappings.AutoMapper.Profiles;

namespace MicroserviceDemo.Business.DependencyResolvers.Autofac
{
    public class AutoMapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(CreateConfiguration().CreateMapper()).As<IMapper>();
        }

        private MapperConfiguration CreateConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                //cfg.AddProfile(new ProductProfile());
                //cfg.AddProfile(new UserProfile());
                cfg.AddMaps(GetType().Assembly);
            });

            return config;
        }
    }
}
