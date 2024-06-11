using Application.Command.CustomerCommands.CreateCustomer;
using Application.Command.CustomerCommands.DeleteCustomer;
using Application.Command.CustomerCommands.UpdateCustomer;
using Application.Command.OrderItemCommands.CreateOrderItem;
using Application.Command.OrderItemCommands.DeleteOrderItem;
using Application.Command.OrderItemCommands.UpdateOrderItem;
using Application.Query.OrderItemQueries.GetOrderItem;
using Application.Query.OrderItemQueries.GetOrderItems;

using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookOrdering.Controllers
{
    [ApiController]
    [Route("api/orderItem")]
    public class OrderItemController : ControllerBase
    {
        
        private readonly ISender _sender;
        public OrderItemController(ISender sender)
        {
            _sender = sender;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllItemOrders()
        {
            var itemOrders = await _sender.Send(new GetOrderItemsQuery { });
            return Ok(itemOrders);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderItemById(int id)
        {
            var orderItem = await _sender.Send(new GetOrderItemQuery { Id = id });
            if (orderItem == null)
            {
                return NotFound();
            }
            return Ok(orderItem);
        }


        [HttpPost]
        public async Task<IActionResult> CreateOrderItem(CreateOrderItemCommand request)
        {
            var result = await _sender.Send(request);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrderItem(int id, UpdateOrderItemDto request)
        {
            await _sender.Send(new UpdateOrderItemCommand(id, request));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItem(int id)
        {
            await _sender.Send(new DeleteOrderItemCommand(id));
            return NoContent();
        }
    }
}
