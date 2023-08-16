using MicroserviceDemo.Core.Entities;
using MicroserviceDemo.Entities.Concrete;

namespace MicroserviceDemo.Entities.Dtos
{
    public class ProductListDto : IDto
    {
        public IList<Product> Products { get; set; }
    }
}
