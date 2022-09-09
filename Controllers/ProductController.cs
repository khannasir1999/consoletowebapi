using Consoletowebapi.Models;
using Consoletowebapi.Repository_Layer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Consoletowebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {private readonly IproductRepository _productRepository;
        private readonly IproductRepository _productRepository1;


        public ProductController(IproductRepository productRepository, IproductRepository productRepository1)
        {
           _productRepository = productRepository;
            _productRepository1 = productRepository1;
        }

        [HttpPost("")]
        public IActionResult Addproduct([FromBody] ProductsModel product)
        {
            _productRepository.AddProduct(product);
            var products = _productRepository1.getProducts();
       
            return Ok(products);

        }
        [HttpGet("")]
        public IActionResult GetName()
        {
          
            var name = _productRepository.GetName();

            return Ok(name);

        }
    }
}
