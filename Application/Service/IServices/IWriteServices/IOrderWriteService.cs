using Application.Command.OrderCommands.CreateOrder;
using Application.Command.OrderCommands.UpdateOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.IServices.IWriteServices
{
    public interface IOrderWriteService
    {
        Task AddAsync(CreateOrderCommand request);
        Task UpdateAsync(UpdateOrderCommand request);
        Task DeleteByIdAsync(int id);
    }
}
