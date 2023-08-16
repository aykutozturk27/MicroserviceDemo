using MicroserviceDemo.Core.Utilities.Results.Abstract;
using MicroserviceDemo.Entities.Concrete;
using MicroserviceDemo.Entities.Dtos;

namespace MicroserviceDemo.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<ProductListDto> GetAll();
        //IDataResult<List<Product>> GetAll();
    }
}
