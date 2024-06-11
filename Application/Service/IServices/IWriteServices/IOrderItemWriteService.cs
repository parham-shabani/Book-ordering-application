using Application.Command.OrderCommands.CreateOrder;
using Application.Command.OrderCommands.UpdateOrder;
using Application.Command.OrderItemCommands.CreateOrderItem;
using Application.Command.OrderItemCommands.UpdateOrderItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.IServices.IWriteServices
{
    public interface IOrderItemWriteService
    {
        Task AddAsync(CreateOrderItemCommand request);
        Task UpdateAsync(UpdateOrderItemCommand request);
        Task DeleteByIdAsync(int id);
    }
}
