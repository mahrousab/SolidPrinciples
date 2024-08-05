using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LSP.Before
{
	public class Vehicle
	{
		public virtual string Color() => "Red";
	}

	public class Lexus : Vehicle {

		public override string Color() => "Black";
	}

	public class Mercedes : Lexus
	{
		public override string Color() => "White";
	}
}
