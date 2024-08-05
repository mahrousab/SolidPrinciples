using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Solid.SRP.After
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
			Logs.AddLogs($"{customer.Fullname} added");
		}

		public string DisplayCustomer()
		{
			string customer = JsonSerializer.Serialize(lst);
			Logs.AddLogs($" customers retrieved{customer}");

			return customer;
		}
	}
}
