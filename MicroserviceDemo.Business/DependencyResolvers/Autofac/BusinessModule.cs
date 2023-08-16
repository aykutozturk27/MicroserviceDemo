using Autofac;
using MicroserviceDemo.Business.Abstract;
using MicroserviceDemo.Business.Abstract.Token;
using MicroserviceDemo.Business.Concrete.JWT;
using MicroserviceDemo.Business.Concrete.Managers;
using MicroserviceDemo.DataAccess.Abstract;
using MicroserviceDemo.DataAccess.Concrete.EntityFramework;

namespace MicroserviceDemo.Business.DependencyResolvers.Autofac
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();

            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<UserManager>().As<IUserService>();

            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
        }
    }
}
