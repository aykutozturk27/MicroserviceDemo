using AutoMapper;
using MicroserviceDemo.Business.Abstract;
using MicroserviceDemo.Business.BusinessAspects.Autofac;
using MicroserviceDemo.Business.Constants;
using MicroserviceDemo.Core.Utilities.Results.Abstract;
using MicroserviceDemo.Core.Utilities.Results.Concrete;
using MicroserviceDemo.Core.Utilities.WebService.RestSharp;
using MicroserviceDemo.DataAccess.Abstract;
using MicroserviceDemo.Entities.Concrete;
using MicroserviceDemo.Entities.Dtos;

namespace MicroserviceDemo.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IUserDal _userDal;
        private readonly IMapper _mapper;

        public ProductManager(IProductDal productDal, IUserDal userDal, IMapper mapper)
        {
            _productDal = productDal;
            _userDal = userDal;
            _mapper = mapper;
        }

        [SecuredOperation("product.list,admin")]
        public IDataResult<List<ProductListDto>> GetAll()
        {
            var productList = _productDal.GetList();
            var mappedProduct = _mapper.Map<ProductListDto>(productList);
            return new SuccessDataResult(mappedProduct, Messages.ProductsListed);
        }
    }
}
