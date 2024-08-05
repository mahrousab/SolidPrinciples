using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.After
{
	public interface IMath
	{
		public bool IsEven(params int[] nums);
		public bool IsOdd(params int[] nums);
	}
}
