using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.After
{
	public interface IVehicle
	{
		public string Color();
	}
	public class Lexus : IVehicle
	{
		public string Color() => "black";
	}

	public class Mercedes : IVehicle
	{
		public string Color() => "white";
	}


}
