using MicroserviceDemo.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceDemo.ProductAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var productList = _productService.GetAll();
            if (productList == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(productList);
            }
        }
    }
}
