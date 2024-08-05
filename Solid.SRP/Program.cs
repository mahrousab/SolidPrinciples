

using Solid.SRP;
using Solid.SRP.After;

Customer c = new();
c.AddCustomer(new CustomerDTO
{
	Id = 1,
	Fullname = "John Doe",
	Email = "johndoe@gmail.col"
});
c.DisplayCustomer();



