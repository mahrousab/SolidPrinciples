using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ISP.Before
{
	public class BasicMath : IMath
	{
		public bool Even(params int[] nums)
		{
			bool isEven = Sum(nums)%2 == 0;

			return isEven;
		}

		public int Max(params int[] nums)
		{
			return nums.Max();
		}

		public int Min(params int[] nums)
		{
			return nums.Min();
		}

		public bool Odd(params int[] nums)
		{
			bool isOdd = Sum(nums)%2!=0;

			return isOdd;
		}

		public int Sum(params int[] nums)
		{
			return nums.Sum();
		}
	}
}
