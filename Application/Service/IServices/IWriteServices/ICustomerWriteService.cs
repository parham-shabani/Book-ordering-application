using Application.Command.CustomerCommands.CreateCustomer;
using Application.Command.CustomerCommands.UpdateCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service.IServices.IWriteServices
{
    public interface ICustomerWriteService
    {
        Task AddAsync(CreateCustomerCommand request);
        Task UpdateAsync(UpdateCustomerCommand request);
        Task DeleteByIdAsync(int id);
    }
}
