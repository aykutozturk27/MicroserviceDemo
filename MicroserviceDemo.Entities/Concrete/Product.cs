using MicroserviceDemo.Core.Entities;

namespace MicroserviceDemo.Entities.Concrete
{
    public class Product : EntityBase
    {
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
    }
}
