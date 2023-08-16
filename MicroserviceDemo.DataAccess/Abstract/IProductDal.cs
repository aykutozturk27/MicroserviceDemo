using MicroserviceDemo.Core.DataAccess;
using MicroserviceDemo.Entities.Concrete;

namespace MicroserviceDemo.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
