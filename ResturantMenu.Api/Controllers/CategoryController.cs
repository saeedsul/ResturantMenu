using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResturantMenu.Api.Interfaces;
using ResturantMenu.Shared;

namespace ResturantMenu.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _categoryRepository.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _categoryRepository.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Category category)
        {
            if (category == null)
                return BadRequest();

            if (string.IsNullOrEmpty(category.Name))
            {
                ModelState.AddModelError(nameof(category.Name), "Category name can not be empty");
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdCategory = await _categoryRepository.Add(category);

            return Created(nameof(Category), createdCategory);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Category category)
        {
            if (category == null)
                return BadRequest();

            if (string.IsNullOrEmpty(category.Name))
            {
                ModelState.AddModelError(nameof(category.Name), "Category name can not be empty");
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var categoryToUpdate = await _categoryRepository.Get(category.CategoryId);

            if (categoryToUpdate == null)
                return NotFound();

            await _categoryRepository.Update(category);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
                return BadRequest();

            var toDelete = _categoryRepository.Get(id);
            if (toDelete == null)
                return NotFound();

            await _categoryRepository.Delete(id);

            return NoContent();//success
        }
    }
}