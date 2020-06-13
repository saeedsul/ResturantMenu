using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResturantMenu.Api.Interfaces;
using ResturantMenu.Shared;

namespace ResturantMenu.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _orderRepository.Get());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _orderRepository.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Order order)
        {
            if (order == null)
                return BadRequest();

            if (!(order.Products.Any()))
            {
                ModelState.AddModelError(nameof(order.Products), "can not be empty");
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdOrder = await _orderRepository.Add(order);

            return Created(nameof(Order), createdOrder);
        }
    }
}
