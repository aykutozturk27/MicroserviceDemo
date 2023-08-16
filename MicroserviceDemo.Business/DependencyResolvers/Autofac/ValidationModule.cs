using Autofac;
using FluentValidation;
using MicroserviceDemo.Business.ValidationRules.FluentValidation;
using MicroserviceDemo.Entities.Dtos;

namespace MicroserviceDemo.Business.DependencyResolvers.Autofac
{
    public class ValidationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserLoginValidator>().As<IValidator<UserForLoginDto>>();
            builder.RegisterType<UserRegisterValidator>().As<IValidator<UserForRegisterDto>>();
        }
    }
}
