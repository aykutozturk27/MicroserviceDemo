using MicroserviceDemo.Core.DataAccess.EntityFramework;
using MicroserviceDemo.DataAccess.Abstract;
using MicroserviceDemo.DataAccess.Concrete.EntityFramework.Contexts;
using MicroserviceDemo.Entities.Concrete;

namespace MicroserviceDemo.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, MicroserviceDemoContext>, IProductDal
    {
    }
}
