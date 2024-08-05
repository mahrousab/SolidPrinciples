using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP
{
	public class LowLevel : ILevel
	{
		public string GetMessage()
		{
			return $"In {nameof(LowLevel)}";
		}
	}
}
