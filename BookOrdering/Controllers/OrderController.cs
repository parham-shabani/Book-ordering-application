using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.Query.OrderQueries.GetOrders;
using Application.Query.OrderQueries.GetOrder;
using Application.Command.CustomerCommands.DeleteCustomer;
using Application.Command.OrderCommands.CreateOrder;
using Application.Command.OrderCommands.UpdateOrder;

namespace BookOrdering.Controllers
{

    [ApiController]
    [Route("api/orders")]

    public class OrderController : ControllerBase
    {

        private readonly ISender _sender;
        public OrderController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var orders = await _sender.Send(new GetOrdersQuery());
            return Ok(orders);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var order = await _sender.Send(new GetOrderQuery { Id = id });
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }


        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderCommand request)
        {
            var result = await _sender.Send(request);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(int id, UpdateOrderDto request)
        {
            await _sender.Send(new UpdateOrderCommand(id, request));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            await _sender.Send(new DeleteCustomerCommand(id));
            return NoContent();
        }

    }
}