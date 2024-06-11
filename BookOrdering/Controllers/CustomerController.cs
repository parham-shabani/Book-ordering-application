using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entity;
using MediatR;
using Application.Query.CustomerQueries.GetCustomer;
using Application.Query.CustomerQueries.GetCustomers;
using Application.Command.CustomerCommands.CreateCustomer;
using Azure.Core;
using Application.Command.CustomerCommands.UpdateCustomer;
using Application.Command.CustomerCommands.DeleteCustomer;

namespace BookOrdering.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly ISender _sender;

        public CustomerController(ISender sender)
        {
            _sender = sender;
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var customers = await _sender.Send(new GetCustomersQuery());
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var customer = await _sender.Send(new GetCustomerQuery { Id = id});

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CreateCustomerCommand request)
        {
            var result = await _sender.Send(request);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int id, UpdateCustomerDto request)
        {
            await _sender.Send(new UpdateCustomerCommand(id, request));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            await _sender.Send(new DeleteCustomerCommand(id));
            return NoContent();
        }
    }
}