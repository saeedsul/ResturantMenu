using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResturantMenu.Api.Interfaces;
using ResturantMenu.Shared;

namespace ResturantMenu.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _productRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _productRepository.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            if (product == null)
                return BadRequest();

            if (string.IsNullOrEmpty(product.Name))
            {
                ModelState.AddModelError(nameof(product.Name), "Product name can not be empty");
            }
            if (product.CategoryId == 0)
            {
                ModelState.AddModelError(nameof(product.CategoryId), "Product CategoryId can not be empty");
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdProduct = await _productRepository.Add(product);

            return Created(nameof(Product), createdProduct);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Product product)
        {
            if (product == null)
                return BadRequest();

            if (string.IsNullOrEmpty(product.Name))
            {
                ModelState.AddModelError(nameof(product.Name), "Product name can not be empty");
            }
            if (product.CategoryId == 0)
            {
                ModelState.AddModelError(nameof(product.CategoryId), "Product CategoryId can not be empty");
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var productToUpdate = await _productRepository.Get(product.ProductId);
            
            if (productToUpdate == null)
                return NotFound();

            await _productRepository.Update(product);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
                return BadRequest();

            var toDelete = _productRepository.Get(id);
            if (toDelete == null)
                return NotFound();

            await _productRepository.Delete(id);

            return NoContent();//success
        }
    }
}
