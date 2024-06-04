using DelegatesAndEvents.Models;
using DelegatesAndEvents.Services;
using Microsoft.AspNetCore.Mvc;

namespace DelegatesAndEvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
                => _productService = productService;

        [HttpPost]
        [Route("/")]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            _productService.AddProduct(product); 
            return Ok("email enviado com sucesso!"); 
        }

    }
}
