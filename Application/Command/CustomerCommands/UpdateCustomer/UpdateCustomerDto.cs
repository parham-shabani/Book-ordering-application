using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.CustomerCommands.UpdateCustomer
{
    public class UpdateCustomerDto
    {
        public int id {  get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
