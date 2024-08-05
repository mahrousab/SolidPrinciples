using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.After
{
	public class BasicMath : IBasicMath
	{
		public int Max(params int[] nums)
		{
			return nums.Max();
		}

		public int Min(params int[] nums)
		{
			return nums.Min();
		}

		public int Sum(params int[] nums)
		{
			return nums.Sum();
		}
	}
}
