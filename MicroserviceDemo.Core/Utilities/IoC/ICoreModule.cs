using Microsoft.Extensions.DependencyInjection;

namespace MicroserviceDemo.Core.Utilities.IoC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}
