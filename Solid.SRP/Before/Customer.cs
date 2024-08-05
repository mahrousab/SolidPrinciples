using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Solid.SRP.Before
{
	public class Customer
	{

		List<CustomerDTO> lst = null;

        public Customer()
        {
            lst = new();
        }

        public void AddCustomer(CustomerDTO customer)
        {
            lst.Add(customer);
            AddLogs($"{customer.Fullname} added");
        }

        public string DisplayCustomer()
        {
            string customer = JsonSerializer.Serialize(lst);
            AddLogs($" customers retrieved{customer}");

            return customer;
        }
        void AddLogs(string message)
        {
            Console.WriteLine(message);
        }
    }
}
